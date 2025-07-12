using FireSharp.Config;
using FireSharp.EventStreaming;
using FireSharp.Interfaces;
using FireSharp.Response;
// Đảm bảo bạn đã using đúng namespace cho lớp Users và Admin
using Internet_Cafe_Manager_App.Database; // Giả sử lớp Users, Admin nằm ở đây
using System;
using System.Threading.Tasks;
// using Microsoft.VisualBasic.ApplicationServices; // Mấy using không cần thiết có thể bỏ đi
// using System.IO;
// using System.Net; // System.Net.HttpStatusCode dùng ở dưới nên giữ lại

namespace Internet_Cafe_Manager_App.Database
{
    public class FirebaseDB
    {
        // --- Phần cấu hình Firebase Client (Giữ nguyên như cũ) ---
        private static IFirebaseConfig config = new FirebaseConfig
        {
            // !!! CẢNH BÁO: KHÔNG NÊN HARDCODE SECRET/KEY VÀ BASEPATH Ở ĐÂY !!!
            // Nên đọc từ file cấu hình (app.config, appsettings.json)

            AuthSecret = "LUrH3rDtqWkRVSlAHvY7WvBcN0Y8a3eVkOXSsWPD", // <<< VẪN KHUYÊN DÙNG SERVICE ACCOUNT KEY THAY CHO CÁI NÀY
            BasePath = "https://internet-cafe-manager-ap-9e088-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };
        public IFirebaseClient client;

        public FirebaseDB()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                // Kiểm tra client sau khi khởi tạo (dù FireSharp thường không trả về null ở đây)
                if (client == null)
                {
                    // Ghi log hoặc throw exception rõ ràng hơn
                    throw new InvalidOperationException("Không thể khởi tạo FirebaseClient!");
                }
                // Có thể thêm một lần kiểm tra kết nối đơn giản nếu cần, ví dụ GetAsync tới root "/"
                // var response = await client.GetAsync("/"); // Tuy nhiên, không nên gọi async trong constructor
            }
            catch (Exception ex)
            {
                // Ghi log lỗi khởi tạo
                Console.WriteLine("Lỗi nghiêm trọng khi khởi tạo FirebaseDB: " + ex.Message);
                // Rethrow hoặc xử lý phù hợp, ví dụ: throw new Exception(...) để báo lỗi ra ngoài
                throw new Exception("Không thể kết nối đến Firebase! Chi tiết: " + ex.Message, ex);
            }
        }

        // --- Các phương thức CRUD cho Users (Đã "nâng cấp") ---

        /// <summary>
        /// Thêm hoặc cập nhật thông tin một User vào Firebase.
        /// Sử dụng username làm khóa. Ghi đè nếu username đã tồn tại.
        /// </summary>
        /// <param name="user">Đối tượng Users chứa thông tin cần lưu.</param>
        /// <returns>True nếu thành công, False nếu có lỗi.</returns>
        public async Task<bool> AddOrUpdateUser(Users user) // Đã đổi tên từ AddUser
        {
            // 1. Kiểm tra đầu vào cơ bản
            if (user == null)
            {
                Console.WriteLine("Lỗi: Đối tượng User không được null.");
                return false;
            }
            if (string.IsNullOrEmpty(user.Username)) // Giả sử thuộc tính username là 'username'
            {
                Console.WriteLine("Lỗi: User username không được để trống.");
                return false;
            }

            try
            {
                // 2. Gọi Firebase API (Dùng SetAsync để Add hoặc Update)
                // Đảm bảo đường dẫn node đúng là "Users/"
                SetResponse response = await client.SetAsync("Users/" + user.Username, user);

                // 3. Kiểm tra kết quả trả về từ Firebase
                // FireSharp thường trả về StatusCode OK ngay cả khi có lỗi logic (vd: permission denied nếu dùng rules)
                // nhưng kiểm tra OK là bước cơ bản nhất
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // 4. Ghi log lỗi chi tiết
                Console.WriteLine($"Lỗi khi lưu (Add/Update) user '{user.Username}': " + ex.Message);
                // Có thể xem xét log thêm ex.ToString() để có stack trace
                return false;
            }
        }

