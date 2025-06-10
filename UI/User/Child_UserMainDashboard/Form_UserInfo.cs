using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserInfo : Form
    {
        private readonly Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> transactionList; 

        public Form_UserInfo(Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();
            this.transactionList = new List<Order>();

            // Gán sự kiện cho các controls
            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            this.btnCloseDetail.Click += new System.EventHandler(this.btnCloseDetail_Click);
        }

        private async void Form_UserInfo_Load(object sender, EventArgs e)
        {
            panelDetailView.Visible = false; // Luôn ẩn khung chi tiết khi bắt đầu

            if (currentUser == null) return;

            // Load thông tin cá nhân
            lblFullName.Text = currentUser.FullName;
            lblUsername.Text = "@" + currentUser.Username;
            lblEmail.Text = currentUser.Email;
            lblPhoneNumber.Text = currentUser.PhoneNumber;
            lblJoinedDate.Text = "Tham gia ngày " + currentUser.CreationTimestamp.ToLocalTime().ToString("dd/MM/yyyy");

            // Load các chỉ số
            PC activePC = await firebaseDB.GetActivePCForUser(currentUser.Username);
            if (activePC != null)
            {
                lblCurrentBudget.Text = $"{activePC.Budget:N0} đ";
                lblTimeRemaining.Text = activePC.TimeRemaining?.ToString(@"hh\:mm\:ss") ?? "00:00:00";
            }
            else
            {
                lblCurrentBudget.Text = "Không trong phiên";
                lblTimeRemaining.Text = "00:00:00";
            }

            // Load lịch sử giao dịch thật
            await LoadRealOrders();
        }

        private async Task LoadRealOrders()
        {
            var realOrders = await firebaseDB.GetOrdersForUser(currentUser.Username);

            transactionList = realOrders
                .Where(o => o.Timestamp >= DateTime.UtcNow.AddDays(-1))
                .OrderByDescending(t => t.Timestamp)
                .ToList();

            dataGridViewTransactions.Rows.Clear();
            if (transactionList.Any())
            {
                foreach (var trans in transactionList)
                {
                    // === BẮT ĐẦU VÙNG SỬA LỖI ===
                    string transactionTypeDisplay;

                    // Logic kiểm tra mới: Ưu tiên kiểm tra danh sách món hàng trước
                    // Nếu có món hàng, chắc chắn là "Gọi món", bất kể "Type" là gì (xử lý cho dữ liệu cũ)
                    if (trans.Items != null && trans.Items.Any())
                    {
                        transactionTypeDisplay = "Gọi món";
                    }
                    else if (trans.Type == TransactionType.PcUsage)
                    {
                        transactionTypeDisplay = "Sử dụng máy";
                    }
                    else
                    {
                        // Mặc định nếu không rơi vào 2 trường hợp trên
                        transactionTypeDisplay = trans.Description ?? "Giao dịch khác";
                    }
                    // === KẾT THÚC VÙNG SỬA LỖI ===

                    dataGridViewTransactions.Rows.Add(
                        trans.Timestamp.ToLocalTime().ToString("g"),
                        transactionTypeDisplay, // <-- Sử dụng chuỗi vừa được xác định chính xác
                        $"{trans.GrandTotal:N0}",
                        null,
                        trans.Status
                    );
                }
            }
        }


        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào cột nút "Chi tiết" và không phải header
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTransactions.Columns["colDetails"].Index)
            {
                // Lấy hóa đơn tương ứng từ danh sách đã lưu
                Order selectedOrder = this.transactionList[e.RowIndex];
                ShowDetailPanel(selectedOrder);
            }
        }

        private void ShowDetailPanel(Order order)
        {
            panelDetailView.Visible = true;
            lblDetailTitle.Text =   "Chi tiết giao dịch";

            // KIỂM TRA MỚI: Ưu tiên hiển thị chi tiết món ăn nếu có
            // Điều này sẽ đúng cho cả hóa đơn mới (Type=FoodOrder) và hóa đơn cũ (có Items)
            if (order.Items != null && order.Items.Any())
            {
                dgvDetailItems.Visible = true;
                lblDetailInfo.Visible = false;

                dgvDetailItems.Rows.Clear();
                foreach (var item in order.Items)
                {
                    dgvDetailItems.Rows.Add(
                        item.Product.Name,
                        item.Quantity,
                        $"{item.UnitPrice:N0} đ",
                        $"{item.LineTotal:N0} đ"
                    );
                }
            }
            // Chỉ hiển thị chi tiết dùng máy nếu Type là PcUsage và không có món hàng nào
            else if (order.Type == TransactionType.PcUsage)
            {
                dgvDetailItems.Visible = false;
                lblDetailInfo.Visible = true;

                lblDetailInfo.Text = $"Loại hóa đơn:   Sử dụng máy\n\n" +
                                     $"Số tiền nạp:      {order.GrandTotal:N0} đ\n\n" +
                                     $"Số giờ mua được:  {order.TimePurchased?.ToString(@"hh\:mm\:ss") ?? "N/A"}\n\n" +
                                     $"Trạng thái:       {order.Status}";
            }
        }

        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            panelDetailView.Visible = false;

        }
    }
}