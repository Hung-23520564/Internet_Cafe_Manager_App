using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private async void btnAddItem_Click(object sender, EventArgs e) 
        {
            Form_AddItemInfo additeminfo = new Form_AddItemInfo();
            additeminfo.Show();
        }

    }
}
