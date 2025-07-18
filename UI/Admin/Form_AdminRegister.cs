﻿using Internet_Cafe_Manager_App.Database; // Namespace chứa Admin model (nếu dùng Admin)
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

namespace Internet_Cafe_Manager_App.UI.Admin // Thay bằng namespace thực tế
{
    public partial class Form_AdminRegister : Form
    {
        private FirebaseDB firebaseDb;

        public Form_AdminRegister()
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
            string username = txtAdminAccount.Text.Trim();
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
                txtAdminAccount.Focus();
                txtAdminAccount.SelectAll();
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
                txtAdminAccount.Focus();
                txtAdminAccount.SelectAll();
                return;
            }


            // --- Bắt đầu xử lý bất đồng bộ ---
            btnRegister.Enabled = false;
            btnRegister.Text = "Đang xử lý...";
            this.UseWaitCursor = true;

            try
            {
                // 3. Kiểm tra xem Username đã tồn tại chưa
                Internet_Cafe_Manager_App.Database.Admin existingAdmin = await firebaseDb.GetAdmin(username);
                if (existingAdmin != null)
                {
                    MessageBox.Show($"Username '{username}' đã tồn tại. Vui lòng chọn username khác.", "Trùng Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFullName.Focus();
                    txtFullName.SelectAll();
                    // Khôi phục trạng thái nút và con trỏ chuột sớm nếu lỗi
                    btnRegister.Enabled = true;
                    btnRegister.Text = "Tạo tài khoản";
                    this.UseWaitCursor = false;
                    return; // Dừng lại nếu username đã tồn tại
                }

                // 4. Băm mật khẩu (QUAN TRỌNG - Sử dụng PasswordHelper đã cài đặt)
                string passwordHash = PasswordHelper.HashPassword(password);
                // !!! --- Đảm bảo PasswordHelper.HashPassword dùng thuật toán an toàn (BCrypt...) --- !!!

                // 5. Tạo đối tượng Admin mới
                Internet_Cafe_Manager_App.Database.Admin newAdmin = new Internet_Cafe_Manager_App.Database.Admin
                {
                    // AdminId có thể để Firebase tự tạo key hoặc bạn tự tạo (ví dụ: Guid)
                    // AdminId = Guid.NewGuid().ToString(), // Ví dụ tự tạo ID
                    Username = username,
                    PasswordHash = passwordHash, // Lưu mật khẩu đã băm
                    FullName = fullName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    IsAdminActive = true, // Mặc định là active
                    CreationTimestamp = DateTime.UtcNow, // Thời gian tạo (giờ UTC)
                    Role = "Admin", // Gán vai trò mặc định (hoặc có thể cho chọn)
                    LastLoginTimestamp = null // Chưa đăng nhập lần nào
                };

                // 6. Lưu Admin mới vào Firebase
                bool success = await firebaseDb.AddOrUpdateAdmin(newAdmin); // Dùng AddOrUpdateAdmin để tạo mới

                // 7. Thông báo kết quả và điều hướng
                if (success)
                {
                    MessageBox.Show("Tạo tài khoản Admin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển về trang đăng nhập
                    Form_AdminLogin loginForm = new Form_AdminLogin();
                    loginForm.Show();
                    this.Hide(); // Ẩn form đăng ký hiện tại
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
        private void Form_AdminRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Khi form đăng ký đóng, nên hiển thị lại form đăng nhập
            Form_AdminLogin adminLogin = Application.OpenForms.OfType<Form_AdminLogin>().FirstOrDefault();
            if (adminLogin != null)
            {
                adminLogin.Show(); // Hiển thị lại form đăng nhập nếu nó còn tồn tại
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
            Form_AdminLogin loginForm = new Form_AdminLogin();
            loginForm.Show();
            this.Close();
        }

        private void Form_AdminRegister_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}