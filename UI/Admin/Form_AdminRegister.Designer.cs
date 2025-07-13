namespace Internet_Cafe_Manager_App.UI.Admin
{
    partial class Form_AdminRegister
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.llbBackToLogin = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panelConfirmPasswordUnderline = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.iconConfirmPassword = new FontAwesome.Sharp.IconPictureBox();
            this.panelPasswordUnderline = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.panelPhoneUnderline = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.iconPhone = new FontAwesome.Sharp.IconPictureBox();
            this.panelEmailUnderline = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.iconEmail = new FontAwesome.Sharp.IconPictureBox();
            this.panelUsernameUnderline = new System.Windows.Forms.Panel();
            this.txtAdminAccount = new System.Windows.Forms.TextBox();
            this.iconUsername = new FontAwesome.Sharp.IconPictureBox();
            this.panelFullNameUnderline = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.iconFullName = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.picLogo = new FontAwesome.Sharp.IconPictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panelMain.Controls.Add(this.llbBackToLogin);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Controls.Add(this.panelConfirmPasswordUnderline);
            this.panelMain.Controls.Add(this.txtConfirmPassword);
            this.panelMain.Controls.Add(this.iconConfirmPassword);
            this.panelMain.Controls.Add(this.panelPasswordUnderline);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.iconPassword);
            this.panelMain.Controls.Add(this.panelPhoneUnderline);
            this.panelMain.Controls.Add(this.txtPhoneNumber);
            this.panelMain.Controls.Add(this.iconPhone);
            this.panelMain.Controls.Add(this.panelEmailUnderline);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.iconEmail);
            this.panelMain.Controls.Add(this.panelUsernameUnderline);
            this.panelMain.Controls.Add(this.txtAdminAccount);
            this.panelMain.Controls.Add(this.iconUsername);
            this.panelMain.Controls.Add(this.panelFullNameUnderline);
            this.panelMain.Controls.Add(this.txtFullName);
            this.panelMain.Controls.Add(this.iconFullName);
            this.panelMain.Controls.Add(this.labelTitle);
            this.panelMain.Controls.Add(this.picLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 700);
            this.panelMain.TabIndex = 0;
            // 
            // llbBackToLogin
            // 
            this.llbBackToLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.llbBackToLogin.AutoSize = true;
            this.llbBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.llbBackToLogin.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.llbBackToLogin.Location = new System.Drawing.Point(140, 650);
            this.llbBackToLogin.Name = "llbBackToLogin";
            this.llbBackToLogin.Size = new System.Drawing.Size(200, 15);
            this.llbBackToLogin.TabIndex = 7;
            this.llbBackToLogin.TabStop = true;
            this.llbBackToLogin.Text = "Already have an account? Login";
            this.llbBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBackToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(90, 580);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "CREATE ACCOUNT";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panelConfirmPasswordUnderline
            // 
            this.panelConfirmPasswordUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConfirmPasswordUnderline.Location = new System.Drawing.Point(90, 535);
            this.panelConfirmPasswordUnderline.Name = "panelConfirmPasswordUnderline";
            this.panelConfirmPasswordUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelConfirmPasswordUnderline.TabIndex = 22;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 505);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(260, 22);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // iconConfirmPassword
            // 
            this.iconConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconConfirmPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.iconConfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfirmPassword.IconSize = 24;
            this.iconConfirmPassword.Location = new System.Drawing.Point(90, 503);
            this.iconConfirmPassword.Name = "iconConfirmPassword";
            this.iconConfirmPassword.Size = new System.Drawing.Size(24, 24);
            this.iconConfirmPassword.TabIndex = 20;
            this.iconConfirmPassword.TabStop = false;
            // 
            // panelPasswordUnderline
            // 
            this.panelPasswordUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPasswordUnderline.Location = new System.Drawing.Point(90, 475);
            this.panelPasswordUnderline.Name = "panelPasswordUnderline";
            this.panelPasswordUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelPasswordUnderline.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Location = new System.Drawing.Point(130, 445);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 24;
            this.iconPassword.Location = new System.Drawing.Point(90, 443);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(24, 24);
            this.iconPassword.TabIndex = 17;
            this.iconPassword.TabStop = false;
            // 
            // panelPhoneUnderline
            // 
            this.panelPhoneUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPhoneUnderline.Location = new System.Drawing.Point(90, 415);
            this.panelPhoneUnderline.Name = "panelPhoneUnderline";
            this.panelPhoneUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelPhoneUnderline.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhoneNumber.Location = new System.Drawing.Point(130, 385);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(260, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // iconPhone
            // 
            this.iconPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPhone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPhone.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPhone.IconSize = 24;
            this.iconPhone.Location = new System.Drawing.Point(90, 383);
            this.iconPhone.Name = "iconPhone";
            this.iconPhone.Size = new System.Drawing.Size(24, 24);
            this.iconPhone.TabIndex = 14;
            this.iconPhone.TabStop = false;
            // 
            // panelEmailUnderline
            // 
            this.panelEmailUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEmailUnderline.Location = new System.Drawing.Point(90, 355);
            this.panelEmailUnderline.Name = "panelEmailUnderline";
            this.panelEmailUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelEmailUnderline.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(130, 325);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // iconEmail
            // 
            this.iconEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconEmail.IconColor = System.Drawing.Color.Gainsboro;
            this.iconEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEmail.IconSize = 24;
            this.iconEmail.Location = new System.Drawing.Point(90, 323);
            this.iconEmail.Name = "iconEmail";
            this.iconEmail.Size = new System.Drawing.Size(24, 24);
            this.iconEmail.TabIndex = 11;
            this.iconEmail.TabStop = false;
            // 
            // panelUsernameUnderline
            // 
            this.panelUsernameUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsernameUnderline.Location = new System.Drawing.Point(90, 295);
            this.panelUsernameUnderline.Name = "panelUsernameUnderline";
            this.panelUsernameUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelUsernameUnderline.TabIndex = 10;
            // 
            // txtAdminAccount
            // 
            this.txtAdminAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtAdminAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAdminAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdminAccount.Location = new System.Drawing.Point(130, 265);
            this.txtAdminAccount.Name = "txtAdminAccount";
            this.txtAdminAccount.PlaceholderText = "Username";
            this.txtAdminAccount.Size = new System.Drawing.Size(260, 22);
            this.txtAdminAccount.TabIndex = 1;
            // 
            // iconUsername
            // 
            this.iconUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUsername.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 24;
            this.iconUsername.Location = new System.Drawing.Point(90, 263);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(24, 24);
            this.iconUsername.TabIndex = 8;
            this.iconUsername.TabStop = false;
            // 
            // panelFullNameUnderline
            // 
            this.panelFullNameUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFullNameUnderline.Location = new System.Drawing.Point(90, 235);
            this.panelFullNameUnderline.Name = "panelFullNameUnderline";
            this.panelFullNameUnderline.Size = new System.Drawing.Size(300, 1);
            this.panelFullNameUnderline.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullName.Location = new System.Drawing.Point(130, 205);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "Full Name";
            this.txtFullName.Size = new System.Drawing.Size(260, 22);
            this.txtFullName.TabIndex = 0;
            // 
            // iconFullName
            // 
            this.iconFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.iconFullName.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconFullName.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconFullName.IconColor = System.Drawing.Color.Gainsboro;
            this.iconFullName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFullName.IconSize = 24;
            this.iconFullName.Location = new System.Drawing.Point(90, 203);
            this.iconFullName.Name = "iconFullName";
            this.iconFullName.Size = new System.Drawing.Size(24, 24);
            this.iconFullName.TabIndex = 5;
            this.iconFullName.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(155, 120);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 45);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "REGISTER";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.picLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.picLogo.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.picLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.picLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picLogo.IconSize = 80;
            this.picLogo.Location = new System.Drawing.Point(200, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // Form_AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 700);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AdminRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_AdminRegister_FormClosed);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox picLogo;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panelFullNameUnderline;
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.TextBox txtAdminAccount;
        private FontAwesome.Sharp.IconPictureBox iconUsername;
        private System.Windows.Forms.Panel panelEmailUnderline;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconPictureBox iconEmail;
        private System.Windows.Forms.Panel panelPhoneUnderline;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private FontAwesome.Sharp.IconPictureBox iconPhone;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private System.Windows.Forms.Panel panelConfirmPasswordUnderline;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private FontAwesome.Sharp.IconPictureBox iconConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel llbBackToLogin;
    }
}