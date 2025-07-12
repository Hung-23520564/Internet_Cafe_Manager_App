using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;
using FireSharp.EventStreaming;
using FireSharp.Response;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class FormChat : Form
    {
        private FirebaseDB firebaseDB;
        private List<ChatMessage> allMessages = new List<ChatMessage>();
        private string currentChatPartner = null;
        private EventStreamResponse messageListener;

        public FormChat()
        {
            InitializeComponent();
            firebaseDB = new FirebaseDB();
        }

        private async void FormChat_Load(object sender, EventArgs e)
        {
            await RefreshChatSessions();
            ListenForChanges();
        }

        private async void ListenForChanges()
        {
            messageListener = await firebaseDB.client.OnAsync("Messages",
                (s, args, context) =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;

                    this.Invoke((MethodInvoker)async delegate
                    {
                        await RefreshChatSessions();

                        if (currentChatPartner != null)
                        {
                            LoadConversation(currentChatPartner);
                        }
                    });
                });
        }

        private async Task RefreshChatSessions()
        {
            allMessages = await firebaseDB.GetAllMessages();
            var onlinePCs = await firebaseDB.GetOnlinePCs();


            var chatPartners = onlinePCs
                .Select(pc => pc.Name)
                .OrderBy(name => name)
                .ToList();

            flowLayoutPanelSessions.Controls.Clear();
            foreach (var partner in chatPartners)
            {
                Button sessionButton = new Button
                {
                    Text = partner,
                    Tag = partner,
                    Width = flowLayoutPanelSessions.ClientSize.Width - 15,
                    Height = 40,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    ForeColor = Color.Gainsboro
                };
                sessionButton.Click += SessionButton_Click;

                // KIỂM TRA TIN NHẮN CHƯA ĐỌC
                bool hasUnread = allMessages.Any(m => m.Sender == partner && m.Receiver == "Admin" && !m.IsRead);
                if (hasUnread)
                {
                    sessionButton.Text = $"{partner} (!)"; // THÊM DẤU HIỆU
                    sessionButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    sessionButton.BackColor = Color.FromArgb(125, 102, 211); // Màu nổi bật hơn

                }
                else
                {
                    sessionButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    sessionButton.BackColor = Color.FromArgb(45, 45, 85);
                }
                flowLayoutPanelSessions.Controls.Add(sessionButton);
            }
        }

        // KHI ADMIN CHỌN MỘT PHIÊN CHAT

        private async void SessionButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            string partnerName = button.Tag.ToString();
            currentChatPartner = partnerName;

            LoadConversation(partnerName);

            // ĐÁNH DẤU CÁC TIN NHẮN LÀ ĐÃ ĐỌC

            var unreadMessages = allMessages
                .Where(m => m.Sender == partnerName && m.Receiver == "Admin" && !m.IsRead)
                .ToList();

            foreach (var msg in unreadMessages)
            {
                await firebaseDB.MarkMessageAsRead(msg.MessageId);
            }
            // Tải lại danh sách phiên chat để xóa dấu "!"
            await RefreshChatSessions();
        }


        private void LoadConversation(string partnerName)
        {
            if (string.IsNullOrEmpty(partnerName)) return;

            lblChattingWith.Text = $"Trò chuyện với {partnerName}";

            var conversation = allMessages
                .Where(m => (m.Sender == partnerName && m.Receiver == "Admin") || (m.Sender == "Admin" && m.Receiver == partnerName))
                .OrderBy(m => m.Timestamp)
                .ToList();

            flowLayoutPanelMessages.Controls.Clear();
            foreach (var msg in conversation)
            {
                AddMessageToPanel(msg);
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (currentChatPartner == null)
            {
                MessageBox.Show("Vui lòng chọn một cuộc trò chuyện để trả lời.");
                return;
            }

            string content = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(content)) return;

            var newMessage = new ChatMessage
            {
                MessageId = Guid.NewGuid().ToString(),
                Sender = "Admin",
                Receiver = currentChatPartner,
                Content = content,
                Timestamp = DateTime.UtcNow,
                IsRead = false // Tin nhắn mới gửi luôn là chưa đọc

            };

            bool success = await firebaseDB.SendMessage(newMessage);

            if (success)
            {
                txtMessage.Clear();
            }
            else
            {
                MessageBox.Show("Gửi tin nhắn thất bại.");
            }
        }

        // THÊM TIN NHẮN VÀO GIAO DIỆN VỚI CĂN LỀ
        private void AddMessageToPanel(ChatMessage message)
        {
            // A. TẠO BONG BÓNG CHAT VÀ NỘI DUNG BÊN TRONG
            // Sử dụng RoundedPanel có sẵn của bạn để bo góc
            var bubble = new CustomControls.RoundedPanel
            {
                CornerRadius = 15,
                Padding = new Padding(10),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                // Giới hạn chiều rộng tối đa của bong bóng
                MaximumSize = new Size(Convert.ToInt32(flowLayoutPanelMessages.ClientSize.Width * 0.7), 0)
            };

            // Label chứa nội dung tin nhắn
            var msgLabel = new Label
            {
                Text = message.Content,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.White,
                Dock = DockStyle.Fill, // Tự dãn theo nội dung
                AutoSize = true
            };

            // Label chứa thời gian gửi
            var timeLabel = new Label
            {
                Text = message.Timestamp.ToLocalTime().ToString("HH:mm"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.Gainsboro,
                Dock = DockStyle.Top, // Nằm trên msgLabel
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = false,
                Height = 18
            };

            bubble.Controls.Add(msgLabel);
            bubble.Controls.Add(timeLabel);

            // B. TẠO MỘT "DÒNG" ĐỂ CHỨA BONG BÓNG VÀ CĂN LỀ
            var row = new Panel
            {
                Width = flowLayoutPanelMessages.ClientSize.Width - 25,
                Margin = new Padding(0, 0, 0, 10),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // C. KIỂM TRA VÀ CĂN LỀ
            if (message.Sender == "Admin")
            {
                // Tin của Admin: Căn phải
                bubble.BackColor = Color.FromArgb(0, 132, 255); // Màu xanh dương
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                // Thêm bubble vào row trước, sau đó mới tính vị trí
                row.Controls.Add(bubble);
                bubble.Left = row.ClientSize.Width - bubble.Width;
            }
            else
            {
                // Tin của User: Căn trái
                bubble.BackColor = Color.FromArgb(62, 62, 66); // Màu xám tối
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                row.Controls.Add(bubble);
                bubble.Left = 0;
            }

            // Thêm dòng vào FlowLayoutPanel chính và cuộn tới tin nhắn mới
            flowLayoutPanelMessages.Controls.Add(row);
            flowLayoutPanelMessages.ScrollControlIntoView(row);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            messageListener?.Dispose();
            base.OnFormClosing(e);
        }
    }
}