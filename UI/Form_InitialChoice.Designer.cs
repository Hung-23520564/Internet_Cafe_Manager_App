namespace Internet_Cafe_Manager_App.UI
{
    partial class Form_InitialChoice
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
            labelSubtitle = new Label();
            labelTitle = new Label();
            panelUser = new Panel();
            btnChooseUser = new Button();
            picUser = new FontAwesome.Sharp.IconPictureBox();
            panelAdmin = new Panel();
            btnChooseAdmin = new Button();
            picAdmin = new FontAwesome.Sharp.IconPictureBox();
            panelMain.SuspendLayout();
            panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(31, 32, 71);
            panelMain.Controls.Add(labelSubtitle);
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(panelUser);
            panelMain.Controls.Add(panelAdmin);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1200, 769);
            panelMain.TabIndex = 0;
            // 
            // labelSubtitle
            // 
            labelSubtitle.Anchor = AnchorStyles.Top;
            labelSubtitle.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubtitle.ForeColor = Color.Gainsboro;
            labelSubtitle.Location = new Point(16, 146);
            labelSubtitle.Margin = new Padding(4, 0, 4, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(1168, 38);
            labelSubtitle.TabIndex = 3;
            labelSubtitle.Text = "Please select your role";
            labelSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(16, 62);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1168, 77);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "WELCOME TO OUR CYBER";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.None;
            panelUser.BackColor = Color.FromArgb(37, 36, 81);
            panelUser.Controls.Add(btnChooseUser);
            panelUser.Controls.Add(picUser);
            panelUser.Cursor = Cursors.Hand;
            panelUser.Location = new Point(653, 246);
            panelUser.Margin = new Padding(4, 5, 4, 5);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(333, 431);
            panelUser.TabIndex = 1;
            // 
            // btnChooseUser
            // 
            btnChooseUser.BackColor = Color.FromArgb(253, 138, 114);
            btnChooseUser.Dock = DockStyle.Bottom;
            btnChooseUser.FlatAppearance.BorderSize = 0;
            btnChooseUser.FlatStyle = FlatStyle.Flat;
            btnChooseUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseUser.ForeColor = Color.White;
            btnChooseUser.Location = new Point(0, 339);
            btnChooseUser.Margin = new Padding(4, 5, 4, 5);
            btnChooseUser.Name = "btnChooseUser";
            btnChooseUser.Size = new Size(333, 92);
            btnChooseUser.TabIndex = 1;
            btnChooseUser.Text = "USER";
            btnChooseUser.UseVisualStyleBackColor = false;
            btnChooseUser.Click += btnChooseUserClick;
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.ForeColor = Color.FromArgb(253, 138, 114);
            picUser.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            picUser.IconColor = Color.FromArgb(253, 138, 114);
            picUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picUser.IconSize = 200;
            picUser.Location = new Point(67, 62);
            picUser.Margin = new Padding(4, 5, 4, 5);
            picUser.Name = "picUser";
            picUser.Size = new Size(200, 231);
            picUser.SizeMode = PictureBoxSizeMode.CenterImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            picUser.Click += btnChooseUserClick;
            // 
            // panelAdmin
            // 
            panelAdmin.Anchor = AnchorStyles.None;
            panelAdmin.BackColor = Color.FromArgb(37, 36, 81);
            panelAdmin.Controls.Add(btnChooseAdmin);
            panelAdmin.Controls.Add(picAdmin);
            panelAdmin.Cursor = Cursors.Hand;
            panelAdmin.Location = new Point(213, 246);
            panelAdmin.Margin = new Padding(4, 5, 4, 5);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(333, 431);
            panelAdmin.TabIndex = 0;
            // 
            // btnChooseAdmin
            // 
            btnChooseAdmin.BackColor = Color.FromArgb(128, 179, 255);
            btnChooseAdmin.Dock = DockStyle.Bottom;
            btnChooseAdmin.FlatAppearance.BorderSize = 0;
            btnChooseAdmin.FlatStyle = FlatStyle.Flat;
            btnChooseAdmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseAdmin.ForeColor = Color.White;
            btnChooseAdmin.Location = new Point(0, 339);
            btnChooseAdmin.Margin = new Padding(4, 5, 4, 5);
            btnChooseAdmin.Name = "btnChooseAdmin";
            btnChooseAdmin.Size = new Size(333, 92);
            btnChooseAdmin.TabIndex = 1;
            btnChooseAdmin.Text = "ADMIN";
            btnChooseAdmin.UseVisualStyleBackColor = false;
            btnChooseAdmin.Click += btnChooseAdmin_Click;
            // 
            // picAdmin
            // 
            picAdmin.BackColor = Color.Transparent;
            picAdmin.ForeColor = Color.FromArgb(128, 179, 255);
            picAdmin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            picAdmin.IconColor = Color.FromArgb(128, 179, 255);
            picAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picAdmin.IconSize = 269;
            picAdmin.Location = new Point(50, 38);
            picAdmin.Margin = new Padding(4, 5, 4, 5);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(269, 278);
            picAdmin.SizeMode = PictureBoxSizeMode.CenterImage;
            picAdmin.TabIndex = 0;
            picAdmin.TabStop = false;
            picAdmin.Click += btnChooseAdmin_Click;
            // 
            // Form_InitialChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 769);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form_InitialChoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Your Role";
            FormClosed += Form_InitialChoice_FormClosed;
            panelMain.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnChooseAdmin;
        private System.Windows.Forms.Button btnChooseUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private FontAwesome.Sharp.IconPictureBox picUser;
        private FontAwesome.Sharp.IconPictureBox picAdmin;
    }
}