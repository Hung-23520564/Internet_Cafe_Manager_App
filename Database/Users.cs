using System;
using System.Collections.Generic;
using Newtonsoft.Json; // <-- Thêm dòng này

namespace Internet_Cafe_Manager_App.Database
{
    public class Users
    {
        [JsonProperty("UserId")]
        public string UserId { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("PasswordHash")]
        public string PasswordHash { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("PhoneNumber")]
        public string PhoneNumber { get; set; }

        // Đề xuất đổi tên thành AccountBalance để rõ nghĩa hơn
        [JsonProperty("Budget")]
        public decimal Budget { get; set; } 

        [JsonProperty("IsUserActive")]
        public bool IsUserActive { get; set; }

        [JsonProperty("CreationTimestamp")]
        public DateTime CreationTimestamp { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        [JsonProperty("LastLoginTimestamp")]
        public DateTime? LastLoginTimestamp { get; set; }

        [JsonProperty("TotalMoneyDeposited")]
        public decimal TotalMoneyDeposited { get; set; }

        [JsonProperty("TotalTimePlayed")]
        public TimeSpan TotalTimePlayed { get; set; }

        [JsonProperty("OrderIds")]
        public List<string> OrderIds { get; set; }

        public Users()
        {
            OrderIds = new List<string>();
            TotalTimePlayed = TimeSpan.Zero;
        }
    }
}