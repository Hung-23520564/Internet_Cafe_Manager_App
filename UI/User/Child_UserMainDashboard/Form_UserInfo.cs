using FireSharp.EventStreaming;
using FireSharp.Response;
using Internet_Cafe_Manager_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserInfo : Form
    {
        private  Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> transactionList;

        private System.Windows.Forms.Timer userInfoTimer; // Đã khai báo

        private PC activePC;
        private FireSharp.Response.EventStreamResponse pcListener;

        public Form_UserInfo(Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.firebaseDB = new FirebaseDB();

            this.transactionList = new List<Order>();

            // DÒNG NÀY LÀ CỰC KỲ QUAN TRỌNG: KHỞI TẠO userInfoTimer
            this.userInfoTimer = new System.Windows.Forms.Timer();

            // Cấu hình Timer
            this.userInfoTimer.Interval = 1000; // Lỗi NullReferenceException xảy ra ở đây nếu chưa khởi tạo
            this.userInfoTimer.Tick += new System.EventHandler(this.userInfoTimer_Tick);

            // Các sự kiện khác giữ nguyên
            this.dataGridViewTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactions_CellContentClick);
            this.btnCloseDetail.Click += new System.EventHandler(this.btnCloseDetail_Click);
        }


        private async void Form_UserInfo_Load(object sender, EventArgs e)
        {
            panelDetailView.Visible = false;
            if (currentUser == null) return;

            // Load thông tin cá nhân
            lblFullName.Text = currentUser.FullName;
            lblUsername.Text = "@" + currentUser.Username;
            lblEmail.Text = currentUser.Email;
            lblPhoneNumber.Text = currentUser.PhoneNumber;
            lblJoinedDate.Text = "Tham gia ngày " + currentUser.CreationTimestamp.ToLocalTime().ToString("dd/MM/yyyy");

            // Lấy thông tin PC hiện tại từ Firebase
            await UpdateSessionInfo(); // Gọi phương thức mới để tải và cập nhật UI

            // Đảm bảo listener được hủy khi form đóng
            this.FormClosing += (s, ev) => { pcListener?.Dispose(); };

            await LoadRealOrders();
        }

        // Phương thức mới để tải và cập nhật thông tin phiên
        private async Task UpdateSessionInfo()
        {
            // Lấy thông tin PC mới nhất từ Firebase
            activePC = await firebaseDB.GetActivePCForUser(currentUser.Username);

            // Hiển thị tổng thời gian đã chơi từ các phiên trước (lấy từ User object)
            lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed);

            if (activePC != null && activePC.Status == PCStatus.InUse)
            {
                // Cập nhật Budget và hiển thị
                lblCurrentBudget.Text = $"{activePC.Budget:N0} đ";

                // Bắt đầu lắng nghe sự thay đổi của PC này trên Firebase
                // Hủy listener cũ trước khi tạo mới để tránh trùng lặp
                pcListener?.Dispose();
                pcListener = await firebaseDB.ListenToPCChanges(activePC.Name, Pc_ValueChanged);

                userInfoTimer.Start(); // Bắt đầu timer để cập nhật UI mỗi giây
                // Lần đầu tải, cập nhật ngay lập tức
                UpdateUITimeDisplays();
            }
            else
            {
                // Nếu không có PC đang hoạt động hoặc không InUse
                lblCurrentBudget.Text = "Không trong phiên";
                lblTimeRemaining.Text = "00:00:00";
                lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed); // Đảm bảo hiển thị đúng tổng thời gian đã chơi
                userInfoTimer.Stop(); // Dừng timer khi không có phiên
                pcListener?.Dispose(); // Hủy listener nếu không có phiên
            }
        }


        // Phương thức xử lý mỗi khi timer tick (mỗi giây)
        private void userInfoTimer_Tick(object sender, EventArgs e)
        {
            if (activePC != null && activePC.Status == PCStatus.InUse)
            {
                // Tính toán lại thời gian còn lại và thời gian đã sử dụng mỗi giây
                UpdateUITimeDisplays();
            }
            else // Nếu PC không còn InUse hoặc activePC là null
            {
                // Dừng timer và reset hiển thị nếu phiên không còn hoạt động
                lblTimeRemaining.Text = "00:00:00";
                lblCurrentBudget.Text = "Không trong phiên";
                userInfoTimer.Stop();
            }
        }

        // Phương thức để tính toán và cập nhật hiển thị thời gian
        private void UpdateUITimeDisplays()
        {
            if (activePC == null || !activePC.StartTime.HasValue || activePC.Status != PCStatus.InUse)
            {
                // Không có phiên hoạt động, reset hiển thị
                lblTimeRemaining.Text = "00:00:00";
                lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed); // Chỉ hiển thị tổng thời gian từ các phiên trước
                return;
            }

            // Tính toán tổng thời gian mua được từ Budget
            TimeSpan totalPurchasedTime = PC.CalculateTotalTimeFromBudget(activePC.Budget);

            // Tính toán thời gian đã trôi qua kể từ StartTime
            TimeSpan timeElapsed = DateTime.Now - activePC.StartTime.Value;

            // Tính toán thời gian còn lại
            TimeSpan calculatedTimeRemaining = totalPurchasedTime.Subtract(timeElapsed);

            // Đảm bảo thời gian còn lại không âm
            if (calculatedTimeRemaining < TimeSpan.Zero)
            {
                calculatedTimeRemaining = TimeSpan.Zero;
            }

            // Cập nhật hiển thị thời gian còn lại
            lblTimeRemaining.Text = calculatedTimeRemaining.ToString(@"hh\:mm\:ss");

            // Tính toán thời gian đã sử dụng trong phiên hiện tại
            TimeSpan currentSessionTimeUsed = timeElapsed;
            // Cập nhật hiển thị tổng thời gian đã chơi (tổng thời gian cũ + thời gian phiên hiện tại)
            lblTotalTimePlayed.Text = FormatTotalTime(currentSessionTimeUsed);

            // Nếu thời gian còn lại hết, có thể dừng timer và thông báo
            if (calculatedTimeRemaining.TotalSeconds <= 0)
            {
                userInfoTimer.Stop();
                lblTimeRemaining.Text = "00:00:00";
                // Có thể thêm logic thông báo hết giờ ở đây
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

                    
                    this.Invoke((MethodInvoker)delegate {
                        lblCurrentBudget.Text = $"{activePC.Budget:N0} đ"; 
                        UpdateUITimeDisplays(); 
                        lblTotalTimePlayed.Text = FormatTotalTime(currentUser.TotalTimePlayed); 

                        
                        if (activePC.Status != PCStatus.InUse)
                        {
                            userInfoTimer.Stop();
                            lblTimeRemaining.Text = "00:00:00";
                            lblCurrentBudget.Text = "Không trong phiên";
                            pcListener?.Dispose(); // Hủy listener khi phiên kết thúc
                        }
                        else
                        {
                            userInfoTimer.Start(); // Đảm bảo timer chạy nếu PC vẫn InUse
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật PC từ listener: " + ex.Message);
            }
        }

        
        private string FormatTotalTime(TimeSpan timeSpan)
        {
            
            if (timeSpan.TotalSeconds == 0)
            {
                return "0 giây";
            }

            StringBuilder formattedTime = new StringBuilder();

            
            if (timeSpan.TotalDays >= 1)
            {
                formattedTime.Append($"{(int)timeSpan.TotalDays} ngày ");
            }

            
            if (timeSpan.TotalHours >= 1 || (formattedTime.Length > 0 && timeSpan.Hours > 0))
            {
                
                if (timeSpan.TotalDays >= 1 || timeSpan.Hours >= 1)
                {
                    formattedTime.Append($"{timeSpan.Hours} giờ ");
                }
            }

            
            if (timeSpan.TotalMinutes >= 1 || formattedTime.Length > 0)
            {
                
                if (timeSpan.TotalDays >= 1 || timeSpan.TotalHours >= 1 || timeSpan.Minutes >= 1)
                {
                    formattedTime.Append($"{timeSpan.Minutes} phút ");
                }
            }

            
            if (timeSpan.Seconds >= 1 || formattedTime.Length == 0) 
            {
                formattedTime.Append($"{timeSpan.Seconds} giây");
            }

            
            return formattedTime.ToString().Trim();
        }

        
        private async Task LoadRealOrders()
        {
            var realOrders = await firebaseDB.GetOrdersForUser(currentUser.Username);
            transactionList = realOrders
                .Where(o => o.Timestamp >= DateTime.UtcNow.AddDays(-30)) // Lấy lịch sử 30 ngày
                .OrderByDescending(t => t.Timestamp)
                .ToList();
            
            dataGridViewTransactions.Rows.Clear();
            if (transactionList.Any())
            {
                foreach (var trans in transactionList)
                {
                    string transactionTypeDisplay = "Giao dịch khác";
                    if (trans.Items != null && trans.Items.Any()) transactionTypeDisplay = "Gọi món";
                    else if (trans.Type == TransactionType.PcUsage) transactionTypeDisplay = "Sử dụng máy";

                    dataGridViewTransactions.Rows.Add(
                        trans.Timestamp.ToLocalTime().ToString("g"),
                        transactionTypeDisplay,
                        $"{trans.GrandTotal:N0}",
                        null,
                        trans.Status
                    );
                }
            }
        }

        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewTransactions.Columns["colDetails"].Index)
            {
                Order selectedOrder = this.transactionList[e.RowIndex];
                ShowDetailPanel(selectedOrder);
            }
        }

        private void ShowDetailPanel(Order order)
        {
            panelDetailView.Visible = true;
            lblDetailTitle.Text = "Chi tiết giao dịch";

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