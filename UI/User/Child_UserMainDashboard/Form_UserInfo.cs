using FireSharp.EventStreaming;
using FireSharp.Response;
using Internet_Cafe_Manager_App.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserInfo : Form
    {
        private Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> transactionList;
        private System.Windows.Forms.Timer userInfoTimer;
        private PC activePC;
        private EventStreamResponse pcListener;

        private Form_LockScreen lockScreenForm = null;

        // Thêm biến lưu cài đặt giá
        private int currentPricePerUnit;
        private int currentTimePerUnitMinutes;

        public Form_UserInfo(Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();
            this.transactionList = new List<Order>();

            this.userInfoTimer = new System.Windows.Forms.Timer();
            this.userInfoTimer.Interval = 1000;
            this.userInfoTimer.Tick += new System.EventHandler(this.userInfoTimer_Tick);

            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            this.btnCloseDetail.Click += new System.EventHandler(this.btnCloseDetail_Click);
        }

        private async void Form_UserInfo_Load(object sender, EventArgs e)
        {
            panelDetailView.Visible = false;
            if (currentUser == null) return;

            await LoadPriceSettings();

            lblFullName.Text = currentUser.FullName;
            lblUsername.Text = "@" + currentUser.Username;
            lblEmail.Text = currentUser.Email;
            lblPhoneNumber.Text = currentUser.PhoneNumber;
            lblJoinedDate.Text = "Tham gia ngày " + currentUser.CreationTimestamp.ToLocalTime().ToString("dd/MM/yyyy");

            await UpdateSessionInfo();
            this.FormClosing += (s, ev) => { pcListener?.Dispose(); };
            await LoadRealOrders();
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
                    currentPricePerUnit = 10000; // Giá mặc định
                    currentTimePerUnitMinutes = 30; // Thời gian mặc định
                }
            }
            catch
            {
                // Fallback nếu có lỗi
                currentPricePerUnit = 10000;
                currentTimePerUnitMinutes = 30;
            }
        }

        private async Task UpdateSessionInfo()
        {
            activePC = await firebaseDB.GetActivePCForUser(currentUser.Username);
            lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed);

            if (activePC != null && activePC.Status == PCStatus.InUse)
            {
                lblCurrentBudget.Text = $"{activePC.Budget:N0} đ";
                pcListener?.Dispose();
                pcListener = await firebaseDB.ListenToPCChanges(activePC.Name, Pc_ValueChanged);
                userInfoTimer.Start();
                UpdateUITimeDisplays();
            }
            else
            {
                lblCurrentBudget.Text = "Không trong phiên";
                lblTimeRemaining.Text = "00:00:00";
                userInfoTimer.Stop();
                pcListener?.Dispose();
            }
        }

        private void userInfoTimer_Tick(object sender, EventArgs e)
        {
            if (activePC != null && activePC.Status == PCStatus.InUse)
            {
                UpdateUITimeDisplays();
                if (lblTimeRemaining.Text == "00:00:00")
                {
                    userInfoTimer.Stop();
                    if (lockScreenForm == null || lockScreenForm.IsDisposed)
                    {
                        lockScreenForm = new Form_LockScreen(this.currentUser);
                        lockScreenForm.ShowDialog();
                    }
                }
            }
            else
            {
                lblTimeRemaining.Text = "00:00:00";
                lblCurrentBudget.Text = "Không trong phiên";
                userInfoTimer.Stop();
            }
        }

        private async void Pc_ValueChanged(object sender, FireSharp.EventStreaming.ValueChangedEventArgs args, object context)
        {
            try
            {
                var updatedPC = Newtonsoft.Json.JsonConvert.DeserializeObject<PC>(args.Data);
                if (updatedPC != null)
                {
                    activePC = updatedPC;
                    currentUser = await firebaseDB.GetUser(currentUser.Username);

                    if (this.IsHandleCreated && !this.IsDisposed)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblCurrentBudget.Text = $"{activePC.Budget:N0} đ";
                            UpdateUITimeDisplays();
                            lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed);

                            if (activePC.Status == PCStatus.InUse && lockScreenForm != null && !lockScreenForm.IsDisposed)
                            {
                                if (activePC.TimeRemaining.HasValue && activePC.TimeRemaining.Value.TotalSeconds > 0)
                                {
                                    lockScreenForm.UnlockScreen();
                                    lockScreenForm = null;
                                    userInfoTimer.Start();
                                }
                            }

                            if (activePC.Status != PCStatus.InUse)
                            {
                                userInfoTimer.Stop();
                                lblTimeRemaining.Text = "00:00:00";
                                lblCurrentBudget.Text = "Không trong phiên";
                                pcListener?.Dispose();
                            }
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật PC từ listener: " + ex.Message);
            }
        }

        private void UpdateUITimeDisplays()
        {
            if (activePC == null || !activePC.StartTime.HasValue || activePC.Status != PCStatus.InUse)
            {
                lblTimeRemaining.Text = "00:00:00";
                lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed);
                return;
            }

            TimeSpan totalPurchasedTime = PC.CalculateTotalTimeFromBudget(activePC.Budget, currentPricePerUnit, currentTimePerUnitMinutes);
            TimeSpan timeElapsed = DateTime.Now - activePC.StartTime.Value;
            TimeSpan calculatedTimeRemaining = totalPurchasedTime.Subtract(timeElapsed);

            if (calculatedTimeRemaining < TimeSpan.Zero)
            {
                calculatedTimeRemaining = TimeSpan.Zero;
            }

            lblTimeRemaining.Text = calculatedTimeRemaining.ToString(@"hh\:mm\:ss");
            lblTotalTimePlayed.Text = FormatTotalTime(timeElapsed);
        }

        private string FormatTotalTime(TimeSpan timeSpan)
        {
            if (timeSpan.TotalSeconds <= 0) return "0 giây";
            var parts = new List<string>();
            if (timeSpan.Days > 0) parts.Add($"{timeSpan.Days} ngày");
            if (timeSpan.Hours > 0) parts.Add($"{timeSpan.Hours} giờ");
            if (timeSpan.Minutes > 0) parts.Add($"{timeSpan.Minutes} phút");
            if (timeSpan.Seconds > 0) parts.Add($"{timeSpan.Seconds} giây");
            return string.Join(" ", parts);
        }

        private async Task LoadRealOrders()
        {
            var realOrders = await firebaseDB.GetOrdersForUser(currentUser.Username);
            transactionList = realOrders
                .Where(o => o.Timestamp >= DateTime.UtcNow.AddDays(-30))
                .OrderByDescending(t => t.Timestamp)
                .ToList();
            dataGridViewTransactions.Rows.Clear();
            if (transactionList.Any())
            {
                foreach (var trans in transactionList)
                {
                    string transactionTypeDisplay = trans.Type == TransactionType.FoodOrder ? "Gọi món" : "Sử dụng máy";
                    dataGridViewTransactions.Rows.Add(
                        trans.Timestamp.ToLocalTime().ToString("g"),
                        transactionTypeDisplay,
                        $"{trans.GrandTotal:N0}",
                        "Xem",
                        trans.Status
                    );
                }
            }
        }

        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTransactions.Columns["colDetails"].Index)
            {
                ShowDetailPanel(transactionList[e.RowIndex]);
            }
        }

        private void ShowDetailPanel(Order order)
        {
            panelDetailView.Visible = true;
            lblDetailTitle.Text = "Chi tiết giao dịch";
            if (order.Type == TransactionType.FoodOrder && order.Items != null && order.Items.Any())
            {
                dgvDetailItems.Visible = true;
                lblDetailInfo.Visible = false;
                dgvDetailItems.Rows.Clear();
                foreach (var item in order.Items)
                {
                    dgvDetailItems.Rows.Add(item.Product.Name, item.Quantity, $"{item.UnitPrice:N0} đ", $"{item.LineTotal:N0} đ");
                }
            }
            else
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