        /// <summary>
        /// Lấy thông tin một User từ Firebase dựa vào username.
        /// </summary>
        /// <param name="username">Username của User cần lấy.</param>
        /// <returns>Đối tượng Users nếu tìm thấy, null nếu không tìm thấy hoặc có lỗi.</returns>
        public async Task<Users> GetUser(string username)
        {
            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Lỗi: Username để lấy thông tin User không được để trống.");
                return null;
            }

            try
            {
                // 2. Gọi Firebase API
                FirebaseResponse response = await client.GetAsync("Users/" + username);

                // 3. Kiểm tra kết quả
                // Quan trọng: Phải kiểm tra cả StatusCode và Body != "null"
                if (response == null || response.StatusCode != System.Net.HttpStatusCode.OK || response.Body == "null")
                {
                    // Không tìm thấy user hoặc có lỗi kết nối/quyền -> trả về null
                    // Không cần log ở đây vì user không tồn tại không hẳn là lỗi
                    return null;
                }

                // 4. Parse kết quả thành đối tượng Users
                Users user = response.ResultAs<Users>();
                // Quan trọng: Gán lại username từ key vào object nếu object không tự chứa nó
                // (Tùy thuộc vào cách bạn định nghĩa lớp Users và cách lưu trên Firebase)
                if (user != null && string.IsNullOrEmpty(user.Username))
                {
                    user.Username = username;
                }
                return user;
            }
            catch (Exception ex)
            {
                // 5. Ghi log lỗi chi tiết
                Console.WriteLine($"Lỗi khi lấy user '{username}': " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Cập nhật thông tin một User hiện có trong Firebase.
        /// Lưu ý: Chỉ cập nhật các trường có trong đối tượng user được cung cấp.
        /// Nếu muốn ghi đè toàn bộ, hãy dùng AddOrUpdateUser.
        /// </summary>
        /// <param name="user">Đối tượng Users chứa thông tin cần cập nhật (phải có username).</param>
        /// <returns>True nếu thành công, False nếu có lỗi.</returns>
        public async Task<bool> UpdateUser(Users user)
        {
            // 1. Kiểm tra đầu vào
            if (user == null)
            {
                Console.WriteLine("Lỗi: Đối tượng User không được null khi cập nhật.");
                return false;
            }
            if (string.IsNullOrEmpty(user.Username))
            {
                Console.WriteLine("Lỗi: User username không được để trống khi cập nhật.");
                return false;
            }

            try
            {
                // 2. Gọi Firebase API (UpdateAsync chỉ cập nhật các trường có trong `user`)
                FirebaseResponse response = await client.UpdateAsync("Users/" + user.Username, user);

                // 3. Kiểm tra kết quả
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                // 4. Ghi log lỗi
                Console.WriteLine($"Lỗi khi cập nhật user '{user.Username}': " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Xóa một User khỏi Firebase dựa vào username.
        /// </summary>
        /// <param name="username">Username của User cần xóa.</param>
        /// <returns>True nếu xóa thành công, False nếu có lỗi hoặc user không tồn tại.</returns>
        public async Task<bool> DeleteUser(string username)
        {
            // 1. Kiểm tra đầu vào
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Lỗi: Username để xóa User không được để trống.");
                return false;
            }

            try
            {
                // 2. Gọi Firebase API
                FirebaseResponse response = await client.DeleteAsync("Users/" + username);

                // 3. Kiểm tra kết quả
                // DeleteAsync thành công ngay cả khi node không tồn tại, nó chỉ đảm bảo node đó không còn
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                // 4. Ghi log lỗi
                Console.WriteLine($"Lỗi khi xóa user '{username}': " + ex.Message);
                return false;
            }
        }


        public async Task<EventStreamResponse> ListenToPCChanges(string pcName, ValueChangedEventHandler handler)
        {
            if (client == null) return null;

            // Lắng nghe sự thay đổi trên node của PC cụ thể
            EventStreamResponse response = await client.OnAsync($"PCs/{pcName}",
                (sender, args, context) => { }, // Callback cho ValueAdded (giữ nguyên)
                handler,                      // THAY ĐỔI LẠI ĐÂY: Truyền handler trực tiếp
                (sender, args, context) => { }  // Callback cho ValueRemoved (giữ nguyên)
            );
            return response;
        }
        public async Task<bool> AddOrUpdateAdmin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin?.Username))
            {
                Console.WriteLine("Lỗi: Admin username không được để trống.");
                return false;
            }

            try
            {
                SetResponse response = await client.SetAsync("Admin/" + admin.Username, admin);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu admin '{admin.Username}': " + ex.Message);
                return false;
            }
        }

        public async Task<Admin> GetAdmin(string adminUsername)
        {
            if (string.IsNullOrEmpty(adminUsername)) return null;

            try
            {
                FirebaseResponse response = await client.GetAsync("Admin/" + adminUsername);
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return null;
                }
                Admin admin = response.ResultAs<Admin>();
                // Gán lại Username nếu cần
                if (admin != null && string.IsNullOrEmpty(admin.Username))
                {
                    admin.Username = adminUsername;
                }
                return admin;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy admin '{adminUsername}': " + ex.Message);
                return null;
            }
        }

