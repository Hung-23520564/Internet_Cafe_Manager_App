namespace Internet_Cafe_Manager_App.UI.User
{
    partial class Form_UserLogin
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(71, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 23;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(71, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 27);
            txtUsername.TabIndex = 22;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 192);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(110, 347);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 55);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(74, 128);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 19;
            label4.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 223);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 18;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 34);
            label2.Name = "label2";
            label2.Size = new Size(259, 60);
            label2.TabIndex = 17;
            label2.Text = "Đăng Nhập";
            // 
            // Form_UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 75, 109);
            ClientSize = new Size(439, 465);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form_UserLogin";
            Text = "Form_UserLogin";
            FormClosed += Form_UserLogin_FormClosed;
            Load += Form_UserLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}