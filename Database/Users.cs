using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NET.Entity
{
    public class Users
    {
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public int Budget { get; set; }
        public bool isavailable { get; set; }

        public Users() { }
    }




}