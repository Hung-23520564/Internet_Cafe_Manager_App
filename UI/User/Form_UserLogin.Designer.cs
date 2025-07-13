namespace Internet_Cafe_Manager_App.UI.User
{
    partial class Form_UserLogin
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
            llblRegister = new LinkLabel();
            btnLogin = new Button();
            btnTogglePassword = new FontAwesome.Sharp.IconButton();
            panelPasswordUnderline = new Panel();
            txtPassword = new TextBox();
            iconPassword = new FontAwesome.Sharp.IconPictureBox();
            panelUsernameUnderline = new Panel();
            txtUsername = new TextBox();
            iconUsername = new FontAwesome.Sharp.IconPictureBox();
            labelTitle = new Label();
            picLogo = new FontAwesome.Sharp.IconPictureBox();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(31, 32, 71);
            panelMain.Controls.Add(llblRegister);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(btnTogglePassword);
            panelMain.Controls.Add(panelPasswordUnderline);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(iconPassword);
            panelMain.Controls.Add(panelUsernameUnderline);
            panelMain.Controls.Add(txtUsername);
            panelMain.Controls.Add(iconUsername);
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(picLogo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(560, 846);
            panelMain.TabIndex = 0;
            
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 179, 255);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(80, 646);
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
            btnTogglePassword.Location = new Point(440, 511);
            btnTogglePassword.Margin = new Padding(4, 5, 4, 5);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(40, 46);
            btnTogglePassword.TabIndex = 2;
            btnTogglePassword.UseVisualStyleBackColor = true;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.WhiteSmoke;
            panelPasswordUnderline.Location = new Point(80, 566);
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
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(133, 520);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(299, 27);
            txtPassword.TabIndex = 1;
            // 
            // iconPassword
            // 
            iconPassword.BackColor = Color.FromArgb(31, 32, 71);
            iconPassword.ForeColor = Color.Gainsboro;
            iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPassword.IconColor = Color.Gainsboro;
            iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPassword.Location = new Point(80, 517);
            iconPassword.Margin = new Padding(4, 5, 4, 5);
            iconPassword.Name = "iconPassword";
            iconPassword.Size = new Size(32, 37);
            iconPassword.TabIndex = 6;
            iconPassword.TabStop = false;
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.BackColor = Color.WhiteSmoke;
            panelUsernameUnderline.Location = new Point(80, 458);
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
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtUsername.Location = new Point(133, 412);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(347, 27);
            txtUsername.TabIndex = 0;
            // 
            // iconUsername
            // 
            iconUsername.BackColor = Color.FromArgb(31, 32, 71);
            iconUsername.ForeColor = Color.Gainsboro;
            iconUsername.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconUsername.IconColor = Color.Gainsboro;
            iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsername.Location = new Point(80, 409);
            iconUsername.Margin = new Padding(4, 5, 4, 5);
            iconUsername.Name = "iconUsername";
            iconUsername.Size = new Size(32, 37);
            iconUsername.TabIndex = 3;
            iconUsername.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(201, 246);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(145, 54);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "LOGIN";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(31, 32, 71);
            picLogo.ForeColor = Color.FromArgb(128, 179, 255);
            picLogo.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            picLogo.IconColor = Color.FromArgb(128, 179, 255);
            picLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picLogo.IconSize = 107;
            picLogo.Location = new Point(218, 94);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(107, 123);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // Form_UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 846);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Login";
            FormClosed += Form_UserLogin_FormClosed;
            Load += Form_UserLogin_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox picLogo;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconUsername;
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.TextBox txtUsername;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnTogglePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llblRegister;
    }
}