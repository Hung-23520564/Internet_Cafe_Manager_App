namespace Internet_Cafe_Manager_App.UI.Admin
{
    partial class Form_AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 34);
            label2.Name = "label2";
            label2.Size = new Size(259, 60);
            label2.TabIndex = 6;
            label2.Text = "Đăng Nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 223);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 128);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(110, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 55);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(130, 461);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bạn chưa có tài khoản ?";
            linkLabel1.LinkClicked += llblRegister_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(71, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 27);
            txtUsername.TabIndex = 15;
            txtUsername.KeyDown += TxtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(71, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 16;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            // 
            // Form_AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 75, 109);
            ClientSize = new Size(439, 703);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form_AdminLogin";
            Text = "AdminLogin";
            FormClosed += Form_AdminLogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}