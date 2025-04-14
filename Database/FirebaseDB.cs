using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
// Đảm bảo bạn đã using đúng namespace cho AdminModel và Users

using Internet_Cafe_Manager_App.Database; // Giả sử AdminModel nằm ở đây
using System;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Net;

namespace QL_NET.Database
{
    public class FirebaseDB
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "BOTfpnJFZLR8Gy4VewguWS1q607MXDSlAs8yAKvS",
            BasePath = "https://doanltm-49335-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        public IFirebaseClient client;

        public FirebaseDB()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {
                throw new Exception("Không thể kết nối đến Firebase!");
            }
        }

        // --- Các phương thức CRUD cho Users ---

        public async Task<bool> AddUser(Users user)
        {
            try
            {
                // Sử dụng SetAsync để ghi đè hoặc tạo mới nếu chưa có
                SetResponse response = await client.SetAsync("Users/" + user.username, user);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm user: " + ex.Message);
                return false;
            }
        }

        public async Task<Users> GetUser(string username)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Users/" + username);
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return null; // Không tìm thấy hoặc lỗi
                }
                Users user = response.ResultAs<Users>();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy user: " + ex.Message);
                return null;
            }
        }

        public async Task<bool> DeleteUser(string username)
        {
            try
            {
                FirebaseResponse response = await client.DeleteAsync("Users/" + username);
                // Kiểm tra StatusCode để đảm bảo thành công
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa user: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateUser(Users user)
        {
            try
            {
                // Lưu ý: Đường dẫn trong UpdateAsync nên là "Users/" chứ không phải "User/"
                FirebaseResponse response = await client.UpdateAsync("Users/" + user.username, user);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật user: " + ex.Message);
                return false;
            }
        }


        // --- Các phương thức CRUD cho Admins (Mới) ---

        /// <summary>
        /// Thêm hoặc cập nhật thông tin một Admin vào Firebase.
        /// Sử dụng username của Admin làm khóa.
        /// </summary>
        /// <param name="admin">Đối tượng AdminModel chứa thông tin cần lưu.</param>
        /// <returns>True nếu thành công, False nếu có lỗi.</returns>
        public async Task<bool> AddOrUpdateAdmin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin?.Username))
            {
                Console.WriteLine("Lỗi: Admin username không được để trống.");
                return false;
            }

            try
            {
                // Sử dụng SetAsync để ghi đè hoặc tạo mới nếu chưa có admin với username này
                SetResponse response = await client.SetAsync("Admin/" + admin.Username, admin);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu admin '{admin.Username}': " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Lấy thông tin một Admin từ Firebase dựa vào username.
        /// </summary>
        /// <param name="adminUsername">Username của Admin cần lấy.</param>
        /// <returns>Đối tượng AdminModel nếu tìm thấy, null nếu không tìm thấy hoặc có lỗi.</returns>
        public async Task<Admin> GetAdmin(string adminUsername)
        {
            if (string.IsNullOrEmpty(adminUsername)) return null;

            try
            {
                FirebaseResponse response = await client.GetAsync("Admin/" + adminUsername);
                // Kiểm tra kỹ hơn: không phải null VÀ status code là OK
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return null; // Không tìm thấy hoặc có lỗi xảy ra
                }
                Admin admin = response.ResultAs<Admin>();
                return admin;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy admin '{adminUsername}': " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Xóa một Admin khỏi Firebase dựa vào username.
        /// </summary>
        /// <param name="adminUsername">Username của Admin cần xóa.</param>
        /// <returns>True nếu xóa thành công, False nếu có lỗi.</returns>
        public async Task<bool> DeleteAdmin(string adminUsername)
        {
            if (string.IsNullOrEmpty(adminUsername)) return false;

            try
            {
                FirebaseResponse response = await client.DeleteAsync("Admin/" + adminUsername);
                // Kiểm tra StatusCode để đảm bảo thành công
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa admin '{adminUsername}': " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật thông tin một Admin hiện có trong Firebase.
        /// Lưu ý: UpdateAsync chỉ cập nhật các trường có trong đối tượng admin, không ghi đè toàn bộ.
        /// Nếu muốn ghi đè toàn bộ, hãy dùng AddOrUpdateAdmin (SetAsync).
        /// </summary>
        /// <param name="admin">Đối tượng AdminModel chứa thông tin cần cập nhật.</param>
        /// <returns>True nếu thành công, False nếu có lỗi.</returns>
        public async Task<bool> UpdateAdmin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin?.Username))
            {
                Console.WriteLine("Lỗi: Admin username không được để trống khi cập nhật.");
                return false;
            }
            try
            {
                // UpdateAsync chỉ cập nhật các trường được cung cấp trong object admin
                FirebaseResponse response = await client.UpdateAsync("Admin/" + admin.Username, admin);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật admin '{admin.Username}': " + ex.Message);
                return false;
            }
        }

        // Bạn có thể thêm các phương thức khác nếu cần, ví dụ: GetAllAdmins()
    }
}