namespace Internet_Cafe_Manager_App.UI.Admin
{
    partial class Form_AdminRegister
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
            txtAdminAccount = new TextBox();
            txtFullName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            btnRegister = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtAdminAccount
            // 
            txtAdminAccount.Location = new Point(77, 281);
            txtAdminAccount.Name = "txtAdminAccount";
            txtAdminAccount.Size = new Size(280, 27);
            txtAdminAccount.TabIndex = 23;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(77, 190);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(280, 27);
            txtFullName.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 146);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 19;
            label4.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 236);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 18;
            label1.Text = "Admin Account ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 56);
            label2.Name = "label2";
            label2.Size = new Size(198, 60);
            label2.TabIndex = 17;
            label2.Text = "Đăng Ký";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(77, 466);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 27);
            txtConfirmPassword.TabIndex = 27;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 375);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 331);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(80, 421);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 24;
            label5.Text = "Confirm Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 560);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(80, 516);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 29;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(80, 606);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 28;
            label7.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(77, 651);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(280, 27);
            txtPhoneNumber.TabIndex = 31;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 192, 192);
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(88, 736);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(258, 65);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Tạo tài khoản";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(80, 847);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(274, 20);
            linkLabel1.TabIndex = 32;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bạn đã có tài khoản, quay lại đăng nhập";
            linkLabel1.LinkClicked += llbBackToLogin_Click;
            // 
            // Form_AdminRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 75, 109);
            ClientSize = new Size(439, 953);
            Controls.Add(linkLabel1);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtAdminAccount);
            Controls.Add(txtFullName);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form_AdminRegister";
            Text = "Đăng Ký";
            FormClosed += Form_AdminRegister_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdminAccount;
        private TextBox txtFullName;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label label3;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Label label7;
        private TextBox txtPhoneNumber;
        private Button btnRegister;
        private LinkLabel linkLabel1;
    }
}