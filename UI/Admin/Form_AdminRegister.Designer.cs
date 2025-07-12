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
            panelMain = new Panel();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            panelConfirmPasswordUnderline = new Panel();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            panelPasswordUnderline = new Panel();
            txtPassword = new TextBox();
            label3 = new Label();
            panelPhoneNumberUnderline = new Panel();
            txtPhoneNumber = new TextBox();
            label7 = new Label();
            panelEmailUnderline = new Panel();
            txtEmail = new TextBox();
            label6 = new Label();
            panelUsernameUnderline = new Panel();
            txtAdminAccount = new TextBox();
            label1 = new Label();
            panelFullNameUnderline = new Panel();
            txtFullName = new TextBox();
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
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(panelConfirmPasswordUnderline);
            panelMain.Controls.Add(txtConfirmPassword);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(panelPasswordUnderline);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(panelPhoneNumberUnderline);
            panelMain.Controls.Add(txtPhoneNumber);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(panelEmailUnderline);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(panelUsernameUnderline);
            panelMain.Controls.Add(txtAdminAccount);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(panelFullNameUnderline);
            panelMain.Controls.Add(txtFullName);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(picLogo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(560, 1055);
            panelMain.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(253, 138, 114);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(147, 1100);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(219, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Login";
            linkLabel1.LinkClicked += llbBackToLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(253, 138, 114);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(80, 1000);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(400, 77);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "CREATE ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelConfirmPasswordUnderline
            // 
            panelConfirmPasswordUnderline.BackColor = Color.WhiteSmoke;
            panelConfirmPasswordUnderline.Location = new Point(80, 923);
            panelConfirmPasswordUnderline.Margin = new Padding(4, 5, 4, 5);
            panelConfirmPasswordUnderline.Name = "panelConfirmPasswordUnderline";
            panelConfirmPasswordUnderline.Size = new Size(400, 2);
            panelConfirmPasswordUnderline.TabIndex = 20;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(31, 32, 71);
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.ForeColor = Color.White;
            txtConfirmPassword.Location = new Point(80, 880);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(400, 27);
            txtConfirmPassword.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(75, 831);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 18;
            label5.Text = "Confirm Password";
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.WhiteSmoke;
            panelPasswordUnderline.Location = new Point(80, 800);
            panelPasswordUnderline.Margin = new Padding(4, 5, 4, 5);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(400, 2);
            panelPasswordUnderline.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(31, 32, 71);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(80, 757);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 27);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(75, 708);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // panelPhoneNumberUnderline
            // 
            panelPhoneNumberUnderline.BackColor = Color.WhiteSmoke;
            panelPhoneNumberUnderline.Location = new Point(80, 677);
            panelPhoneNumberUnderline.Margin = new Padding(4, 5, 4, 5);
            panelPhoneNumberUnderline.Name = "panelPhoneNumberUnderline";
            panelPhoneNumberUnderline.Size = new Size(400, 2);
            panelPhoneNumberUnderline.TabIndex = 14;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(31, 32, 71);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtPhoneNumber.ForeColor = Color.White;
            txtPhoneNumber.Location = new Point(80, 634);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(400, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(75, 585);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 12;
            label7.Text = "Phone Number";
            // 
            // panelEmailUnderline
            // 
            panelEmailUnderline.BackColor = Color.WhiteSmoke;
            panelEmailUnderline.Location = new Point(80, 569);
            panelEmailUnderline.Margin = new Padding(4, 5, 4, 5);
            panelEmailUnderline.Name = "panelEmailUnderline";
            panelEmailUnderline.Size = new Size(400, 2);
            panelEmailUnderline.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(31, 32, 71);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(80, 526);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 27);
            txtEmail.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(75, 477);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // panelUsernameUnderline
            // 
            panelUsernameUnderline.BackColor = Color.WhiteSmoke;
            panelUsernameUnderline.Location = new Point(80, 462);
            panelUsernameUnderline.Margin = new Padding(4, 5, 4, 5);
            panelUsernameUnderline.Name = "panelUsernameUnderline";
            panelUsernameUnderline.Size = new Size(400, 2);
            panelUsernameUnderline.TabIndex = 8;
            // 
            // txtAdminAccount
            // 
            txtAdminAccount.BackColor = Color.FromArgb(31, 32, 71);
            txtAdminAccount.BorderStyle = BorderStyle.None;
            txtAdminAccount.Font = new Font("Segoe UI", 12F);
            txtAdminAccount.ForeColor = Color.White;
            txtAdminAccount.Location = new Point(80, 418);
            txtAdminAccount.Margin = new Padding(4, 5, 4, 5);
            txtAdminAccount.Name = "txtAdminAccount";
            txtAdminAccount.Size = new Size(400, 27);
            txtAdminAccount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(75, 369);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 6;
            label1.Text = "Admin Account";
            // 
            // panelFullNameUnderline
            // 
            panelFullNameUnderline.BackColor = Color.WhiteSmoke;
            panelFullNameUnderline.Location = new Point(80, 354);
            panelFullNameUnderline.Margin = new Padding(4, 5, 4, 5);
            panelFullNameUnderline.Name = "panelFullNameUnderline";
            panelFullNameUnderline.Size = new Size(400, 2);
            panelFullNameUnderline.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(31, 32, 71);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(80, 311);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 27);
            txtFullName.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(75, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 3;
            label4.Text = "Full Name";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 21;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(31, 32, 71);
            picLogo.ForeColor = SystemColors.ControlText;
            picLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            picLogo.IconColor = SystemColors.ControlText;
            picLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picLogo.IconSize = 43;
            picLogo.Location = new Point(0, 0);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(43, 49);
            picLogo.TabIndex = 22;
            picLogo.TabStop = false;
            // 
            // Form_AdminRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 1055);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_AdminRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Register";
            FormClosed += Form_AdminRegister_FormClosed_1;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel panelFullNameUnderline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminAccount;
        private System.Windows.Forms.Panel panelUsernameUnderline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panelEmailUnderline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panelPhoneNumberUnderline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelPasswordUnderline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panelConfirmPasswordUnderline;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