        public async Task<bool> DeleteAdmin(string adminUsername)
        {
            if (string.IsNullOrEmpty(adminUsername)) return false;

            try
            {
                FirebaseResponse response = await client.DeleteAsync("Admin/" + adminUsername);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa admin '{adminUsername}': " + ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateAdmin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin?.Username))
            {
                Console.WriteLine("Lỗi: Admin username không được để trống khi cập nhật.");
                return false;
            }
            try
            {
                FirebaseResponse response = await client.UpdateAsync("Admin/" + admin.Username, admin);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật admin '{admin.Username}': " + ex.Message);
                return false;
            }
        }

        // Đây là các phương thức CRUD của Admin nghen 2 đứa kia

        public async Task<bool> AddOrUpdatePC(PC pc)
        {
            if (string.IsNullOrEmpty(pc?.Name))
            {
                Console.WriteLine("Lỗi: Tên PC không được để trống.");
                return false;
            }

            try
            {
                // Sử dụng tên PC làm khóa trong collection "PCs"
                SetResponse response = await client.SetAsync("PCs/" + pc.Name, pc);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu PC '{pc.Name}': " + ex.Message);
                return false;
            }
        }

        // Trong lớp FirebaseDB
        public async Task<PC> GetPC(string pcName)
        {
            if (string.IsNullOrEmpty(pcName)) return null;

            try
            {
                FirebaseResponse response = await client.GetAsync("PCs/" + pcName);
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return null;
                }
                PC pc = response.ResultAs<PC>();
                // Có thể cần gán lại Name nếu Firebase không tự điền vào object
                if (pc != null && string.IsNullOrEmpty(pc.Name))
                {
                    pc.Name = pcName; // Giả sử Name được lưu dưới dạng key
                }
                return pc;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy PC '{pcName}': " + ex.Message);
                return null;
            }
        }

