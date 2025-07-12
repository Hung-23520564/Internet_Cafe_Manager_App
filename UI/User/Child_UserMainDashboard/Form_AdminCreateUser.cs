using Internet_Cafe_Manager_App.Database;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class Form_AdminCreateUser : Form
    {
        private readonly FirebaseDB firebaseDb;

        public Form_AdminCreateUser()
        {
            InitializeComponent();
            firebaseDb = new FirebaseDB();

            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUserAccount.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserAccount.Focus();
                txtUserAccount.SelectAll();
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ.", "Lỗi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            btnRegister.Enabled = false;
            btnRegister.Text = "Đang xử lý...";
            this.UseWaitCursor = true;

            try
            {
                Users existingUser = await firebaseDb.GetUser(username);
                if (existingUser != null)
                {
                    MessageBox.Show($"Username '{username}' đã tồn tại. Vui lòng chọn username khác.", "Trùng Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserAccount.Focus();
                    txtUserAccount.SelectAll();
                    return;
                }

                var allUsers = await firebaseDb.GetAllUsers();
                int newUserNumber = (allUsers?.Count ?? 0) + 1;
                string datePart = DateTime.Now.ToString("dMMyy");
                string newUserId = $"U{newUserNumber}_{datePart}";

                string passwordHash = PasswordHelper.HashPassword(password);

                Users newUser = new Users
                {
                    UserId = newUserId,
                    Username = username,
                    PasswordHash = passwordHash,
                    FullName = fullName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    IsUserActive = true,
                    CreationTimestamp = DateTime.UtcNow,
                    Role = "User",
                    LastLoginTimestamp = null,
                    Budget = 0,
                    TotalMoneyDeposited = 0,
                    TotalTimePlayed = TimeSpan.Zero,
                    OrderIds = new System.Collections.Generic.List<string>()
                };

                bool success = await firebaseDb.AddOrUpdateUser(newUser);

                if (success)
                {
                    MessageBox.Show($"Tạo tài khoản User thành công!\nUserID: {newUserId}\nUsername: {username}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Xóa các trường sau khi tạo thành công
                    txtFullName.Clear();
                    txtUserAccount.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtEmail.Clear();
                    txtPhoneNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản vào cơ sở dữ liệu.", "Lỗi Lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRegister.Enabled = true;
                btnRegister.Text = "Create Account";
                this.UseWaitCursor = false;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}