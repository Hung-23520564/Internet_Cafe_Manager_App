namespace Internet_Cafe_Manager_App.UI.Admin
{
    partial class Form_AdminLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            btnTogglePassword = new FontAwesome.Sharp.IconButton();
            panelPasswordUnderline = new Panel();
            txtPassword = new TextBox();
            label1 = new Label();
            panelUsernameUnderline = new Panel();
            txtUsername = new TextBox();
            label4 = new Label();
            label2 = new Label();
            picLogo = new FontAwesome.Sharp.IconPictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(31, 32, 71);
            panelMain.Controls.Add(linkLabel1);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(btnTogglePassword);
            panelMain.Controls.Add(panelPasswordUnderline);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(panelUsernameUnderline);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(picLogo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(560, 892);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(128, 179, 255);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(153, 800);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(221, 20);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Register";
            linkLabel1.LinkClicked += llblRegister_LinkClicked;
            // 
            // txtUsername
            // 
            btnLogin.BackColor = Color.FromArgb(128, 179, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 677);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 77);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btnTogglePassword.IconColor = Color.Gainsboro;
            btnTogglePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTogglePassword.IconSize = 24;
            btnTogglePassword.Location = new Point(440, 551);
            btnTogglePassword.Margin = new Padding(4, 5, 4, 5);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(40, 46);
            btnTogglePassword.TabIndex = 2;
            btnTogglePassword.UseVisualStyleBackColor = true;
            btnTogglePassword.Click += btnTogglePassword_Click;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.WhiteSmoke;
            panelPasswordUnderline.Location = new Point(80, 600);
            panelPasswordUnderline.Margin = new Padding(4, 5, 4, 5);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(400, 2);
            panelPasswordUnderline.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(31, 32, 71);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(80, 557);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(75, 508);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.BackColor = Color.WhiteSmoke;
            panelUsernameUnderline.Location = new Point(80, 446);
            panelUsernameUnderline.Margin = new Padding(4, 5, 4, 5);
            panelUsernameUnderline.Name = "panelUsernameUnderline";
            panelUsernameUnderline.Size = new Size(400, 2);
            panelUsernameUnderline.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(31, 32, 71);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(80, 403);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 27);
            txtUsername.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(75, 354);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 246);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 54);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(31, 32, 71);
            picLogo.ForeColor = Color.FromArgb(128, 179, 255);
            picLogo.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            picLogo.IconColor = Color.FromArgb(128, 179, 255);
            picLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picLogo.IconSize = 107;
            picLogo.Location = new Point(227, 92);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(107, 123);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // Form_AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 892);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            FormClosed += Form_AdminLogin_FormClosed_1;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTogglePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
