using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Internet_Cafe_Manager_App.Database
{
    /// <summary>
    /// Định nghĩa các loại giao dịch.
    /// PcUsage: Giao dịch nạp tiền, sử dụng máy.
    /// FoodOrder: Giao dịch gọi món ăn, thức uống.
    /// </summary>
    public enum TransactionType
    {
        PcUsage,
        FoodOrder
    }

    /// <summary>
    /// Lớp Order đã được nâng cấp để quản lý tất cả các loại giao dịch.
    /// </summary>
    public class Order
    {
        [JsonProperty("OrderId")]
        public string OrderId { get; set; }

        [JsonProperty("UserID")]
        public string UserID { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("UserFullName")]
        public string UserFullName { get; set; }

        [JsonProperty("GrandTotal")]
        public decimal GrandTotal { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Type")]
        public TransactionType Type { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("TimePurchased")]
        public TimeSpan? TimePurchased { get; set; }

        [JsonProperty("Items")]
        public List<CartItemEntry> Items { get; set; }

        // Constructor để khởi tạo giá trị mặc định
        public Order()
        {
            Items = new List<CartItemEntry>();
        }
    }
}