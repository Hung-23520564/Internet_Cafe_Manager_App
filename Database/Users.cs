using System;

namespace Internet_Cafe_Manager_App.Database
{
    public class Users
    {
        // Đổi 'name' thành 'FullName' cho khớp với form
        public string FullName { get; set; }

        // Giữ 'username' chữ thường nếu anh đã dùng nó làm key trên Firebase và trong các hàm CRUD
        // Hoặc đổi thành 'Username' (chữ hoa) nếu muốn thống nhất và sửa lại cả trong hàm CRUD
        public string Username { get; set; } // Hoặc public string Username { get; set; }

        // !!! THAY 'password' BẰNG 'PasswordHash' !!!
        public string PasswordHash { get; set; }

        // Thêm thuộc tính Email
        public string Email { get; set; }

        // Đổi 'phoneNumber' thành 'PhoneNumber' cho khớp form (hoặc sửa ở form)
        public string PhoneNumber { get; set; } // Hoặc public string phoneNumber { get; set; }

        // Bỏ 'Budget' đi nếu không dùng trong đăng ký/đăng nhập? Hoặc giữ lại nếu cần sau này.
        public int Budget { get; set; }

        // Đổi 'isavailable' thành 'IsActive' cho khớp form và rõ nghĩa hơn
        public bool IsUserActive { get; set; }

        // !!! THÊM CÁC THUỘC TÍNH CÒN THIẾU !!!
        public DateTime CreationTimestamp { get; set; } // Chính là cái gây lỗi nè!
        public string Role { get; set; } // Thêm Role
        public DateTime? LastLoginTimestamp { get; set; } // Thêm LastLogin, dùng DateTime? vì có thể null

        // Constructor rỗng giữ lại cũng được
        public Users() { }
    }
}