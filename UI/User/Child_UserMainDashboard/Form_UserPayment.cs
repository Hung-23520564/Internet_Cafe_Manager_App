﻿using Internet_Cafe_Manager_App.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserPayment : Form
    {
        private readonly Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> unpaidFoodOrders;
        private string _currentPaymentType = "";
        private decimal _currentPaymentAmount = 0;

        private int currentPricePerUnit;
        private int currentTimePerUnitMinutes;

        private const string ADMIN_BANK_BIN = "970443";
        private const string ADMIN_ACCOUNT_NO = "0606062005";
        private const string ADMIN_ACCOUNT_NAME = "TRAN QUANG HUY";

        public Form_UserPayment(Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();
            this.unpaidFoodOrders = new List<Order>();
        }

        private async void Form_UserPayment_Load(object sender, EventArgs e)
        {
            await LoadPriceSettings();
            await LoadUnpaidFoodOrders();
            CreateTopUpPackages();
        }

        private async Task LoadPriceSettings()
        {
            try
            {
                var response = await firebaseDB.client.GetAsync("Configuration/PriceSettings");
                if (response.Body != "null")
                {
                    var settings = response.ResultAs<Dictionary<string, int>>();
                    currentPricePerUnit = settings.ContainsKey("Price") ? settings["Price"] : 10000;
                    currentTimePerUnitMinutes = settings.ContainsKey("Minutes") ? settings["Minutes"] : 30;
                }
                else
                {
                    currentPricePerUnit = 10000;
                    currentTimePerUnitMinutes = 30;
                }
            }
            catch
            {
                currentPricePerUnit = 10000;
                currentTimePerUnitMinutes = 30;
            }
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
              { 10000, null }, { 20000, null }, { 50000, null },
              { 100000, null }, { 200000, null }, { 500000, "COMBO NGÀY" },
            };

            flowLayoutPanelPackages.SuspendLayout();
            flowLayoutPanelPackages.Controls.Clear();
            foreach (var package in packages)
            {
                int amount = package.Key;
                TimeSpan time = PC.CalculateTotalTimeFromBudget(amount, currentPricePerUnit, currentTimePerUnitMinutes);
                string timeText = FormatTimeSpanToHoursAndMinutes(time);
                string displayText = !string.IsNullOrEmpty(package.Value)
                    ? $"{amount:N0} đ{Environment.NewLine}({timeText}){Environment.NewLine}{package.Value}"
                    : $"{amount:N0} đ{Environment.NewLine}({timeText})";

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
            flowLayoutPanelPackages.ResumeLayout(true);
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
                ShowQRCode($"FoodOrder_{currentUser.Username}_{DateTime.Now.Ticks}", totalBill);
            }
        }

        private void PackageButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int amount)
            {
                _currentPaymentType = "PCUsage";
                _currentPaymentAmount = amount;
                ShowQRCode($"PCUsage_{currentUser.Username}_{DateTime.Now.Ticks}", amount);
            }
        }

        private async void ShowQRCode(string note, decimal amount)
        {
            panelQRCode.Visible = true;
            btnConfirmPayment.Visible = true;
            lblQRInstruction.Text = $"Số tiền: {amount:N0} đ\n\nNội dung chuyển khoản:\n{note}";
            picQRCode.Image = null;
            lblQRTitle.Text = "Đang tạo mã QR...";
            Application.DoEvents();

            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var requestData = new { accountNo = ADMIN_ACCOUNT_NO, accountName = ADMIN_ACCOUNT_NAME, acqId = ADMIN_BANK_BIN, amount = (int)amount, addInfo = note, format = "png", template = "compact2" };
                    string jsonPayload = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
                    var content = new System.Net.Http.StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://api.vietqr.io/v2/generate", content);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
                        string qrDataURL = result.data.qrDataURL;
                        if (qrDataURL.Contains(","))
                        {
                            byte[] imageBytes = Convert.FromBase64String(qrDataURL.Split(',')[1]);
                            using (var ms = new System.IO.MemoryStream(imageBytes))
                            {
                                picQRCode.Image = Image.FromStream(ms);
                            }
                        }
                        lblQRTitle.Text = "Quét mã để thanh toán";
                    }
                    else { throw new Exception("API Error: " + response.ReasonPhrase); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tạo mã QR: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblQRTitle.Text = "Lỗi tạo mã!";
            }
        }

        private async void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_currentPaymentType) || _currentPaymentAmount <= 0) return;

            bool success = false;
            if (_currentPaymentType == "FoodOrder")
            {
                List<Task> updateTasks = new List<Task>();
                foreach (var order in unpaidFoodOrders)
                {
                    updateTasks.Add(firebaseDB.UpdateOrderStatus(order.OrderId, "Processing"));
                }
                await Task.WhenAll(updateTasks);
                success = true;
            }
            else if (_currentPaymentType == "PCUsage")
            {
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
                    TimePurchased = PC.CalculateTotalTimeFromBudget((int)_currentPaymentAmount, currentPricePerUnit, currentTimePerUnitMinutes)
                };
                success = await firebaseDB.AddOrder(topUpOrder);
            }

            if (success)
            {
                MessageBox.Show("Đã gửi yêu cầu. Vui lòng chờ quản trị viên xác nhận.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelQRCode.Visible = false;
                btnConfirmPayment.Visible = false;
                await LoadUnpaidFoodOrders();
            }
            else
            {
                MessageBox.Show("Gửi yêu cầu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}