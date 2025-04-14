using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Display_Home.Show();
            Display_Food.Hide();
            Display_Drink.Hide();
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
            Display_Food.Show();
            Display_Home.Hide();
            Display_Drink.Hide();
        }

        private void btn_Drink_Click(object sender, EventArgs e)
        {
            Display_Drink.Show();
            Display_Home.Hide();
            Display_Food.Hide();
        }
    }
}
