// Trong file: UI/User/Child_UserMainDashboard/Form_UserChat.cs
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
        private string myPCName;
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
            // Lấy tên máy tính hiện tại của người dùng
            myPCName = await firebaseDB.GetPCNameForUser(currentUser.Username);

            if (string.IsNullOrEmpty(myPCName))
            {
                MessageBox.Show("Bạn chưa được gán vào máy nào đang hoạt động. Không thể chat.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            this.currentReceiver = "Admin"; // Mặc định chat với Admin
            await RefreshAllData();
            ListenForChanges();
        }

        // Tải lại toàn bộ dữ liệu (tin nhắn, danh sách online) và làm mới UI
        private async Task RefreshAllData()
        {
            if (this.IsDisposed) return;

            allMessages = await firebaseDB.GetAllMessages();
            var onlinePCs = await firebaseDB.GetOnlinePCs();

            // Tạo danh sách người để chat: bao gồm các máy online khác và Admin
            var chatPartners = onlinePCs
                .Select(pc => pc.Name)
                .Where(name => name != myPCName)
                .ToList();

            chatPartners.Insert(0, "Admin"); // Luôn có thể chat với Admin

            string selectedPartner = listBoxOnlinePCs.SelectedItem?.ToString();

            listBoxOnlinePCs.DataSource = chatPartners;

            // Giữ lại lựa chọn hiện tại nếu có thể
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

        // Lắng nghe sự thay đổi trên node "Messages" của Firebase
        private async void ListenForChanges()
        {
            messageListener = await firebaseDB.client.OnAsync("Messages",
                (s, args, context) =>
                {
                    if (this.IsDisposed || !this.IsHandleCreated) return;
                    // Khi có tin nhắn mới, tải lại toàn bộ dữ liệu
                    this.Invoke((MethodInvoker)async delegate { await RefreshAllData(); });
                });
        }

        // Tải nội dung cuộc trò chuyện với một người cụ thể
        private void LoadConversation(string partnerName)
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
        }

        // Xử lý sự kiện gửi tin nhắn
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

        // Xử lý khi người dùng chọn một người khác để chat
        private void listBoxOnlinePCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOnlinePCs.SelectedItem != null)
            {
                currentReceiver = listBoxOnlinePCs.SelectedItem.ToString();
                LoadConversation(currentReceiver);
            }
        }

        // Thêm một tin nhắn vào giao diện
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

            // Phân biệt tin nhắn của mình và của người khác
            if (message.Sender == myPCName)
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
            flowLayoutPanelMessages.ScrollControlIntoView(msgLabel); // Tự động cuộn xuống tin nhắn mới nhất
        }

        // Hủy lắng nghe sự kiện khi đóng form để tránh rò rỉ bộ nhớ
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            messageListener?.Dispose();
            base.OnFormClosing(e);
        }
    }
}