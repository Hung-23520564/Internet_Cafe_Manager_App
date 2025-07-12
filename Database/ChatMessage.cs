// Trong file: Database/ChatMessage.cs
using Newtonsoft.Json;
using System;

namespace Internet_Cafe_Manager_App.Database
{
    public class ChatMessage
    {
        [JsonProperty("MessageId")]
        public string MessageId { get; set; }

        [JsonProperty("Sender")]
        public string Sender { get; set; } // Có thể là "Admin" hoặc tên máy (ví dụ: "PC1")

        [JsonProperty("Receiver")]
        public string Receiver { get; set; } // Có thể là "Admin" hoặc tên máy

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("IsRead")]
        public bool IsRead { get; set; }
    }
}