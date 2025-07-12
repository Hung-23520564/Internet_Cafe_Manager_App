// Thay thế toàn bộ nội dung file: UI/User/Child_UserMainDashboard/Form_UserChat.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;
using FireSharp.EventStreaming;
using FireSharp.Response;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserChat : Form
    {
        private FirebaseDB firebaseDB;
        private readonly Users currentUser;
        public string myPCName { get; private set; }
        private string currentReceiver;
        private List<ChatMessage> allMessages = new List<ChatMessage>();
        private EventStreamResponse messageListener;

        public Form_UserChat(Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();
        }

        private async void Form_UserChat_Load(object sender, EventArgs e)
        {
            myPCName = await firebaseDB.GetPCNameForUser(currentUser.Username);

            if (string.IsNullOrEmpty(myPCName))
            {
                MessageBox.Show("Bạn chưa được gán vào máy nào đang hoạt động. Không thể chat.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            this.currentReceiver = "Admin"; // Người dùng mặc định chat với Admin
            await RefreshAllData();
            ListenForChanges();
        }

        private async Task RefreshAllData()
        {
            if (this.IsDisposed) return;

            allMessages = await firebaseDB.GetAllMessages();
            var onlinePCs = await firebaseDB.GetOnlinePCs();

            var chatPartners = onlinePCs
                .Select(pc => pc.Name)
                .Where(name => name != myPCName)
                .ToList();

            chatPartners.Insert(0, "Admin");

            string selectedPartner = listBoxOnlinePCs.SelectedItem?.ToString();

            listBoxOnlinePCs.DataSource = chatPartners;

            if (selectedPartner != null && listBoxOnlinePCs.Items.Contains(selectedPartner))
            {
                listBoxOnlinePCs.SelectedItem = selectedPartner;
            }
            else if (listBoxOnlinePCs.Items.Contains(currentReceiver))
            {
                listBoxOnlinePCs.SelectedItem = currentReceiver;
            }

            LoadConversation(currentReceiver);
        }

        private async void ListenForChanges()
        {
            messageListener = await firebaseDB.client.OnAsync("Messages",
                (s, args, context) =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;
                    this.Invoke((MethodInvoker)async delegate { await RefreshAllData(); });
                });
        }

        private async void LoadConversation(string partnerName)
        {
            if (string.IsNullOrEmpty(partnerName))
            {
                lblChattingWith.Text = "Chọn một người để trò chuyện";
                flowLayoutPanelMessages.Controls.Clear();
                return;
            }

            lblChattingWith.Text = $"Trò chuyện với {partnerName}";

            var conversation = allMessages
                .Where(m => (m.Sender == myPCName && m.Receiver == partnerName) || (m.Sender == partnerName && m.Receiver == myPCName))
                .OrderBy(m => m.Timestamp)
                .ToList();

            flowLayoutPanelMessages.Controls.Clear();
            foreach (var msg in conversation)
            {
                AddMessageToPanel(msg);
            }

            // ĐÁNH DẤU TIN NHẮN ĐÃ ĐỌC
            var unreadMessages = conversation
                .Where(m => m.Sender == partnerName && m.Receiver == myPCName && !m.IsRead)
                .ToList();

            if (unreadMessages.Any())
            {
                foreach (var msg in unreadMessages)
                {
                    await firebaseDB.MarkMessageAsRead(msg.MessageId);
                }
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string content = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(currentReceiver)) return;

            var newMessage = new ChatMessage
            {
                MessageId = Guid.NewGuid().ToString(),
                Sender = myPCName,
                Receiver = currentReceiver,
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

        private void listBoxOnlinePCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOnlinePCs.SelectedItem != null)
            {
                currentReceiver = listBoxOnlinePCs.SelectedItem.ToString();
                LoadConversation(currentReceiver);
            }
        }

        private void AddMessageToPanel(ChatMessage message)
        {
            // A. TẠO BONG BÓNG CHAT VÀ NỘI DUNG BÊN TRONG
            var bubble = new CustomControls.RoundedPanel
            {
                CornerRadius = 15,
                Padding = new Padding(10),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                MaximumSize = new Size(Convert.ToInt32(flowLayoutPanelMessages.ClientSize.Width * 0.7), 0)
            };

            var msgLabel = new Label
            {
                Text = message.Content,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            var timeLabel = new Label
            {
                Text = message.Timestamp.ToLocalTime().ToString("HH:mm"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.Gainsboro,
                Dock = DockStyle.Top,
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
            if (message.Sender == this.myPCName)
            {
                // Tin của mình: Căn phải
                bubble.BackColor = Color.FromArgb(0, 132, 255);
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                row.Controls.Add(bubble);
                bubble.Left = row.ClientSize.Width - bubble.Width;
            }
            else
            {
                // Tin của người khác: Căn trái
                bubble.BackColor = Color.FromArgb(62, 62, 66);
                bubble.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                row.Controls.Add(bubble);
                bubble.Left = 0;
            }

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