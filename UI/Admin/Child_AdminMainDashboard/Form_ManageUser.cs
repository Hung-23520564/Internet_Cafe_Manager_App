// File: Form_ManageUser.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;
using FireSharp.Response;
using FireSharp.EventStreaming;
using Newtonsoft.Json;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class Form_ManageUser : Form
    {
        private FirebaseDB firebaseDB;
        private BindingList<Users> bindingListUsers;
        private EventStreamResponse userListener;

        public Form_ManageUser()
        {
            InitializeComponent();
            firebaseDB = new FirebaseDB();
            bindingListUsers = new BindingList<Users>();

            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.DataSource = bindingListUsers;

            // Cấu hình cho cả 2 DataGridView
            dataGridViewUserOrders.AutoGenerateColumns = false;
            dataGridViewHireTime.AutoGenerateColumns = false; 

            this.FormClosing += Form_ManageUser_FormClosing;
        }

        private async void Form_ManageUser_Load(object sender, EventArgs e)
        {
            await InitialLoadAndListenForUsers();

            panelTitleBar.Layout += (s, ev) => {
                if (panelTitleBar.Width > 0 && labelTitle.Width > 0)
                {
                    labelTitle.Location = new Point((panelTitleBar.Width - labelTitle.Width) / 2, (panelTitleBar.Height - labelTitle.Height) / 2);
                }
            };
            if (panelTitleBar.Width > 0 && labelTitle.Width > 0)
            {
                labelTitle.Location = new Point((panelTitleBar.Width - labelTitle.Width) / 2, (panelTitleBar.Height - labelTitle.Height) / 2);
            }
        }

        private async Task InitialLoadAndListenForUsers()
        {
            try
            {
                var initialUsers = await firebaseDB.GetAllUsers();
                if (initialUsers != null)
                {
                    this.Invoke((MethodInvoker)delegate {
                        bindingListUsers.Clear();
                        foreach (var user in initialUsers)
                        {
                            bindingListUsers.Add(user);
                        }
                    });
                }

                userListener?.Dispose();

                if (firebaseDB.client == null)
                {
                    MessageBox.Show("Firebase client is not initialized in FirebaseDB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                userListener = await firebaseDB.client.OnAsync("Users",
                    (object sender, ValueAddedEventArgs args, object context) => {
                        HandleFirebaseEvent(args.Path, args.Data, "ADD");
                    },
                    (object sender, ValueChangedEventArgs args, object context) => {
                        HandleFirebaseEvent(args.Path, args.Data, "UPDATE");
                    },
                    (object sender, ValueRemovedEventArgs args, object context) => {
                        HandleFirebaseEvent(args.Path, null, "DELETE");
                    }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading or listening to users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleFirebaseEvent(string path, string data, string eventType)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ProcessFirebaseEvent(path, data, eventType)));
            }
            else
            {
                ProcessFirebaseEvent(path, data, eventType);
            }
        }

        private void ProcessFirebaseEvent(string path, string jsonData, string eventType)
        {
            try
            {
                // Xử lý khi có sự kiện trên toàn bộ node "Users"
                if (path == "/" && eventType != "DELETE" && !string.IsNullOrEmpty(jsonData) && jsonData != "null")
                {
                    var allUsersFromEvent = JsonConvert.DeserializeObject<Dictionary<string, Users>>(jsonData);
                    bindingListUsers.Clear();
                    if (allUsersFromEvent != null)
                    {
                        foreach (var entry in allUsersFromEvent)
                        {
                            Users user = entry.Value;
                            if (string.IsNullOrEmpty(user.Username)) user.Username = entry.Key;
                            bindingListUsers.Add(user);
                        }
                    }
                    return;
                }

                string username = path.TrimStart('/');
                if (string.IsNullOrEmpty(username)) return;

                // Xử lý sự kiện XÓA
                if (eventType == "DELETE")
                {
                    var userToRemove = bindingListUsers.FirstOrDefault(u => u.Username == username);
                    if (userToRemove != null)
                    {
                        bindingListUsers.Remove(userToRemove);
                    }
                }
                // Xử lý sự kiện THÊM MỚI
                else if (eventType == "ADD")
                {
                    if (string.IsNullOrEmpty(jsonData) || jsonData == "null") return;
                    Users newUser = JsonConvert.DeserializeObject<Users>(jsonData);
                    if (newUser != null)
                    {
                        if (string.IsNullOrEmpty(newUser.Username))
                        {
                            newUser.Username = username;
                        }
                        // Kiểm tra lại để chắc chắn không thêm trùng
                        if (!bindingListUsers.Any(u => u.Username == newUser.Username))
                        {
                            bindingListUsers.Add(newUser);
                        }
                    }
                }
                // <--- BẮT ĐẦU VÙNG SỬA ĐỔI QUAN TRỌNG --- >
                // Xử lý sự kiện CẬP NHẬT
                else if (eventType == "UPDATE")
                {
                    if (string.IsNullOrEmpty(jsonData) || jsonData == "null") return;

                    // Tìm người dùng hiện có trong danh sách bằng username
                    var existingUser = bindingListUsers.FirstOrDefault(u => u.Username == username);
                    if (existingUser != null)
                    {
                        // **Sửa lỗi mấu chốt:**
                        // Dùng PopulateObject để hợp nhất dữ liệu mới (jsonData) vào đối tượng đã có (existingUser)
                        // thay vì thay thế hoàn toàn.
                        JsonConvert.PopulateObject(jsonData, existingUser);

                        // Yêu cầu DataGridView cập nhật lại giao diện cho dòng vừa thay đổi
                        int index = bindingListUsers.IndexOf(existingUser);
                        if (index != -1)
                        {
                            bindingListUsers.ResetItem(index);
                        }
                    }
                }
                // <--- KẾT THÚC VÙNG SỬA ĐỔI QUAN TRỌNG --- >
            }
            catch (Exception ex)
            {
                // Ghi log lỗi để dễ dàng gỡ rối
                Console.WriteLine($"Error processing Firebase event: {ex.Message}. Path: {path}");
            }
        }

        // <--- SỬA ĐỔI: Bắt đầu khu vực sửa đổi --- >
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                Users selectedUser = dataGridViewUsers.SelectedRows[0].DataBoundItem as Users;
                if (selectedUser != null)
                {
                    DisplayUserDetails(selectedUser);
                    // Gọi cả hai hàm để tải dữ liệu cho hai bảng riêng biệt
                    LoadUserOrders(selectedUser.Username);
                    LoadHireTimeHistory(selectedUser.Username); // Gọi hàm mới
                }
            }
            else
            {
                ClearUserDetails();
            }
        }

        private void DisplayUserDetails(Users user)
        {
            lblUsername.Text = $"Username: {user.Username}";
            lblUserFullName.Text = $"Full Name: {user.FullName}";
            lblUserEmail.Text = $"Email: {user.Email}";
        }

        private void ClearUserDetails()
        {
            lblUsername.Text = "Username: -";
            lblUserFullName.Text = "Full Name: -";
            lblUserEmail.Text = "Email: -";
            // Xóa dữ liệu của cả hai bảng
            dataGridViewUserOrders.DataSource = null;
            dataGridViewHireTime.DataSource = null;
        }

        private async void LoadUserOrders(string username)
        {
            try
            {
                dataGridViewUserOrders.DataSource = null;

                var allOrders = await firebaseDB.GetAllOrders();

                // --- LOGIC MỚI: Lọc các đơn hàng đồ ăn bằng cách kiểm tra sự tồn tại của Items ---
                var ordersForUser = allOrders
                                    .Where(o => o.Username == username && o.Items != null && o.Items.Any())
                                    .OrderByDescending(o => o.Timestamp)
                                    .Select(o => new {
                                        OrderId = o.OrderId,
                                        Timestamp = o.Timestamp.ToLocalTime(),
                                        ItemsSummary = string.Join(", ", o.Items.Select(i => $"{i.Product.Name} (x{i.Quantity})")),
                                        GrandTotal = o.GrandTotal,
                                        Status = o.Status
                                    })
                                    .ToList();

                dataGridViewUserOrders.DataSource = ordersForUser;

                if (dataGridViewUserOrders.Columns["colOrderTimestamp"] != null)
                {
                    dataGridViewUserOrders.Columns["colOrderTimestamp"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
                if (dataGridViewUserOrders.Columns["colOrderTotal"] != null)
                {
                    dataGridViewUserOrders.Columns["colOrderTotal"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dataGridViewUserOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra có phải cột nút Action và không phải hàng tiêu đề không
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewUserOrders.Columns["colMarkAsCompleteOrder"].Index)
            {
                return;
            }

            // Lấy thông tin từ dòng được click
            var dataItem = dataGridViewUserOrders.Rows[e.RowIndex].DataBoundItem;
            string orderId = ((dynamic)dataItem).OrderId;
            string currentStatus = ((dynamic)dataItem).Status;
            Users selectedUser = dataGridViewUsers.SelectedRows[0].DataBoundItem as Users;

            if (selectedUser == null) return;

            // Trường hợp 1: Đơn hàng đang chờ và người dùng bấm "Complete"
            if (currentStatus == "Processing")
            {
                // --- THÊM HỘP THOẠI XÁC NHẬN ---
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn hoàn thành đơn hàng này không?",
                    "Xác nhận hoàn thành",
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.OK)
                {
                    await UpdateOrderStatus(orderId, "Completed", selectedUser.Username);
                }
            }
            // Trường hợp 2: Đơn hàng đã xong và người dùng bấm "Change"
            else if (currentStatus == "Completed")
            {
                // --- THÊM HỘP THOẠI XÁC NHẬN ---
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn đổi trạng thái đơn hàng này về 'Pending' không?",
                    "Xác nhận thay đổi",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.OK)
                {
                    await UpdateOrderStatus(orderId, "Pending", selectedUser.Username);
                }
            }
        }

        // Tách logic cập nhật ra một hàm riêng để tái sử dụng
        private async Task UpdateOrderStatus(string orderId, string newStatus, string username)
        {
            FirebaseDB firebaseDB = new FirebaseDB();
            bool success = await firebaseDB.UpdateOrderStatus(orderId, newStatus);

            if (success)
            {
                // Tải lại danh sách đơn hàng để cập nhật giao diện
                LoadUserOrders(username);
            }
            else
            {
                MessageBox.Show($"Cập nhật trạng thái cho đơn hàng {orderId} thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void dataGridViewHireTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào cột nút "Action" và không phải hàng tiêu đề không
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewHireTime.Columns["colMarkAsCompleteHire"].Index)
            {
                return;
            }

            // Lấy thông tin từ dòng được click
            var dataItem = dataGridViewHireTime.Rows[e.RowIndex].DataBoundItem;
            string orderId = ((dynamic)dataItem).OrderId;
            string currentStatus = ((dynamic)dataItem).Status;
            Users selectedUser = dataGridViewUsers.SelectedRows[0].DataBoundItem as Users;

            if (selectedUser == null) return;

            {
                DialogResult result = MessageBox.Show(
                    $"Xác nhận giao dịch nạp tiền cho người dùng '{selectedUser.Username}'?",
                    "Xác nhận giao dịch",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.OK)
                {
                    FirebaseDB firebaseDB = new FirebaseDB();
                    // Tìm máy mà user đang sử dụng
                    PC activePC = await firebaseDB.GetActivePCForUser(selectedUser.Username);

                    if (activePC == null)
                    {
                        MessageBox.Show($"Người dùng '{selectedUser.Username}' không đang sử dụng máy nào. Không thể nạp tiền.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cộng tiền và thời gian vào máy
                    decimal amount = ((dynamic)dataItem).GrandTotal;
                    TimeSpan timeToAdd = ((dynamic)dataItem).TimePurchased;

                    activePC.Budget += (int)amount;
                    activePC.TimeRemaining = (activePC.TimeRemaining ?? TimeSpan.Zero) + timeToAdd;

                    // Lưu lại thông tin máy đã cập nhật
                    bool pcUpdateSuccess = await firebaseDB.AddOrUpdatePC(activePC);
                    if (pcUpdateSuccess)
                    {
                        // Cập nhật trạng thái đơn hàng thành "Completed"
                        await UpdateOrderStatus(orderId, "Completed", selectedUser.Username);
                        // Tải lại cả hai bảng lịch sử để cập nhật giao diện
                        LoadHireTimeHistory(selectedUser.Username);
                        LoadUserOrders(selectedUser.Username);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin máy thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private async void LoadHireTimeHistory(string username)
        {
            try
            {
                dataGridViewHireTime.DataSource = null;

                var allOrders = await firebaseDB.GetAllOrders();

                // --- LOGIC MỚI: Lọc các giao dịch thuê máy bằng cách kiểm tra Items rỗng và Type ---
                var hireHistory = allOrders
                                    .Where(o => o.Username == username && (o.Items == null || !o.Items.Any()) && o.Type == TransactionType.PcUsage)
                                    .OrderByDescending(o => o.Timestamp)
                                    .Select(o => new {
                                        OrderId = o.OrderId,
                                        Timestamp = o.Timestamp.ToLocalTime(),
                                        Description = o.Description,
                                        TimePurchased = o.TimePurchased ?? TimeSpan.Zero,
                                        GrandTotal = o.GrandTotal,
                                        Status = o.Status
                                    })
                                    .ToList();

                dataGridViewHireTime.DataSource = hireHistory;

                if (dataGridViewHireTime.Columns["colHireDateTime"] != null)
                {
                    dataGridViewHireTime.Columns["colHireDateTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }
                if (dataGridViewHireTime.Columns["colHireTotalAmount"] != null)
                {
                    dataGridViewHireTime.Columns["colHireTotalAmount"].DefaultCellStyle.Format = "N0";
                }
                if (dataGridViewHireTime.Columns["colHireTimeDuration"] != null)
                {
                    dataGridViewHireTime.Columns["colHireTimeDuration"].DefaultCellStyle.Format = @"hh\:mm\:ss";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading hire time history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUserOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem có phải cột nút "Action" không
            if (e.ColumnIndex == dataGridViewUserOrders.Columns["colMarkAsCompleteOrder"].Index && e.RowIndex >= 0)
            {
                // Lấy trạng thái của đơn hàng từ cột "Status" trong cùng một hàng
                string status = dataGridViewUserOrders.Rows[e.RowIndex].Cells["colOrderStatus"].Value?.ToString();

                // Ép kiểu ô hiện tại thành một ô nút
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridViewUserOrders.Rows[e.RowIndex].Cells["colMarkAsCompleteOrder"];

                if (status == "Completed")
                {
                    // Nếu đã hoàn thành -> Đổi chữ thành "Change" và đổi màu
                    e.Value = "Change";
                    buttonCell.Style.BackColor = Color.CadetBlue; // Màu cam đỏ
                    buttonCell.Style.SelectionBackColor = Color.BlueViolet;
                }
                else // Mặc định là "Pending" hoặc trạng thái khác
                {
                    // Nếu đang chờ -> Giữ nguyên là "Complete" và màu xanh
                    e.Value = "Complete";
                    buttonCell.Style.BackColor = Color.MediumSeaGreen; // Màu xanh lá
                    buttonCell.Style.SelectionBackColor = Color.SeaGreen;
                }
            }
        }

        private void dataGridViewHireTime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem có phải cột nút "Action" không
            if (e.ColumnIndex == dataGridViewHireTime.Columns["colMarkAsCompleteHire"].Index && e.RowIndex >= 0)
            {
                // Lấy trạng thái của đơn hàng từ cột "Status"
                string status = dataGridViewHireTime.Rows[e.RowIndex].Cells["colHireStatus"].Value?.ToString();
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridViewHireTime.Rows[e.RowIndex].Cells["colMarkAsCompleteHire"];

                if (status == "Completed")
                {
                    e.Value = "Change";
                    buttonCell.Style.BackColor = Color.OrangeRed;
                    buttonCell.Style.SelectionBackColor = Color.DarkRed;
                }
                else // Mặc định là "Pending"
                {
                    e.Value = "Complete";
                    buttonCell.Style.BackColor = Color.MediumSeaGreen;
                    buttonCell.Style.SelectionBackColor = Color.SeaGreen;
                }
            }
        }


        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchUser.Text.ToLower();
            List<Users> allCurrentUsers = bindingListUsers.ToList();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                var currentView = new BindingList<Users>(allCurrentUsers);
                dataGridViewUsers.DataSource = currentView;
            }
            else
            {
                var filteredUsers = allCurrentUsers.Where(u =>
                    (u.Username != null && u.Username.ToLower().Contains(searchText)) ||
                    (u.FullName != null && u.FullName.ToLower().Contains(searchText))
                ).ToList();
                dataGridViewUsers.DataSource = new BindingList<Users>(filteredUsers);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchUser.Clear();
            await InitialLoadAndListenForUsers();
            ClearUserDetails();
        }


        private void Form_ManageUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            userListener?.Dispose();
        }
    }
}