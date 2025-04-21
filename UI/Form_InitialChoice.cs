using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.UI.Admin;

namespace Internet_Cafe_Manager_App.UI
{
    public partial class Form_InitialChoice : Form 
    {
        public Form_InitialChoice()
        {
            InitializeComponent();
        }

        private void btnChooseAdmin_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng của Form đăng nhập Admin
            Form_AdminLogin adminLoginForm = new Form_AdminLogin();

            // Hiển thị form đăng nhập Admin
            adminLoginForm.Show();

            // Ẩn form chọn vai trò hiện tại đi
            this.Hide();
        }

        //private void btnChooseUser_Click(object sender, EventArgs e)
        //{
            // Tạo một đối tượng của Form đăng nhập User
        //    Form_UserLogin adminLoginForm = new Form_UserLogin();

            // Hiển thị form đăng nhập User
        //    adminLoginForm.Show();

            // Ẩn form chọn vai trò hiện tại đi
        //    this.Hide();
        

    }
}
