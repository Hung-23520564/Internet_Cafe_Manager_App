using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_Cafe_Manager_App.Database
{
    internal class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public int quantity { get; set; }
        public string url { get; set; }

        public int price { get; set; }

        public Item() { }
    }
}
