using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTM.Database
{
    /// <summary>
    /// Đại diện cho mô hình dữ liệu của một tài khoản Quản trị viên (Admin).
    /// </summary>
    public class Admin
    {
        public string AdminId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public string FullName { get; set; }

        public string Role { get; set; }

        public bool IsAdminActive { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime CreationTimestamp { get; set; }

        public DateTime? LastLoginTimestamp { get; set; }

        // --- Constructors ---

        /// <summary>
        /// Hàm dựng mặc định.
        /// </summary>
        public Admin()
        {
            // Khởi tạo giá trị mặc định nếu cần
            IsAdminActive = true; // Ví dụ: mặc định là active khi mới tạo
            CreationTimestamp = DateTime.UtcNow; // Ghi lại thời gian tạo theo giờ UTC
        }

        /// <summary>
        /// Hàm dựng với các tham số cơ bản (ví dụ).
        /// </summary>
        /// <param name="adminId">ID duy nhất</param>
        /// <param name="username">Tên đăng nhập</param>
        /// <param name="passwordHash">Mật khẩu đã băm</param>
        /// <param name="fullName">Tên đầy đủ</param>
        /// <param name="role">Vai trò</param>
        public Admin(string adminId, string username, string passwordHash, string fullName, string role)
        {
            AdminId = adminId;
            Username = username;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
            IsAdminActive = true; // Mặc định active
            CreationTimestamp = DateTime.UtcNow; // Ghi lại thời gian tạo
        }
    }
}
