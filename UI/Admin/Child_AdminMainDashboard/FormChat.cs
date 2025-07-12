// Trong file: UI/Admin/Child_AdminMainDashboard/FormChat.cs
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

        // Lắng nghe sự kiện trên Firebase
        private async void ListenForChanges()
        {
            messageListener = await firebaseDB.client.OnAsync("Messages",
                (s, args, context) =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;

                    this.Invoke((MethodInvoker)async delegate
                    {
                        // Khi có tin nhắn mới, tải lại danh sách phiên chat
                        await RefreshChatSessions();
                        // Nếu đang trong một cuộc hội thoại, tải lại nó
                        if (currentChatPartner != null)
                        {
                            LoadConversation(currentChatPartner);
                        }
                    });
                });
        }

        // Tải và làm mới danh sách các phiên chat
        private async Task RefreshChatSessions()
        {
            allMessages = await firebaseDB.GetAllMessages();
            var onlinePCs = await firebaseDB.GetOnlinePCs();

            // Lấy danh sách tên các máy đang online để tạo phiên chat
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

                // Kiểm tra tin nhắn chưa đọc để làm nổi bật
                bool hasUnread = allMessages.Any(m => m.Sender == partner && m.Receiver == "Admin" && !m.IsRead);
                if (hasUnread)
                {
                    sessionButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    sessionButton.BackColor = Color.FromArgb(85, 85, 130);
                }
                else
                {
                    sessionButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    sessionButton.BackColor = Color.FromArgb(45, 45, 85);
                }
                flowLayoutPanelSessions.Controls.Add(sessionButton);
            }
        }

        // Khi Admin chọn một phiên chat
        private async void SessionButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            string partnerName = button.Tag.ToString();
            currentChatPartner = partnerName;

            LoadConversation(partnerName);

            // Đánh dấu các tin nhắn chưa đọc trong cuộc hội thoại này là đã đọc
            var unreadMessages = allMessages
                .Where(m => m.Sender == partnerName && m.Receiver == "Admin" && !m.IsRead)
                .ToList();

            foreach (var msg in unreadMessages)
            {
                await firebaseDB.MarkMessageAsRead(msg.MessageId);
            }
            await RefreshChatSessions(); // Làm mới danh sách để bỏ đánh dấu đậm
        }

        // Tải nội dung cuộc hội thoại
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

        // Gửi tin nhắn
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
                IsRead = false
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

        // Thêm tin nhắn vào giao diện
        private void AddMessageToPanel(ChatMessage message)
        {
            Label msgLabel = new Label
            {
                Text = $"[{message.Timestamp.ToLocalTime():HH:mm}] {message.Sender}:\n{message.Content}",
                Font = new Font("Segoe UI", 10F),
                AutoSize = true,
                MaximumSize = new Size(flowLayoutPanelMessages.ClientSize.Width - 40, 0),
                Padding = new Padding(10),
                Margin = new Padding(5)
            };

            if (message.Sender == "Admin")
            {
                msgLabel.BackColor = Color.FromArgb(0, 122, 204);
                msgLabel.ForeColor = Color.White;
                msgLabel.Margin = new Padding(100, 5, 5, 5); // Căn phải
            }
            else
            {
                msgLabel.BackColor = Color.FromArgb(62, 62, 66);
                msgLabel.ForeColor = Color.WhiteSmoke;
                msgLabel.Margin = new Padding(5, 5, 100, 5); // Căn trái
            }

            flowLayoutPanelMessages.Controls.Add(msgLabel);
            flowLayoutPanelMessages.ScrollControlIntoView(msgLabel);
        }

        // Hủy lắng nghe sự kiện khi đóng form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            messageListener?.Dispose();
            base.OnFormClosing(e);
        }
    }
}