using FireSharp.EventStreaming;
using FireSharp.Response;
using Internet_Cafe_Manager_App.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.Database;

namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    public partial class Form_UserInfo : Form
    {
        private Database.Users currentUser;
        private readonly FirebaseDB firebaseDB;
        private List<Order> transactionList;

        private System.Windows.Forms.Timer userInfoTimer; // Đã khai báo

        private PC activePC;
        private FireSharp.Response.EventStreamResponse pcListener;

        public Form_UserInfo(Database.Users user)
        {
            InitializeComponent();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
    }
}