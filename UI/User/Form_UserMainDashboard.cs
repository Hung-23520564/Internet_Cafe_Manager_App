using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard;

namespace Internet_Cafe_Manager_App.UI.User
{
    public partial class Form_UserMainDashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form_UserMainDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(51, 0, 102); // màu active
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(75, 0, 130); // màu nền chung
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Form_UserOrder());
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Form_UserPayment());
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Form_UserChat());
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?!?", "Thông báo!?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form_InitialChoice form_InitialChoice = new Form_InitialChoice();
                form_InitialChoice.ShowDialog();
                Close();
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Form_AdminMainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Form_UserInfo());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
