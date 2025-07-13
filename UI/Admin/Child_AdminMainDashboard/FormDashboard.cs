using Internet_Cafe_Manager_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class FormDashboard : Form
    {
        private BindingList<PC> pcList;
        private List<Users> allUsers;
        private FirebaseDB firebaseDB;

        private int currentPricePerUnit;
        private int currentTimePerUnitMinutes;

        public FormDashboard()
        {
            InitializeComponent();
            this.firebaseDB = new FirebaseDB();
            this.pcList = new BindingList<PC>();
            this.allUsers = new List<Users>();

            this.Activated += FormDashboard_Activated;
            dataGridViewPCs.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();
            dataGridViewPCs.DataSource = this.pcList;

            this.Load += FormDashboard_Load;
            this.dataGridViewPCs.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewPCs_CellContentClick);
            this.dataGridViewPCs.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewPCs_CellFormatting);
            this.txtEditPhoneNumber.TextChanged += new EventHandler(this.txtEditPhoneNumber_TextChanged);
            this.textBoxEditCurrentUser.TextChanged += new EventHandler(this.textBoxEditCurrentUser_TextChanged);
        }

        private async void FormDashboard_Load(object sender, EventArgs e)
        {
            await LoadPriceSettings();
            await LoadAllUsers();
            await LoadPCsFromFirebase();
            comboBoxEditStatus.DataSource = Enum.GetValues(typeof(PCStatus));
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
                    await SavePriceSettings();
                }
                UpdatePriceDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load price settings: " + ex.Message);
                currentPricePerUnit = 10000;
                currentTimePerUnitMinutes = 30;
                UpdatePriceDisplay();
            }
        }

        private void UpdatePriceDisplay()
        {
            lblCurrentPrice.Text = $"Current: {currentPricePerUnit:N0} VND / {currentTimePerUnitMinutes} minutes";
            txtNewPrice.Text = currentPricePerUnit.ToString();
            txtNewTimeMinutes.Text = currentTimePerUnitMinutes.ToString();
        }

        private async Task SavePriceSettings()
        {
            var settings = new Dictionary<string, int>
            {
                { "Price", currentPricePerUnit },
                { "Minutes", currentTimePerUnitMinutes }
            };
            await firebaseDB.client.SetAsync("Configuration/PriceSettings", settings);
        }

        private async void btnSavePriceSettings_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNewPrice.Text, out int newPrice) || newPrice <= 0)
            {
                MessageBox.Show("Invalid price amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtNewTimeMinutes.Text, out int newMinutes) || newMinutes <= 0)
            {
                MessageBox.Show("Invalid time unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentPricePerUnit = newPrice;
            currentTimePerUnitMinutes = newMinutes;

            await SavePriceSettings();
            UpdatePriceDisplay();
            MessageBox.Show("Price settings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // *** LOGIC THÊM PC ĐÃ ĐƯỢC SỬA LỖI ***
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

            // Bước 1: Lưu vào Firebase trước
            bool success = await firebaseDB.AddOrUpdatePC(newPC);

            // Bước 2: Nếu lưu thành công, mới thêm vào danh sách trên giao diện
            if (success)
            {
                pcList.Add(newPC);
                textBoxSequenceNumber.Clear();
                MessageBox.Show($"Đã thêm thành công máy '{pcName}'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Thêm máy '{pcName}' thất bại. Vui lòng kiểm tra kết nối hoặc quyền truy cập Firebase.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonEditSave_Click(object sender, EventArgs e)
        {
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
                if (textBoxEditSoTien.Text.Trim() == "00000")
                {
                    // Tìm và đóng Form_LockScreen nếu nó đang mở
                    Form_LockScreen lockScreen = Application.OpenForms.OfType<Form_LockScreen>().FirstOrDefault();
                    if (lockScreen != null)
                    {
                        lockScreen.UnlockScreen(); // Sử dụng phương thức UnlockScreen để đóng form
                        MessageBox.Show($"Đã mở khóa màn hình cho người dùng của máy {pcToUpdate.Name}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy màn hình khóa để mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return; // Dừng xử lý sau khi mở khóa
                }
                string newCurrentUser = textBoxEditCurrentUser.Text.Trim();
                string newDetailInfo = textBoxEditDetailInfo.Text.Trim();

                if (!string.IsNullOrEmpty(newCurrentUser) && !allUsers.Any(u => u.Username.Equals(newCurrentUser, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Người dùng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBoxEditSoTien.Text.Trim(), out int inputBudgetAmount))
                {
                    MessageBox.Show("Số tiền không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PC originalPCState = await firebaseDB.GetPC(pcToUpdate.Name);
                if (originalPCState == null) { originalPCState = new PC(pcToUpdate.Name); /* Tạo mới nếu chưa có trên DB */ }

                Database.Users userToUpdate = null;
                if (!string.IsNullOrEmpty(newCurrentUser))
                {
                    userToUpdate = await firebaseDB.GetUser(newCurrentUser);
                    if (userToUpdate == null) { MessageBox.Show("User không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                    if (pcList.Any(p => p.Name != pcToUpdate.Name && p.Status == PCStatus.InUse && p.CurrentUser == newCurrentUser))
                    {
                        MessageBox.Show("User này đang chơi ở máy khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                PCStatus newStatus = (PCStatus)comboBoxEditStatus.SelectedItem;
                decimal amountAdded = 0;
                bool isNewSession = string.IsNullOrEmpty(originalPCState.CurrentUser) || originalPCState.CurrentUser != newCurrentUser;

                if (newStatus == PCStatus.InUse && !string.IsNullOrEmpty(newCurrentUser))
                {
                    amountAdded = inputBudgetAmount;
                    TimeSpan timeAdded = PC.CalculateTotalTimeFromBudget(inputBudgetAmount, currentPricePerUnit, currentTimePerUnitMinutes);

                    if (isNewSession)
                    {
                        pcToUpdate.Budget = inputBudgetAmount;
                        pcToUpdate.StartTime = DateTime.Now;
                        pcToUpdate.TimeRemaining = timeAdded;
                    }
                    else
                    {
                        pcToUpdate.Budget = originalPCState.Budget + inputBudgetAmount;
                        pcToUpdate.TimeRemaining = (originalPCState.TimeRemaining ?? TimeSpan.Zero) + timeAdded;
                    }
                    pcToUpdate.CurrentUser = newCurrentUser;
                }
                else
                {
                    pcToUpdate.CurrentUser = null;
                    pcToUpdate.StartTime = null;
                    pcToUpdate.TimeRemaining = TimeSpan.Zero;
                    pcToUpdate.Budget = 0;
                    pcToUpdate.IsTopUpRequestSent = false;
                }

                pcToUpdate.DetailInfo = newDetailInfo;
                pcToUpdate.Status = newStatus;

                if (amountAdded > 0 && userToUpdate != null)
                {
                    var manualTopUpOrder = new Order
                    {
                        OrderId = Guid.NewGuid().ToString(),
                        UserID = userToUpdate.UserId,
                        Username = userToUpdate.Username,
                        UserFullName = userToUpdate.FullName,
                        GrandTotal = amountAdded,
                        Timestamp = DateTime.UtcNow,
                        Status = "Completed",
                        Type = TransactionType.PcUsage,
                        Description = $"Admin nạp {amountAdded:N0}đ cho máy {pcToUpdate.Name}",
                        TimePurchased = PC.CalculateTotalTimeFromBudget((int)amountAdded, currentPricePerUnit, currentTimePerUnitMinutes)
                    };
                    await firebaseDB.AddOrder(manualTopUpOrder);
                    userToUpdate.TotalMoneyDeposited += amountAdded;
                    userToUpdate.TotalTimePlayed += manualTopUpOrder.TimePurchased ?? TimeSpan.Zero;
                    await firebaseDB.AddOrUpdateUser(userToUpdate);
                }

                if (await firebaseDB.AddOrUpdatePC(pcToUpdate))
                {
                    MessageBox.Show($"Đã cập nhật thông tin cho máy '{pcToUpdate.Name}'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Cập nhật thông tin máy '{pcToUpdate.Name}' thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy máy '{pcNameToSave}' để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadPCsFromFirebase()
        {
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
                            TimeSpan totalTime = PC.CalculateTotalTimeFromBudget(pc.Budget, currentPricePerUnit, currentTimePerUnitMinutes);
                            pc.TimeRemaining = (totalTime > timeElapsed) ? totalTime - timeElapsed : TimeSpan.Zero;
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
            Database.Users user = await firebaseDB.GetUser(pc.CurrentUser);
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
                TimePurchased = PC.CalculateTotalTimeFromBudget(10000, currentPricePerUnit, currentTimePerUnitMinutes)
            };
            await firebaseDB.AddOrder(depositOrder);
        }

        #region Other UI Methods (No changes needed)
        private async Task LoadAllUsers()
        {
            this.allUsers = await firebaseDB.GetAllUsers();
            var usernameSource = new AutoCompleteStringCollection();
            usernameSource.AddRange(allUsers.Select(u => u.Username).ToArray());
            textBoxEditCurrentUser.AutoCompleteCustomSource = usernameSource;
            textBoxEditCurrentUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxEditCurrentUser.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var phoneSource = new AutoCompleteStringCollection();
            phoneSource.AddRange(allUsers.Select(u => u.PhoneNumber).ToArray());
            txtEditPhoneNumber.AutoCompleteCustomSource = phoneSource;
            txtEditPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtEditPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void txtEditPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtEditPhoneNumber.Focused)
            {
                var user = allUsers.FirstOrDefault(u => u.PhoneNumber == txtEditPhoneNumber.Text);
                if (user != null)
                {
                    textBoxEditCurrentUser.TextChanged -= textBoxEditCurrentUser_TextChanged;
                    textBoxEditCurrentUser.Text = user.Username;
                    textBoxEditCurrentUser.TextChanged += textBoxEditCurrentUser_TextChanged;
                }
            }
        }
        private void textBoxEditCurrentUser_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEditCurrentUser.Focused)
            {
                var user = allUsers.FirstOrDefault(u => u.Username == textBoxEditCurrentUser.Text);
                if (user != null)
                {
                    txtEditPhoneNumber.TextChanged -= txtEditPhoneNumber_TextChanged;
                    txtEditPhoneNumber.Text = user.PhoneNumber;
                    txtEditPhoneNumber.TextChanged += txtEditPhoneNumber_TextChanged;
                }
            }
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
                if (MessageBox.Show($"Bạn có chắc sẽ xóa {pcToRemove.Name} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (await firebaseDB.DeletePC(pcToRemove.Name)) { this.Invoke((MethodInvoker)delegate { pcList.Remove(pcToRemove); }); } else { MessageBox.Show($"Xóa {pcToRemove.Name} thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        private void dataGridViewPCs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && new List<string> { "colTimeRemaining", "colBudget", "colTimeUsed" }.Contains(dataGridViewPCs.Columns[e.ColumnIndex].Name))
            {
                if (string.IsNullOrEmpty(this.pcList[e.RowIndex].CurrentUser)) { e.Value = ""; e.FormattingApplied = true; }
            }
        }
        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            var notificationThreshold = TimeSpan.FromMinutes(5); List<PC> pcsToSave = new List<PC>();
            foreach (var pc in pcList.Where(p => p.Status == PCStatus.InUse && p.StartTime.HasValue))
            {
                pc.NotifyTimeUsedChanged();
                if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value > TimeSpan.Zero) { pc.DecrementTimeRemaining(TimeSpan.FromMilliseconds(timer1.Interval)); }
                if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value.TotalSeconds <= 0) { pc.Status = PCStatus.TimeEnded; pc.TimeEndedTimestamp = DateTime.Now; pcsToSave.Add(pc); }
                else if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value < notificationThreshold && !pc.IsTopUpRequestSent) { pc.IsTopUpRequestSent = true; CreateAutoDepositRequest(pc); }
            }
            foreach (var pc in pcList.Where(p => p.Status == PCStatus.TimeEnded && p.TimeEndedTimestamp.HasValue && (DateTime.Now - p.TimeEndedTimestamp.Value).TotalSeconds >= 600))
            {
                pc.Status = PCStatus.Available; pc.CurrentUser = null; pc.StartTime = null; pc.TimeRemaining = TimeSpan.Zero; pc.Budget = 0; pc.IsTopUpRequestSent = false; pc.TimeEndedTimestamp = null; pcsToSave.Add(pc);
            }
            if (pcsToSave.Any()) { foreach (PC pcToSave in pcsToSave) { await firebaseDB.AddOrUpdatePC(pcToSave); } }
        }
        private void buttonClearAddPC_Click(object sender, EventArgs e) { textBoxSequenceNumber.Clear(); textBoxSequenceNumber.Focus(); }
        private void textBoxEditPCName_Leave(object sender, EventArgs e)
        {
            string seqText = textBoxEditPCName.Text.Trim(); ClearEditFields(); if (string.IsNullOrEmpty(seqText)) return;
            if (!int.TryParse(seqText, out int seq) || seq <= 0) { MessageBox.Show("Số máy không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string pcNameToFind = $"PC{seq}"; PC foundPC = pcList.FirstOrDefault(p => p.Name.Equals(pcNameToFind, StringComparison.OrdinalIgnoreCase));
            if (foundPC != null)
            {
                textBoxEditDetailInfo.Text = foundPC.DetailInfo; comboBoxEditStatus.SelectedItem = foundPC.Status; textBoxEditSoTien.Text = foundPC.Budget.ToString();
                if (!string.IsNullOrEmpty(foundPC.CurrentUser)) { var user = allUsers.FirstOrDefault(u => u.Username == foundPC.CurrentUser); if (user != null) { textBoxEditCurrentUser.Text = user.Username; txtEditPhoneNumber.Text = user.PhoneNumber; } }
            }
            else { MessageBox.Show($"Không tìm thấy máy '{pcNameToFind}'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void ClearEditFields() { textBoxEditDetailInfo.Clear(); textBoxEditCurrentUser.Clear(); txtEditPhoneNumber.Clear(); if (comboBoxEditStatus.Items.Count > 0) comboBoxEditStatus.SelectedIndex = 0; textBoxEditSoTien.Clear(); }
        private void buttonEditClear_Click(object sender, EventArgs e) { textBoxEditPCName.Clear(); ClearEditFields(); textBoxEditPCName.Focus(); }
        private void FormDashboard_Activated(object sender, EventArgs e) { if (pcList == null) return; foreach (var pc in pcList.Where(p => p.Status == PCStatus.InUse && p.StartTime.HasValue)) { pc.NotifyTimeUsedChanged(); } }
        #endregion
    }
}