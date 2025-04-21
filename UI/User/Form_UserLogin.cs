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
using Internet_Cafe_Manager_App.UI.Admin;


namespace Internet_Cafe_Manager_App.UI.User
{
    public partial class Form_UserLogin: Form
    {
        FirebaseDB firebaseDB;
        public Form_UserLogin()
        {
            InitializeComponent();
            firebaseDB = new FirebaseDB(); // Khởi tạo đối tượng kết nối Firebase

            // --- Các thiết lập ban đầu cho Form ---
            this.StartPosition = FormStartPosition.CenterScreen; // Hiển thị form giữa màn hình
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Cố định kích thước
            this.MaximizeBox = false;

            // Đảm bảo TextBox mật khẩu hiển thị dấu *
            txtPassword.PasswordChar = '*';

            // Thiết lập sự kiện KeyDown cho phép nhấn Enter để đăng nhập
            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtUsername.KeyDown += TxtPassword_KeyDown;
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Chuyển focus xuống ô password nếu nhấn Enter ở ô username
                txtPassword.Focus();
                e.SuppressKeyPress = true; // Ngăn tiếng 'beep'
            }
        }
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Thực hiện hành động đăng nhập nếu nhấn Enter ở ô password
                btnLogin.PerformClick(); // Giả lập việc nhấn nút Đăng nhập
                e.SuppressKeyPress = true; // Ngăn tiếng 'beep'
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Không cần Trim mật khẩu

            // 1. Kiểm tra đầu vào cơ bản
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Hiển thị trạng thái chờ (ví dụ: thay đổi text nút, hiện icon loading...)
            btnLogin.Enabled = false;
            btnLogin.Text = "Đang xử lý...";
            this.UseWaitCursor = true;

            try
            {
                // 2. Lấy thông tin Admin từ Firebase
                Internet_Cafe_Manager_App.Database.Users user = await firebaseDB.GetUser(username);

                // 3. Kiểm tra kết quả
                if (user == null)
                {
                    MessageBox.Show("Username không tồn tại!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!user.IsUserActive)
                {
                    MessageBox.Show("Tài khoản User này đã bị vô hiệu hóa!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // 4. Xác minh mật khẩu (QUAN TRỌNG)
                    // Giả sử bạn có lớp PasswordHelper với phương thức VerifyPassword
                    // bool isPasswordValid = PasswordHelper.VerifyPassword(password, admin.PasswordHash);

                    // !!! THAY THẾ DÒNG DƯỚI BẰNG HÀM XÁC MINH HASH THỰC TẾ !!!
                    // Đây chỉ là VÍ DỤ ĐƠN GIẢN, KHÔNG AN TOÀN cho mục đích minh họa
                    // Trong thực tế phải dùng thư viện hash (BCrypt, Argon2...)
                    bool isPasswordValid = (password == user.PasswordHash); // << --- !!! THAY THẾ DÒNG NÀY !!!

                    if (isPasswordValid)
                    {
                        // 5. Đăng nhập thành công
                        MessageBox.Show($"Đăng nhập thành công! Chào mừng {user.FullName}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // (Tùy chọn) Cập nhật LastLoginTimestamp
                        user.LastLoginTimestamp = DateTime.UtcNow;
                        await firebaseDB.UpdateUser(user); // Hoặc AddOrUpdateAdmin

                        // Mở trang chủ Admin
                        Form_AdminMainDashboard dashboardForm = new Form_AdminMainDashboard();
                        // Có thể truyền thông tin admin đã login qua dashboard bằng cách thay lệnh phía trên bằng lệnh : Form_AdminMainDashboard dashboardForm = new Form_AdminMainDashboard(admin);
                        dashboardForm.Show();

                        // Ẩn form đăng nhập
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Lỗi Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // 6. Xử lý lỗi (ví dụ: lỗi mạng, lỗi Firebase...)
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Khôi phục trạng thái nút và con trỏ chuột
                btnLogin.Enabled = true;
                btnLogin.Text = "Đăng Nhập";
                this.UseWaitCursor = false;
            }
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Hoặc btnRegister_Click nếu là Button
        {
            // Tạo và hiển thị form đăng ký Admin
            Form_UserRegister registerForm = new Form_UserRegister();
            registerForm.Show();

            // Ẩn form đăng nhập hiện tại
            this.Hide();
        }

        // --- Xử lý khi Form bị đóng ---
        private void Form_UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Quyết định hành động khi form này đóng
            // Ví dụ: hiển thị lại form chọn vai trò ban đầu hoặc thoát hẳn ứng dụng

            // Tìm form InitialChoice nếu nó chưa bị hủy
            Form_InitialChoice initialChoiceForm = Application.OpenForms.OfType<Form_InitialChoice>().FirstOrDefault();
            if (initialChoiceForm != null)
            {
                initialChoiceForm.Show(); // Hiển thị lại form chọn vai trò
            }
            else
            {
                Application.Exit(); // Thoát nếu không tìm thấy form chọn vai trò
            }
        }
    }

    // --- Lớp PasswordHelper GIẢ ĐỊNH ---
    // Bạn cần tạo lớp này và cài đặt phương thức hash/verify thực tế
    public static class PasswordHelper
    {
        // Phương thức này cần sử dụng thư viện hash (BCrypt.Net, Argon2...)
        // để so sánh mật khẩu nhập vào với hash đã lưu.
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // !!! --- CÀI ĐẶT LOGIC XÁC MINH HASH THỰC TẾ Ở ĐÂY --- !!!
            // Ví dụ dùng BCrypt.Net: return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);

            // Tạm thời dùng so sánh chuỗi đơn giản (KHÔNG AN TOÀN)
            return enteredPassword == storedHash;
        }

        // Bạn cũng cần một phương thức để Hash mật khẩu khi đăng ký
        public static string HashPassword(string password)
        {
            // !!! --- CÀI ĐẶT LOGIC HASH THỰC TẾ Ở ĐÂY --- !!!
            // Ví dụ dùng BCrypt.Net: return BCrypt.Net.BCrypt.HashPassword(password);

            // Tạm thời trả về mật khẩu gốc (KHÔNG AN TOÀN)
            return password;
        }

    }
}
