using FontAwesome.Sharp;
using Internet_Cafe_Manager_App.UI.User;
using Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.UI.Admin
{
    public partial class Form_UserMainDashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private readonly Internet_Cafe_Manager_App.Database.Users currentUser;

        public Form_UserMainDashboard()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            panelMenu.Controls.Add(leftBorderBtn);

            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            // Đăng ký các sự kiện chính
            this.Load += Form_UserMainDashboard_Load;
            this.FormClosed += Form_UserMacDinh_FormClosed;
        }

        public Form_UserMainDashboard(Internet_Cafe_Manager_App.Database.Users user)
        {
            InitializeComponent();
            this.currentUser = user;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            panelMenu.Controls.Add(leftBorderBtn);
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            // Đăng ký các sự kiện chính
            this.Load += Form_UserMainDashboard_Load;
            this.FormClosed += Form_UserMacDinh_FormClosed;
        }

        #region System Lockdown Utilities

        private void DisableTaskManager()
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (regkey != null)
                {
                    regkey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                    regkey.Close();
                }
            }
            catch (Exception ex) { Console.WriteLine("Failed to disable Task Manager: " + ex.Message); }
        }

        private void EnableTaskManager()
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
                if (regkey != null)
                {
                    regkey.DeleteValue("DisableTaskMgr", false);
                    regkey.Close();
                }
            }
            catch (Exception ex) { Console.WriteLine("Failed to enable Task Manager: " + ex.Message); }
        }

        #endregion

        #region Low-Level Keyboard Hook

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        private static LowLevelKeyboardProc _proc;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                bool isKeyDown = (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN);
                if (isKeyDown)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    Keys key = (Keys)vkCode;

                    bool ctrlPressed = (GetKeyState(0x11) & 0x8000) != 0;
                    bool altPressed = (GetKeyState(0x12) & 0x8000) != 0;
                    bool shiftPressed = (GetKeyState(0x10) & 0x8000) != 0;

                    //if (ctrlPressed && shiftPressed && key == Keys.Escape) return (IntPtr)1;
                    //if (key == Keys.LWin || key == Keys.RWin) return (IntPtr)1;

                    //if (altPressed && key == Keys.F4)
                    //{
                    //    if (GetForegroundWindow() == this.Handle)
                    //    {
                    //        return (IntPtr)1;
                    //    }
                   // }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private void SetHook()
        {
            _proc = HookCallback;
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                _hookID = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private void Unhook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_CLOSE = 0x0010;
            if (m.Msg == WM_CLOSE)
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void Form_UserMainDashboard_Load(object sender, EventArgs e)
        {
            DisableTaskManager();
            SetHook();
        }

        private void Form_UserMacDinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableTaskManager();
            Unhook();
            Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Form_InitialChoice form_InitialChoice = new Form_InitialChoice();
                form_InitialChoice.Show();
                this.Close();
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
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
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Form_UserInfo(this.currentUser));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Form_UserOrder(this.currentUser));
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Form_UserChat(this.currentUser));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Form_UserPayment(this.currentUser));
        }

        private void Form_UserMacDinh_Shown(object sender, EventArgs e)
        {
            // Empty
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}