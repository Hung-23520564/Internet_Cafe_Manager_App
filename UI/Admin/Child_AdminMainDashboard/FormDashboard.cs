using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.Timer;
using Internet_Cafe_Manager_App.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations;
using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class FormDashboard : Form
    {
        private BindingList<PC> pcList;

        public FormDashboard()
        {
            InitializeComponent();
            this.Activated += FormDashboard_Activated;

            pcList = new BindingList<PC>();

            dataGridViewPCs.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();
            dataGridViewPCs.DataSource = this.pcList;

            LoadPCsFromFirebase();
            comboBoxEditStatus.DataSource = Enum.GetValues(typeof(PCStatus));

            this.dataGridViewPCs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPCs_CellContentClick);
            this.dataGridViewPCs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewPCs_CellFormatting);
        }

        private void InitializeDataGridViewColumns()
        {
            var isTopUpColumn = new DataGridViewCheckBoxColumn
            {
                Name = "colIsTopUpRequestSent",
                DataPropertyName = "IsTopUpRequestSent",
                HeaderText = "Tick",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
                ReadOnly = true
            };
            dataGridViewPCs.Columns.Add(isTopUpColumn);

            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", DataPropertyName = "Name", HeaderText = "PC", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 60, });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDetailInfo", DataPropertyName = "DetailInfo", HeaderText = "Detail", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 150 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", DataPropertyName = "Status", HeaderText = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 80 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCurrentUser", DataPropertyName = "CurrentUser", HeaderText = "User", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 200 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStartTime", DataPropertyName = "StartTime", HeaderText = "StartTime", DefaultCellStyle = new DataGridViewCellStyle { Format = "HH:mm:ss" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 180 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTimeRemaining", DataPropertyName = "TimeRemaining", HeaderText = "Remaining", DefaultCellStyle = new DataGridViewCellStyle { Format = @"hh\:mm\:ss" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 180 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBudget", DataPropertyName = "Budget", HeaderText = "Budget", DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, FillWeight = 80 });
            dataGridViewPCs.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTimeUsed", DataPropertyName = "TimeUsed", HeaderText = "TimeUsed", DefaultCellStyle = new DataGridViewCellStyle { Format = @"hh\:mm\:ss" }, AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 180 });


            // Giờ sẽ tới phần canh chỉnh lề nè mấy ae, tui tách riêng ra đọc cho dễ nha 2 ông thần
            // Canh giữa nội dung của cột "Status"
            dataGridViewPCs.Columns["colStatus"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Canh giữa tiêu đề của cột
            dataGridViewPCs.Columns["colStatus"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colDetailInfo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colDetailInfo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colCurrentUser"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colCurrentUser"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colStartTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colStartTime"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colTimeRemaining"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colTimeRemaining"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colBudget"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colBudget"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colTimeUsed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPCs.Columns["colTimeUsed"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;


            var removeColumn = new DataGridViewImageColumn
            {
                Name = "colRemove",
                HeaderText = "Delete",
                ImageLayout = DataGridViewImageCellLayout.Normal,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 60,
                ToolTipText = "Click to remove PC"
            };

            try
            {
                IconChar icon = IconChar.TrashAlt;
                int iconSize = 18;
                Color iconColor = Color.FromArgb(220, 53, 69);
                Bitmap iconBitmap = new Bitmap(iconSize, iconSize);
                using (Graphics g = Graphics.FromImage(iconBitmap))
                {
                    using (Font font = new Font("Font Awesome 6 Free Solid", iconSize, GraphicsUnit.Pixel))
                    {
                        string iconString = char.ConvertFromUtf32((int)icon);
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        using (Brush brush = new SolidBrush(iconColor))
                        {
                            g.DrawString(iconString, font, brush, new PointF(-2, 0));
                        }
                    }
                }
                removeColumn.Image = iconBitmap;
            }
            catch (Exception) { /* Font not found */ }
            dataGridViewPCs.Columns.Add(removeColumn);
        }

        private async void dataGridViewPCs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewPCs.Columns["colRemove"].Index)
            {
                PC pcToRemove = this.pcList[e.RowIndex];

                DialogResult result = MessageBox.Show($"Bạn có chắc sẽ xóa {pcToRemove.Name} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        FirebaseDB firebaseDB = new FirebaseDB();
                        bool success = await firebaseDB.DeletePC(pcToRemove.Name);

                        if (success)
                        {
                            this.Invoke((MethodInvoker)delegate { pcList.Remove(pcToRemove); });
                            MessageBox.Show($"{pcToRemove.Name} đã được xóa.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Xóa {pcToRemove.Name} trên cơ sở dữ liệu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi xóa {pcToRemove.Name}: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewPCs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Lấy danh sách các cột cần làm trống
            var columnsToClear = new List<string> { "colTimeRemaining", "colBudget", "colTimeUsed" };

            if (columnsToClear.Contains(dataGridViewPCs.Columns[e.ColumnIndex].Name))
            {
                if (e.RowIndex >= 0)
                {
                    PC pc = this.pcList[e.RowIndex];

                    // --- THAY ĐỔI LOGIC TẠI ĐÂY ---
                    // Nếu máy không có người dùng (trống) thì ẩn các thông tin này đi
                    if (string.IsNullOrEmpty(pc.CurrentUser))
                    {
                        e.Value = ""; // Hiển thị ô trống
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            var notificationThreshold = TimeSpan.FromMinutes(60);
            List<PC> pcsToSave = new List<PC>();

            foreach (var pc in pcList)
            {
                // TRƯỜNG HỢP 1: MÁY ĐANG SỬ DỤNG
                if (pc.Status == PCStatus.InUse && pc.StartTime.HasValue)
                {
                    pc.NotifyTimeUsedChanged();

                    // Đếm ngược thời gian
                    if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value > TimeSpan.Zero)
                    {
                        pc.DecrementTimeRemaining(TimeSpan.FromMilliseconds(timer1.Interval));
                    }

                    // Kiểm tra nếu máy vừa hết giờ trong Tick này
                    if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value.TotalSeconds <= 0)
                    {
                        pc.Status = PCStatus.TimeEnded;
                        pc.TimeEndedTimestamp = DateTime.Now; // Đặt mốc thời gian hết giờ
                        pcsToSave.Add(pc); // Lưu trạng thái mới này lên Firebase
                    }
                    // Gửi yêu cầu nạp tiền nếu cần
                    else if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value < notificationThreshold && !pc.IsTopUpRequestSent)
                    {
                        pc.IsTopUpRequestSent = true;
                        CreateAutoDepositRequest(pc);
                    }
                }
                // TRƯỜNG HỢP 2: MÁY ĐÃ HẾT GIỜ VÀ ĐANG CHỜ RESET
                else if (pc.Status == PCStatus.TimeEnded && pc.TimeEndedTimestamp.HasValue)
                {
                    // Kiểm tra xem đã qua 20 giây chưa
                    if ((DateTime.Now - pc.TimeEndedTimestamp.Value).TotalSeconds >= 20)
                    {
                        // Reset thông tin máy
                        pc.Status = PCStatus.Available;
                        pc.CurrentUser = null;
                        pc.StartTime = null;
                        pc.TimeRemaining = TimeSpan.Zero;
                        pc.Budget = 0;
                        pc.IsTopUpRequestSent = false;
                        pc.TimeEndedTimestamp = null; // Xóa mốc thời gian

                        pcsToSave.Add(pc); // Đánh dấu máy này cần được lưu
                    }
                }
                else if (pc.Status != PCStatus.InUse && pc.IsTopUpRequestSent)
                {
                    pc.IsTopUpRequestSent = false;
                }
            }

            // Lưu tất cả các máy có thay đổi lên Firebase
            if (pcsToSave.Any())
            {
                FirebaseDB firebaseDB = new FirebaseDB();
                foreach (PC pcToSave in pcsToSave)
                {
                    await firebaseDB.AddOrUpdatePC(pcToSave);
                }
            }
        }

        // --- CÁC HÀM CÒN LẠI GIỮ NGUYÊN ---
        private async void buttonAddPC_Click(object sender, EventArgs e)
        {
            string sequenceNumberText = textBoxSequenceNumber.Text.Trim();
            if (string.IsNullOrEmpty(sequenceNumberText))
            {
                MessageBox.Show("Vui lòng nhập số thứ tự máy.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(sequenceNumberText, out int sequenceNumber) || sequenceNumber <= 0)
            {
                MessageBox.Show("Số thứ tự máy không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pcName = $"PC{sequenceNumber}";
            if (pcList.Any(pc => pc.Name.Equals(pcName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Máy '{pcName}' đã tồn tại.", "Trùng tên máy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PC newPC = new PC(pcName) { Status = PCStatus.Available, DetailInfo = "Máy mới" };
            pcList.Add(newPC);
            FirebaseDB firebaseDB = new FirebaseDB();
            await firebaseDB.AddOrUpdatePC(newPC);
            textBoxSequenceNumber.Clear();
        }

        private void buttonClearAddPC_Click(object sender, EventArgs e)
        {
            textBoxSequenceNumber.Clear();
            textBoxSequenceNumber.Focus();
        }

        private void textBoxEditPCName_Leave(object sender, EventArgs e)
        {
            string sequenceNumberText = textBoxEditPCName.Text.Trim();
            ClearEditFields();
            if (string.IsNullOrEmpty(sequenceNumberText)) return;
            if (!int.TryParse(sequenceNumberText, out int sequenceNumber) || sequenceNumber <= 0)
            {
                MessageBox.Show("Số thứ tự máy không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pcNameToFind = $"PC{sequenceNumber}";
            PC foundPC = pcList.FirstOrDefault(pc => pc.Name.Equals(pcNameToFind, StringComparison.OrdinalIgnoreCase));
            if (foundPC != null)
            {
                textBoxEditDetailInfo.Text = foundPC.DetailInfo;
                textBoxEditCurrentUser.Text = foundPC.CurrentUser;
                comboBoxEditStatus.SelectedItem = foundPC.Status;
                textBoxEditSoTien.Text = foundPC.Budget.ToString();
            }
            else
            {
                MessageBox.Show($"Không tìm thấy máy '{pcNameToFind}'.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearEditFields()
        {
            textBoxEditDetailInfo.Clear();
            textBoxEditCurrentUser.Clear();
            if (comboBoxEditStatus.Items.Count > 0) comboBoxEditStatus.SelectedIndex = 0;
            textBoxEditSoTien.Clear();
        }

        private async void buttonEditSave_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin máy cần cập nhật
            string numberFromTextBox = textBoxEditPCName.Text.Trim();
            if (string.IsNullOrEmpty(numberFromTextBox))
            {
                MessageBox.Show("Vui lòng nhập số thứ tự máy cần cập nhật.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pcNameToSave = $"PC{numberFromTextBox}";
            PC pcToUpdate = pcList.FirstOrDefault(pc => pc.Name.Equals(pcNameToSave, StringComparison.OrdinalIgnoreCase));

            if (pcToUpdate != null)
            {
                string newCurrentUser = textBoxEditCurrentUser.Text.Trim();
                string newDetailInfo = textBoxEditDetailInfo.Text.Trim();

                // Lấy số tiền NHẬP VÀO trong TextBox để xác định số tiền NẠP THÊM
                if (string.IsNullOrEmpty(textBoxEditSoTien.Text.Trim()) || textBoxEditSoTien.Text.Trim() == "0")
                {
                    MessageBox.Show("Vui lòng nhập số tiền.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxEditSoTien.Text.Trim(), out int inputBudgetAmount)) // Số tiền mà Admin nhập vào
                {
                    MessageBox.Show("Số tiền không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FirebaseDB firebaseDB = new FirebaseDB();

                // Lấy thông tin PC HIỆN TẠI trên Firebase để so sánh (trước khi thay đổi)
                PC originalPCState = await firebaseDB.GetPC(pcToUpdate.Name);
                if (originalPCState == null)
                {
                    MessageBox.Show($"Lỗi: Không thể lấy trạng thái gốc của máy '{pcToUpdate.Name}'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy người dùng liên quan (nếu có)
                Database.Users userToUpdate = null;
                if (!string.IsNullOrEmpty(newCurrentUser))
                {
                    userToUpdate = await firebaseDB.GetUser(newCurrentUser);
                    if (userToUpdate == null)
                    {
                        MessageBox.Show("User này không tồn tại, mời nhập lại.", "Lỗi Không Tìm Thấy Người Dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var otherPcInUse = pcList.FirstOrDefault(p => p.Name != pcToUpdate.Name && p.Status == PCStatus.InUse && p.CurrentUser == newCurrentUser);
                    if (otherPcInUse != null)
                    {
                        MessageBox.Show("User này đang chơi ở máy khác, vui lòng nhập lại.", "Lỗi Trùng Người Dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                PCStatus newStatus = (PCStatus)comboBoxEditStatus.SelectedItem;
                decimal amountAdded = 0; // Số tiền thực sự được NẠP VÀO trong giao dịch này

                // Logic cộng dồn budget và thời gian đã được sửa ở phản hồi trước
                // Kiểm tra nếu là phiên mới (chưa có StartTime hoặc User thay đổi)
                bool isNewSession = !originalPCState.StartTime.HasValue || originalPCState.CurrentUser != newCurrentUser;

                if (newStatus == PCStatus.InUse && !string.IsNullOrEmpty(newCurrentUser))
                {
                    if (isNewSession)
                    {
                        // Phiên mới, budget ban đầu là số tiền nhập vào
                        pcToUpdate.Budget = inputBudgetAmount;
                        pcToUpdate.StartTime = DateTime.Now;
                        pcToUpdate.TimeRemaining = PC.CalculateTotalTimeFromBudget(inputBudgetAmount);
                        amountAdded = inputBudgetAmount; // Toàn bộ số tiền nhập vào là tiền nạp cho phiên mới
                    }
                    else // Nạp thêm tiền cho phiên đang chạy (CurrentUser không đổi)
                    {
                        // Số tiền NẠP THÊM là inputBudgetAmount
                        amountAdded = inputBudgetAmount;
                        pcToUpdate.Budget = originalPCState.Budget + inputBudgetAmount; // Cộng dồn Budget

                        TimeSpan timeAdded = PC.CalculateTotalTimeFromBudget(inputBudgetAmount);
                        pcToUpdate.TimeRemaining = (originalPCState.TimeRemaining ?? TimeSpan.Zero) + timeAdded; // Cộng dồn thời gian
                    }
                    pcToUpdate.CurrentUser = newCurrentUser;
                }
                else // Chuyển sang trạng thái không InUse (Available, Offline, Error, TimeEnded)
                {
                    // Nếu chuyển trạng thái ra khỏi InUse, reset các thông tin liên quan
                    pcToUpdate.CurrentUser = null;
                    pcToUpdate.StartTime = null;
                    pcToUpdate.TimeRemaining = TimeSpan.Zero;
                    pcToUpdate.Budget = 0;
                    pcToUpdate.IsTopUpRequestSent = false;
                }

                // Cập nhật các thông tin chung khác
                pcToUpdate.DetailInfo = newDetailInfo;
                pcToUpdate.Status = newStatus;

                // Xử lý các giao dịch nếu có tiền được nạp vào
                if (amountAdded > 0 && userToUpdate != null)
                {
                    // TẠO MỘT GIAO DỊCH ORDER MỚI CHO LẦN NẠP TIỀN THỦ CÔNG NÀY
                    var manualTopUpOrder = new Order
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        UserID = userToUpdate.UserId,
                        Username = userToUpdate.Username,
                        UserFullName = userToUpdate.FullName,
                        GrandTotal = amountAdded, // Số tiền thực sự được nạp
                        Timestamp = DateTime.UtcNow,
                        Status = "Completed", // Đặt trạng thái là Completed ngay lập tức
                        Type = TransactionType.PcUsage,
                        Description = $"Admin nạp thủ công {amountAdded:N0} đ cho máy {pcToUpdate.Name}",
                        TimePurchased = PC.CalculateTotalTimeFromBudget((int)amountAdded), // Thời gian mua được từ số tiền nạp thêm
                        Items = new List<CartItemEntry>() // Không có item cho giao dịch nạp tiền
                    };
                    await firebaseDB.AddOrder(manualTopUpOrder);

                    // CẬP NHẬT THÔNG TIN TỔNG TIỀN VÀ TỔNG THỜI GIAN ĐÃ CHƠI CỦA NGƯỜI DÙNG
                    userToUpdate.TotalMoneyDeposited += amountAdded;
                    userToUpdate.TotalTimePlayed += manualTopUpOrder.TimePurchased ?? TimeSpan.Zero;
                    await firebaseDB.AddOrUpdateUser(userToUpdate); // Lưu lại thông tin User đã cập nhật
                }

                // Lưu thông tin PC đã cập nhật vào Firebase
                bool saveSuccess = await firebaseDB.AddOrUpdatePC(pcToUpdate);

                if (saveSuccess)
                {
                    MessageBox.Show($"Đã cập nhật và lưu thông tin cho máy '{pcToUpdate.Name}'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Cập nhật thông tin máy '{pcToUpdate.Name}' thất bại!", "Lỗi Lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy máy '{pcNameToSave}' để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditClear_Click(object sender, EventArgs e)
        {
            textBoxEditPCName.Clear();
            ClearEditFields();
            textBoxEditPCName.Focus();
        }

        private void FormDashboard_Activated(object sender, EventArgs e)
        {
            if (pcList == null) return;
            foreach (var pc in pcList.Where(p => p.Status == PCStatus.InUse && p.StartTime.HasValue))
            {
                pc.NotifyTimeUsedChanged();
            }
        }

        private async void LoadPCsFromFirebase()
        {
            FirebaseDB firebaseDB = new FirebaseDB();
            pcList.Clear();
            try
            {
                List<PC> loadedPCs = await firebaseDB.GetAllPCs();
                if (loadedPCs != null)
                {
                    foreach (PC pc in loadedPCs)
                    {
                        if (pc.Status == PCStatus.InUse && pc.StartTime.HasValue)
                        {
                            TimeSpan timeElapsed = DateTime.Now - pc.StartTime.Value;
                            pc.TimeRemaining = (PC.CalculateTotalTimeFromBudget(pc.Budget) > timeElapsed) ? PC.CalculateTotalTimeFromBudget(pc.Budget) - timeElapsed : TimeSpan.Zero;
                            if (pc.TimeRemaining.Value.TotalSeconds <= 0)
                            {
                                pc.Status = PCStatus.TimeEnded;
                                pc.TimeEndedTimestamp = DateTime.Now;
                            }
                        }
                        pcList.Add(pc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu PC từ Firebase: {ex.Message}", "Lỗi Tải Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CreateAutoDepositRequest(PC pc)
        {
            if (string.IsNullOrEmpty(pc.CurrentUser)) return;
            Database.Users user = await new FirebaseDB().GetUser(pc.CurrentUser);
            if (user == null) return;

            var depositOrder = new Order
            {
                OrderId = Guid.NewGuid().ToString(),
                UserID = user.UserId,
                Username = user.Username,
                UserFullName = user.FullName,
                GrandTotal = 10000,
                Timestamp = DateTime.UtcNow,
                Status = "Completed",
                Type = TransactionType.PcUsage,
                Description = $"Yêu cầu nạp tiền tự động cho máy {pc.Name}",
                TimePurchased = PC.CalculateTotalTimeFromBudget(10000),
                Items = new List<CartItemEntry>()
            };
            await new FirebaseDB().AddOrder(depositOrder);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}