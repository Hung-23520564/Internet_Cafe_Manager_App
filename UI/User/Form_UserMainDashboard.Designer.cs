namespace Internet_Cafe_Manager_App.UI.User
{
    partial class Form_UserMainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserMainDashboard));
            panelMenu = new Panel();
            btnSignOut = new FontAwesome.Sharp.IconButton();
            btnChat = new FontAwesome.Sharp.IconButton();
            btnPayment = new FontAwesome.Sharp.IconButton();
            btnOrders = new FontAwesome.Sharp.IconButton();
            btnUserInfo = new FontAwesome.Sharp.IconButton();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Indigo;
            panelMenu.Controls.Add(btnSignOut);
            panelMenu.Controls.Add(btnChat);
            panelMenu.Controls.Add(btnPayment);
            panelMenu.Controls.Add(btnOrders);
            panelMenu.Controls.Add(btnUserInfo);
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
            btnSignOut.ForeColor = Color.AliceBlue;
            btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnSignOut.IconColor = Color.AliceBlue;
            btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(0, 426);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(15, 0, 20, 0);
            btnSignOut.Size = new Size(250, 64);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Sign Out";
            btnSignOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // btnChat
            // 
            btnChat.Dock = DockStyle.Top;
            btnChat.FlatAppearance.BorderSize = 0;
            btnChat.FlatStyle = FlatStyle.Flat;
            btnChat.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChat.ForeColor = Color.AliceBlue;
            btnChat.IconChar = FontAwesome.Sharp.IconChar.Comments;
            btnChat.IconColor = Color.AliceBlue;
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
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.AliceBlue;
            btnPayment.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            btnPayment.IconColor = Color.AliceBlue;
            btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 298);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(15, 0, 20, 0);
            btnPayment.Size = new Size(250, 64);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Payment";
            btnPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Top;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.AliceBlue;
            btnOrders.IconChar = FontAwesome.Sharp.IconChar.MugSaucer;
            btnOrders.IconColor = Color.AliceBlue;
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
            // btnUserInfo
            // 
            btnUserInfo.Dock = DockStyle.Top;
            btnUserInfo.FlatAppearance.BorderSize = 0;
            btnUserInfo.FlatStyle = FlatStyle.Flat;
            btnUserInfo.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserInfo.ForeColor = Color.AliceBlue;
            btnUserInfo.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btnUserInfo.IconColor = Color.AliceBlue;
            btnUserInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserInfo.Location = new Point(0, 170);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Padding = new Padding(15, 0, 20, 0);
            btnUserInfo.Size = new Size(250, 64);
            btnUserInfo.TabIndex = 1;
            btnUserInfo.Text = "User Information";
            btnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserInfo.UseVisualStyleBackColor = true;
            btnUserInfo.Click += btnUserInfo_Click;
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
            pictureBox1.BackColor = Color.Indigo;
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
            panelTitleBar.BackColor = Color.Indigo;
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1160, 81);
            panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.AliceBlue;
            lblTitleChildForm.Location = new Point(107, 36);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(59, 19);
            lblTitleChildForm.TabIndex = 4;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Indigo;
            iconCurrentChildForm.ForeColor = Color.AliceBlue;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.AliceBlue;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 34;
            iconCurrentChildForm.Location = new Point(67, 26);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(34, 40);
            iconCurrentChildForm.TabIndex = 3;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.Indigo;
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(250, 81);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1160, 11);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.Indigo;
            panelDesktop.Controls.Add(pictureBox2);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 92);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1160, 591);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(83, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(0, 0, 20, 0);
            pictureBox2.Size = new Size(1000, 500);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form_UserMainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 683);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form_UserMainDashboard";
            Text = "User Main Dashboard";
            FormClosed += Form_AdminMainDashboard_FormClosed;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnUserInfo;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSignOut;
        private FontAwesome.Sharp.IconButton btnChat;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnOrders;
        private Panel panelTitleBar;
        private PictureBox btnHome;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}