using Internet_Cafe_Manager_App.Database; // Namespace chứa User model
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Cần cho việc kiểm tra Email (tùy chọn)

namespace Internet_Cafe_Manager_App.UI.User
{
    public partial class Form_UserRegister : Form
    {
        private FirebaseDB firebaseDb;

        public Form_UserRegister()
        {
            InitializeComponent();
            firebaseDb = new FirebaseDB();

            // --- Các thiết lập ban đầu ---
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Đặt PasswordChar cho các ô mật khẩu
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        // --- Xử lý Click nút "Tạo tài khoản" ---
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ các TextBox
            string fullName = txtFullName.Text.Trim();
            string username = txtUserAccount.Text.Trim();
            string password = txtPassword.Text; // Không Trim password
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // 2. Kiểm tra dữ liệu đầu vào (Validation)
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

            // (Tùy chọn) Kiểm tra định dạng Email đơn giản
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Định dạng Email không hợp lệ.", "Lỗi Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            // (Tùy chọn) Kiểm tra độ dài mật khẩu tối thiểu
            if (password.Length < 6) // Ví dụ: yêu cầu ít nhất 6 ký tự
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Lỗi Mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserAccount.Focus();
                txtUserAccount.SelectAll();
                return;
            }


            btnRegister.Enabled = false;
            btnRegister.Text = "Đang xử lý...";
            this.UseWaitCursor = true;

            try
            {
                // 3. Kiểm tra xem Username đã tồn tại chưa
                Internet_Cafe_Manager_App.Database.Users existingUser = await firebaseDb.GetUser(username);
                if (existingUser != null)
                {
                    MessageBox.Show($"Username '{username}' đã tồn tại. Vui lòng chọn username khác.", "Trùng Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                    txtFullName.SelectAll();
                    btnRegister.Enabled = true;
                    btnRegister.Text = "Tạo tài khoản";
                    this.UseWaitCursor = false;
                    return;
                }

                // --- BẮT ĐẦU LOGIC MỚI ---
                // Lấy tổng số người dùng hiện có để tạo ID tuần tự
                var allUsers = await firebaseDb.GetAllUsers();
                int newUserNumber = allUsers.Count + 1;

                // Lấy ngày hiện tại theo định dạng yêu cầu (ngàyThángNăm)
                string datePart = DateTime.Now.ToString("dMyy");

                // Tạo UserId mới theo định dạng U<Số thứ tự>_<ngàyThángNăm>
                string newUserId = $"U{newUserNumber}_{datePart}";
                // --- KẾT THÚC LOGIC MỚI ---

                // 4. Băm mật khẩu
                string passwordHash = PasswordHelper.HashPassword(password);

                // 5. Tạo đối tượng User mới với UserId đã được tùy chỉnh
                Internet_Cafe_Manager_App.Database.Users newUser = new Internet_Cafe_Manager_App.Database.Users
                {
                    // THAY ĐỔI: Sử dụng UserId mới thay vì Guid
                    UserId = newUserId,
                    Username = username,
                    PasswordHash = passwordHash,
                    FullName = fullName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    IsUserActive = true,
                    CreationTimestamp = DateTime.UtcNow,
                    Role = "User",
                    LastLoginTimestamp = null
                };
                // ... (phần còn lại của phương thức giữ nguyên) ...
                // 6. Lưu User mới vào Firebase
                bool success = await firebaseDb.AddOrUpdateUser(newUser);

                // 7. Thông báo kết quả và điều hướng
                if (success)
                {
                    MessageBox.Show($"Tạo tài khoản User thành công! User ID của bạn là: {newUserId}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển về trang đăng nhập
                    Form_UserLogin loginForm = new Form_UserLogin();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản vào cơ sở dữ liệu.", "Lỗi Lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // 8. Xử lý lỗi ngoại lệ (ví dụ: mất mạng...)
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Khôi phục trạng thái nút và con trỏ chuột (luôn chạy)
                btnRegister.Enabled = true;
                btnRegister.Text = "Tạo tài khoản";
                this.UseWaitCursor = false;
            }
        }

        // --- Hàm kiểm tra định dạng Email đơn giản (Tùy chọn) ---
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Dùng biểu thức chính quy (Regex) cơ bản để kiểm tra
                // Có thể dùng các biểu thức phức tạp hơn hoặc thư viện nếu cần độ chính xác cao
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        // --- Xử lý khi Form bị đóng ---
        private void Form_UserRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi form đăng ký đóng, nên hiển thị lại form đăng nhập
            Form_UserLogin loginForm = Application.OpenForms.OfType<Form_UserLogin>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show(); // Hiển thị lại form đăng nhập nếu nó còn tồn tại
            }
            else // Nếu form login cũng bị đóng rồi thì có thể mở lại hoặc thoát
            {
                // Tùy chọn: Mở lại form login mới
                // Form_AdminLogin newLoginForm = new Form_AdminLogin();
                // newLoginForm.Show();

                // Hoặc hiển thị lại form chọn vai trò ban đầu
                Form_InitialChoice initialChoiceForm = Application.OpenForms.OfType<Form_InitialChoice>().FirstOrDefault();
                if (initialChoiceForm != null)
                {
                    initialChoiceForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void llbBackToLogin_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_UserLogin loginForm = new Form_UserLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