        // Trong lớp FirebaseDB
        public async Task<List<PC>> GetAllPCs()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("PCs/");
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new List<PC>(); // Trả về danh sách rỗng nếu không có dữ liệu hoặc lỗi
                }

                // Firebase trả về Dictionary<string, PC> khi lấy toàn bộ node
                Dictionary<string, PC> pcsDictionary = response.ResultAs<Dictionary<string, PC>>();

                if (pcsDictionary == null)
                {
                    return new List<PC>();
                }

                // Chuyển Dictionary thành List và đảm bảo gán lại Name (key Firebase) vào object PC
                List<PC> pcList = new List<PC>();
                foreach (var item in pcsDictionary)
                {
                    PC pc = item.Value;
                    pc.Name = item.Key; // Gán key Firebase vào thuộc tính Name
                    pcList.Add(pc);
                }

                return pcList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả PC: " + ex.Message);
                return new List<PC>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }

        public async Task<bool> DeletePC(string pcName)
        {
            if (string.IsNullOrEmpty(pcName))
            {
                Console.WriteLine("Lỗi: Tên PC để xóa không được để trống.");
                return false;
            }

            try
            {
                // Gọi API để xóa node của PC cụ thể
                FirebaseResponse response = await client.DeleteAsync("PCs/" + pcName);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa PC '{pcName}': " + ex.Message);
                return false;
            }
        }

        public async Task<List<Users>> GetAllUsers()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Users/"); // Đường dẫn đến node Users
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new List<Users>();
                }

                Dictionary<string, Users> usersDictionary = response.ResultAs<Dictionary<string, Users>>();

                if (usersDictionary == null)
                {
                    return new List<Users>();
                }

                List<Users> userList = new List<Users>();
                foreach (var item in usersDictionary)
                {
                    Users user = item.Value;
                    // Username thường là key, nên có thể cần gán lại nếu model Users không tự chứa nó
                    // Hoặc đảm bảo Firebase lưu username bên trong object Users
                    if (string.IsNullOrEmpty(user.Username))
                    {
                        user.Username = item.Key;
                    }
                    userList.Add(user);
                }
                return userList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả User: " + ex.Message);
                return new List<Users>();
            }
        }


        public async Task<bool> AddOrder(Order order)
        {
            if (order == null || string.IsNullOrEmpty(order.OrderId))
            {
                Console.WriteLine("Lỗi: Đối tượng Order hoặc OrderId không hợp lệ.");
                return false;
            }

            try
            {
                // Lưu đơn hàng vào node "Orders" với OrderId làm khóa
                SetResponse response = await client.SetAsync("Orders/" + order.OrderId, order);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu đơn hàng '{order.OrderId}': " + ex.Message);
                return false;
            }
        }
        // Trong lớp FirebaseDB
        public async Task<List<Order>> GetAllOrders()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Orders/");
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new List<Order>();
                }
                Dictionary<string, Order> orders = response.ResultAs<Dictionary<string, Order>>();
                return orders?.Values.ToList() ?? new List<Order>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả Order: " + ex.Message);
                return new List<Order>();
            }
        }

        public async Task<PC> GetActivePCForUser(string username)
        {
            if (string.IsNullOrEmpty(username)) return null;

            try
            {
                var allPCs = await GetAllPCs();
                // Tìm PC có CurrentUser trùng với username và đang trong trạng thái InUse
                return allPCs.FirstOrDefault(pc => pc.CurrentUser == username && pc.Status == PCStatus.InUse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm PC cho người dùng '{username}': {ex.Message}");
                return null;
            }
        }


        public async Task<List<Order>> GetOrdersForUser(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Username không được để trống khi lấy danh sách order.");
                return new List<Order>();
            }

            try
            {
                // Lấy tất cả các order từ Firebase bằng phương thức đã có
                List<Order> allOrders = await GetAllOrders();

                // Dùng LINQ để lọc danh sách, chỉ giữ lại những order của người dùng được chỉ định
                List<Order> userOrders = allOrders
                                            .Where(order => string.Equals(order.Username, username, StringComparison.OrdinalIgnoreCase))
                                            .ToList();

                return userOrders;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy order cho người dùng '{username}': " + ex.Message);
                return new List<Order>(); // Trả về danh sách rỗng nếu có lỗi
            }
        }

        public async Task<bool> UpdateOrderStatus(string orderId, string newStatus)
        {
            if (string.IsNullOrEmpty(orderId)) return false;
            try
            {
                var path = $"Orders/{orderId}/Status";
                FirebaseResponse response = await client.SetAsync(path, newStatus);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật trạng thái cho Order ID '{orderId}': " + ex.Message);
                return false;
            }
        }

        public async Task<bool> AddOrUpdateItem(Item item)
        {
            if (item == null || string.IsNullOrEmpty(item.Id))
            {
                Console.WriteLine("Lỗi: Đối tượng Item hoặc Item.Id không được null/trống.");
                return false;
            }

            try
            {
                SetResponse response = await client.SetAsync("Items/" + item.Id, item);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu (Add/Update) Item '{item.Id}': " + ex.Message);
                return false;
            }
        }

        public async Task<Item> GetItem(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
            {
                Console.WriteLine("Lỗi: ItemId để lấy thông tin Item không được để trống.");
                return null;
            }

            try
            {
                FirebaseResponse response = await client.GetAsync("Items/" + itemId);
                if (response == null || response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return null;
                }
                Item item = response.ResultAs<Item>();
                if (item != null && string.IsNullOrEmpty(item.Id))
                {
                    item.Id = itemId; // Gán lại Id từ key Firebase
                }
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy Item '{itemId}': " + ex.Message);
                return null;
            }
        }

        public async Task<List<Item>> GetAllItems()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Items/");
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new List<Item>();
                }

                Dictionary<string, Item> itemsDictionary = response.ResultAs<Dictionary<string, Item>>();

                if (itemsDictionary == null)
                {
                    return new List<Item>();
                }

                List<Item> itemList = new List<Item>();
                foreach (var entry in itemsDictionary)
                {
                    Item item = entry.Value;
                    if (string.IsNullOrEmpty(item.Id))
                    {
                        item.Id = entry.Key; // Đảm bảo Id được gán từ key Firebase
                    }
                    itemList.Add(item);
                }
                return itemList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả Items: " + ex.Message);
                return new List<Item>();
            }
        }

        public async Task<bool> DeleteItem(string itemId)
        {
            if (string.IsNullOrEmpty(itemId))
            {
                Console.WriteLine("Lỗi: ItemId để xóa Item không được để trống.");
                return false;
            }

            try
            {
                FirebaseResponse response = await client.DeleteAsync("Items/" + itemId);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa Item '{itemId}': " + ex.Message);
                return false;
            }
        }

        #region Chat and PC Status Methods

        /// <summary>
        /// Gửi một tin nhắn mới và lưu vào Firebase.
        /// </summary>
        public async Task<bool> SendMessage(ChatMessage message)
        {
            if (message == null || string.IsNullOrEmpty(message.MessageId)) return false;
            try
            {
                SetResponse response = await client.SetAsync("Messages/" + message.MessageId, message);
                return (response.StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi tin nhắn: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Lấy tất cả tin nhắn từ Firebase.
        /// </summary>
        public async Task<List<ChatMessage>> GetAllMessages()
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("Messages/");
                if (response.Body == "null" || response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new List<ChatMessage>();
                }
                Dictionary<string, ChatMessage> messages = response.ResultAs<Dictionary<string, ChatMessage>>();
                return messages?.Values.ToList() ?? new List<ChatMessage>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả tin nhắn: " + ex.Message);
                return new List<ChatMessage>();
            }
        }

        /// <summary>
        /// Đánh dấu một tin nhắn là đã đọc.
        /// </summary>
        public async Task<bool> MarkMessageAsRead(string messageId)
        {
            if (string.IsNullOrEmpty(messageId)) return false;
            try
            {
                var path = $"Messages/{messageId}/IsRead";
                FirebaseResponse response = await client.SetAsync(path, true);
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật trạng thái tin nhắn '{messageId}': " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Lấy tên PC mà một người dùng cụ thể đang sử dụng.
        /// </summary>

        public async Task<string> GetPCNameForUser(string username)
        {
            if (string.IsNullOrEmpty(username)) return null;
            try
            {
                var allPCs = await GetAllPCs();
                var activePC = allPCs.FirstOrDefault(pc => pc.CurrentUser == username && pc.Status == PCStatus.InUse);
                return activePC?.Name;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tìm PC cho người dùng '{username}': {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả các PC đang có người dùng.
        /// </summary>
        public async Task<List<PC>> GetOnlinePCs()
        {
            try
            {
                var allPCs = await GetAllPCs();
                return allPCs.Where(pc => !string.IsNullOrEmpty(pc.CurrentUser) && pc.Status == PCStatus.InUse).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách PC online: {ex.Message}");
                return new List<PC>();
            }
        }

        #endregion
    }
}
   