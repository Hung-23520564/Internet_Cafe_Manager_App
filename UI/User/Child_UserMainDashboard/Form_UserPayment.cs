using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;
using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard; 

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserPayment : Form
    {
        private readonly Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> unpaidFoodOrders;

        // Lưu lại thông tin của giao dịch đang thực hiện
        private string _currentPaymentType = "";
        private decimal _currentPaymentAmount = 0;
        private Order pendingOrder;

        private const string ADMIN_BANK_BIN = "970443"; //  
        private const string ADMIN_ACCOUNT_NO = "0606062005"; // Số tài khoản của bạn
        private const string ADMIN_ACCOUNT_NAME = "TRAN QUANG HUY"; // Tên chủ tài khoản
                                                                  

        public Form_UserPayment(Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();
            this.unpaidFoodOrders = new List<Order>();
        }

        private async void Form_UserPayment_Load(object sender, EventArgs e)
        {
            await LoadUnpaidFoodOrders();
            CreateTopUpPackages();
        }

        private async Task LoadUnpaidFoodOrders()
        {
            var allOrders = await firebaseDB.GetOrdersForUser(currentUser.Username);
            unpaidFoodOrders = allOrders
                .Where(o => o.Type == TransactionType.FoodOrder && o.Status == "Pending")
                .ToList();

            if (unpaidFoodOrders.Any())
            {
                var displayList = unpaidFoodOrders
                    .SelectMany(o => o.Items.Select(item => new {
                        ItemName = item.Product.Name,
                        Quantity = item.Quantity,
                        LineTotal = item.LineTotal
                    }))
                    .ToList();

                dgvFoodOrders.AutoGenerateColumns = false;
                dgvFoodOrders.DataSource = displayList;

                decimal totalBill = unpaidFoodOrders.Sum(o => o.GrandTotal);
                lblTotalFoodBill.Text = $"Tổng cộng: {totalBill:N0} đ";
                btnPayFood.Enabled = true;
            }
            else
            {
                dgvFoodOrders.DataSource = null;
                lblTotalFoodBill.Text = "Không có hóa đơn chưa thanh toán.";
                btnPayFood.Enabled = false;
            }
        }

        private void CreateTopUpPackages()
        {
            var packages = new Dictionary<int, string>

            {
              { 10000, null },

              { 20000, null },

              { 50000, null },

              { 100000, null },

              { 200000, null },

              { 300000, "COMBO ĐÊM"  },

              { 400000, null },

              { 500000, "COMBO NGÀY" },

            };

            flowLayoutPanelPackages.Controls.Clear();

            foreach (var package in packages)
            {
                int amount = package.Key;
                string comboName = package.Value;
                string displayText;
                TimeSpan time = PC.CalculateTotalTimeFromBudget(amount);
                string timeText = FormatTimeSpanToHoursAndMinutes(time);

                if (!string.IsNullOrEmpty(comboName))
                    displayText = $"{amount:N0} đ{Environment.NewLine}({timeText}){Environment.NewLine}{comboName}";
                else
                    displayText = $"{amount:N0} đ{Environment.NewLine}({timeText})";

                Button packageButton = new Button
                {
                    Text = displayText,
                    Tag = amount,
                    Size = new Size(170, 90),
                    Margin = new Padding(10),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(0, 123, 255),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                packageButton.FlatAppearance.BorderSize = 0;
                packageButton.Click += PackageButton_Click;
                flowLayoutPanelPackages.Controls.Add(packageButton);
            }
        }

        private string FormatTimeSpanToHoursAndMinutes(TimeSpan timeSpan)
        {
            int totalMinutes = (int)timeSpan.TotalMinutes;
            if (totalMinutes < 60) return $"+{totalMinutes} phút";

            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            return minutes == 0 ? $"+{hours} tiếng" : $"+{hours} tiếng {minutes} phút";
        }

        private void btnPayFood_Click(object sender, EventArgs e)
        {
            decimal totalBill = unpaidFoodOrders.Sum(o => o.GrandTotal);
            if (totalBill > 0)
            {
                _currentPaymentType = "FoodOrder";
                _currentPaymentAmount = totalBill;
                ShowQRCode($"FoodOrder_{currentUser.Username}", totalBill);
            }
        }

        private void PackageButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int amount)
            {
                _currentPaymentType = "PCUsage";
                _currentPaymentAmount = amount;
                ShowQRCode($"PCUsage_{currentUser.Username}", amount);
            }
        }

        // THAY THẾ PHƯƠNG THỨC CŨ BẰNG PHIÊN BẢN MỚI NÀY
        private async void ShowQRCode(string note, decimal amount)
        {
            panelQRCode.Visible = true;
            btnConfirmPayment.Visible = true;
            lblQRInstruction.Text = $"Số tiền: {amount:N0} đ\n\nNội dung chuyển khoản:\n{note}";

            // Hiển thị chữ "Đang tạo mã..." trong khi chờ
            picQRCode.Image = null;
            lblQRTitle.Text = "Đang tạo mã QR...";
            Application.DoEvents(); // Cập nhật giao diện ngay lập tức

            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    // 1. Tạo đối tượng chứa thông tin để gửi đi
                    var requestData = new
                    {
                        accountNo = ADMIN_ACCOUNT_NO,
                        accountName = ADMIN_ACCOUNT_NAME,
                        acqId = ADMIN_BANK_BIN,
                        amount = (int)amount,
                        addInfo = note,
                        format = "png",
                        template = "compact2"
                    };

                    // 2. Chuyển đối tượng thành chuỗi JSON và gửi yêu cầu POST
                    string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
                    var content = new System.Net.Http.StringContent(jsonPayload, System.Text.Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://api.vietqr.io/v2/generate", content);

                    if (response.IsSuccessStatusCode)
                    {
                        // 3. Đọc kết quả trả về và lấy dữ liệu ảnh QR
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
                        string qrDataURL = result.data.qrDataURL;

                        // 4. Chuyển đổi chuỗi Base64 thành hình ảnh và hiển thị
                        if (qrDataURL.Contains(","))
                        {
                            string base64Data = qrDataURL.Split(',')[1];
                            byte[] imageBytes = Convert.FromBase64String(base64Data);
                            using (var ms = new System.IO.MemoryStream(imageBytes))
                            {
                                picQRCode.Image = Image.FromStream(ms);
                            }
                        }
                        lblQRTitle.Text = "Quét mã để thanh toán"; // Đặt lại tiêu đề
                    }
                    else
                    {
                        throw new Exception("API trả về lỗi: " + response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tạo mã QR. Vui lòng kiểm tra lại thông tin và kết nối mạng.\nLỗi: {ex.Message}", "Lỗi tạo mã QR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblQRTitle.Text = "Lỗi tạo mã!";
            }

            // Logic tạo Order tạm thời giữ nguyên
            pendingOrder = new Order
            {
                OrderId = Guid.NewGuid().ToString(),
                UserID = currentUser.UserId,
                Username = currentUser.Username,
                GrandTotal = amount,
                Timestamp = DateTime.UtcNow,
                Status = "Pending", // Sẽ được cập nhật khi Admin xác nhận
                Type = (note.StartsWith("FoodOrder")) ? TransactionType.FoodOrder : TransactionType.PcUsage,
                Description = (note.StartsWith("FoodOrder")) ? "Thanh toán đồ ăn" : $"Nạp {amount:N0} đ",
                TimePurchased = (note.StartsWith("PCUsage")) ? (TimeSpan?)PC.CalculateTotalTimeFromBudget((int)amount) : null,
                Items = (note.StartsWith("FoodOrder")) ? unpaidFoodOrders.SelectMany(o => o.Items).ToList() : new List<CartItemEntry>()
            };
        }

        private async void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPaymentType) || _currentPaymentAmount <= 0) return;

            bool success = false;

            if (_currentPaymentType == "FoodOrder")
            {
                // === BẮT ĐẦU VÙNG SỬA LỖI ===
                // Đối với đồ ăn, cập nhật trạng thái của các hóa đơn hiện có thành "Processing"
                // để admin có thể xác nhận sau.
                List<Task> updateTasks = new List<Task>();
                foreach (var order in unpaidFoodOrders)
                {
                    updateTasks.Add(firebaseDB.UpdateOrderStatus(order.OrderId, "Processing"));
                }
                await Task.WhenAll(updateTasks); // Chờ tất cả các cập nhật hoàn tất
                success = true; // Giả sử thành công nếu không có lỗi
                                // === KẾT THÚC VÙNG SỬA LỖI ===
            }
            else if (_currentPaymentType == "PCUsage")
            {
                // Đối với nạp giờ, tạo một yêu cầu mới với trạng thái "Pending"
                var topUpOrder = new Order
                {
                    OrderId = Guid.NewGuid().ToString(),
                    UserID = currentUser.UserId,
                    Username = currentUser.Username,
                    GrandTotal = _currentPaymentAmount,
                    Timestamp = DateTime.UtcNow,
                    Status = "Processing",
                    Type = TransactionType.PcUsage,
                    Description = $"Nạp {_currentPaymentAmount:N0} đ",
                    TimePurchased = PC.CalculateTotalTimeFromBudget((int)_currentPaymentAmount)
                };
                success = await firebaseDB.AddOrder(topUpOrder);
            }

            if (success)
            {
                MessageBox.Show("Đã gửi yêu cầu. Vui lòng chờ quản trị viên xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gửi yêu cầu thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reset giao diện và tải lại danh sách hóa đơn
            panelQRCode.Visible = false;
            btnConfirmPayment.Visible = false;
            _currentPaymentType = "";
            _currentPaymentAmount = 0;

            // Dòng này sẽ làm mới bảng và xóa đi các hóa đơn vừa thanh toán
            await LoadUnpaidFoodOrders();
        }
    }
}