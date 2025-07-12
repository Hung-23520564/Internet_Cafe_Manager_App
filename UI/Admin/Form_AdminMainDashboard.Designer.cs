namespace Internet_Cafe_Manager_App.UI.Admin
{
    partial class Form_AdminMainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AdminMainDashboard));
            panelMenu = new Panel();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            btnSetting = new FontAwesome.Sharp.IconButton();
            btnCreateUser = new FontAwesome.Sharp.IconButton(); // Nút mới
            btnChat = new FontAwesome.Sharp.IconButton();
            btnSystem = new FontAwesome.Sharp.IconButton();
            btnOrders = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBox2 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(btnHome)).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(iconCurrentChildForm)).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 32, 71);
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnCreateUser); // Thêm nút mới vào panel
            panelMenu.Controls.Add(btnChat);
            panelMenu.Controls.Add(btnSystem);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 683);
            panelMenu.TabIndex = 0;
            // 
            // btnSignOut
            // 
            btnSignOut.Dock = DockStyle.Top;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = Color.FromArgb(222, 220, 220);
            btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSignOut.IconColor = Color.Gainsboro;
            btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(0, 554);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(15, 0, 20, 0);
            btnSignOut.Size = new Size(250, 64);
            btnSignOut.TabIndex = 7;
            btnSignOut.Text = "Sign Out";
            btnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnSetting
            // 
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetting.ForeColor = Color.FromArgb(222, 220, 220);
            btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnSetting.IconColor = Color.Gainsboro;
            btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 490);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(15, 0, 20, 0);
            btnSetting.Size = new Size(250, 64);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "Setting";
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            //
            // btnCreateUser
            //
            btnCreateUser.Dock = DockStyle.Top;
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.FromArgb(222, 220, 220);
            btnCreateUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnCreateUser.IconColor = Color.Gainsboro;
            btnCreateUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCreateUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateUser.Location = new Point(0, 426);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Padding = new Padding(15, 0, 20, 0);
            btnCreateUser.Size = new Size(250, 64);
            btnCreateUser.TabIndex = 5;
            btnCreateUser.Text = "Create User";
            btnCreateUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateUser.UseVisualStyleBackColor = true;
            btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnChat
            // 
            btnChat.Dock = DockStyle.Top;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChat.ForeColor = Color.FromArgb(222, 220, 220);
            btnChat.IconChar = FontAwesome.Sharp.IconChar.Comments;
            btnChat.IconColor = Color.Gainsboro;
            btnChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChat.ImageAlign = ContentAlignment.MiddleLeft;
            btnChat.Location = new Point(0, 362);
            btnChat.Name = "btnChat";
            btnChat.Padding = new Padding(15, 0, 20, 0);
            btnChat.Size = new Size(250, 64);
            btnChat.TabIndex = 4;
            btnChat.Text = "Comment - Chat";
            btnChat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // btnSystem
            // 
            btnSystem.Dock = DockStyle.Top;
            btnSystem.FlatAppearance.BorderSize = 0;
            btnSystem.FlatStyle = FlatStyle.Flat;
            btnSystem.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSystem.ForeColor = Color.FromArgb(222, 220, 220);
            btnSystem.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            btnSystem.IconColor = Color.Gainsboro;
            btnSystem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSystem.ImageAlign = ContentAlignment.MiddleLeft;
            btnSystem.Location = new Point(0, 298);
            btnSystem.Name = "btnSystem";
            btnSystem.Padding = new Padding(15, 0, 20, 0);
            btnSystem.Size = new Size(250, 64);
            btnSystem.TabIndex = 3;
            btnSystem.Text = "System Manage";
            btnSystem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSystem.UseVisualStyleBackColor = true;
            btnSystem.Click += btnSystem_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.FromArgb(222, 220, 220);
            btnOrders.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            btnOrders.IconColor = Color.Gainsboro;
            btnOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(0, 234);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(15, 0, 20, 0);
            btnOrders.Size = new Size(250, 64);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrder_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(222, 220, 220);
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btnDashboard.IconColor = Color.Gainsboro;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 170);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 20, 0);
            btnDashboard.Size = new Size(250, 64);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 170);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 0, 20, 0);
            pictureBox1.Size = new Size(250, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnHome_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(0, 0, 20, 0);
            btnHome.Size = new Size(250, 170);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 2;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 25, 59);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1160, 87);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(83, 37);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(59, 19);
            lblTitleChildForm.TabIndex = 4;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(24, 25, 59);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 34;
            iconCurrentChildForm.Location = new Point(43, 27);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(34, 40);
            iconCurrentChildForm.TabIndex = 3;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(34, 33, 74);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(250, 87);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1160, 11);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox2);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 98);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1160, 585);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(311, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(0, 0, 20, 0);
            pictureBox2.Size = new Size(558, 328);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form_AdminMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 683);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_AdminMainDashboard";
            Text = "Admin Main Dashboard";
            FormClosed += Form_AdminMainDashboard_FormClosed;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(btnHome)).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(iconCurrentChildForm)).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnChat;
        private FontAwesome.Sharp.IconButton btnSystem;
        private FontAwesome.Sharp.IconButton btnOrders;
        private Panel panelTitleBar;
        private PictureBox btnHome;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private FontAwesome.Sharp.IconButton btnCreateUser;
    }
}