namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    partial class Form_UserInfo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMain = new Panel();
            panelDetailView = new Panel();
            lblDetailInfo = new Label();
            dgvDetailItems = new DataGridView();
            colItemName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            btnCloseDetail = new Button();
            lblDetailTitle = new Label();
            dataGridViewTransactions = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewButtonColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelTop = new Panel();
            panelMetrics = new Panel();
            lblTimeRemaining = new Label();
            label9 = new Label();
            lblCurrentBudget = new Label();
            label7 = new Label();
            lblTotalTimePlayed = new Label();
            label5 = new Label();
            panelProfile = new Panel();
            iconPhone = new FontAwesome.Sharp.IconPictureBox();
            iconEmail = new FontAwesome.Sharp.IconPictureBox();
            iconJoined = new FontAwesome.Sharp.IconPictureBox();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblJoinedDate = new Label();
            lblUsername = new Label();
            lblFullName = new Label();
            picProfile = new Internet_Cafe_Manager_App.UI.CustomControl.CircularIconPictureBox();
            panelMain.SuspendLayout();
            panelDetailView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            panelTop.SuspendLayout();
            panelMetrics.SuspendLayout();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconJoined).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Transparent;
            panelMain.Controls.Add(panelDetailView);
            panelMain.Controls.Add(dataGridViewTransactions);
            panelMain.Controls.Add(panelTop);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 750);
            panelMain.TabIndex = 0;
            // 
            // panelDetailView
            // 
            panelDetailView.BackColor = Color.FromArgb(41, 44, 75);
            panelDetailView.Controls.Add(lblDetailInfo);
            panelDetailView.Controls.Add(dgvDetailItems);
            panelDetailView.Controls.Add(btnCloseDetail);
            panelDetailView.Controls.Add(lblDetailTitle);
            panelDetailView.Dock = DockStyle.Fill;
            panelDetailView.Location = new Point(20, 520);
            panelDetailView.Name = "panelDetailView";
            panelDetailView.Padding = new Padding(15);
            panelDetailView.Size = new Size(1160, 210);
            panelDetailView.TabIndex = 2;
            // 
            // lblDetailInfo
            // 
            lblDetailInfo.AutoSize = true;
            lblDetailInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetailInfo.ForeColor = Color.Gainsboro;
            lblDetailInfo.Location = new Point(25, 60);
            lblDetailInfo.Name = "lblDetailInfo";
            lblDetailInfo.Size = new Size(139, 23);
            lblDetailInfo.TabIndex = 3;
            lblDetailInfo.Text = "PC Usage Details";
            // 
            // dgvDetailItems
            // 
            dgvDetailItems.AllowUserToAddRows = false;
            dgvDetailItems.AllowUserToDeleteRows = false;
            dgvDetailItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetailItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailItems.BackgroundColor = Color.FromArgb(41, 44, 75);
            dgvDetailItems.BorderStyle = BorderStyle.None;
            dgvDetailItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetailItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetailItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetailItems.ColumnHeadersHeight = 35;
            dgvDetailItems.Columns.AddRange(new DataGridViewColumn[] { colItemName, colQuantity, colPrice, colLineTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetailItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetailItems.EnableHeadersVisualStyles = false;
            dgvDetailItems.GridColor = Color.FromArgb(26, 28, 55);
            dgvDetailItems.Location = new Point(18, 54);
            dgvDetailItems.Name = "dgvDetailItems";
            dgvDetailItems.ReadOnly = true;
            dgvDetailItems.RowHeadersVisible = false;
            dgvDetailItems.RowHeadersWidth = 51;
            dgvDetailItems.RowTemplate.Height = 28;
            dgvDetailItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailItems.Size = new Size(1124, 138);
            dgvDetailItems.TabIndex = 2;
            // 
            // colItemName
            // 
            colItemName.FillWeight = 150F;
            colItemName.HeaderText = "Tên món";
            colItemName.MinimumWidth = 6;
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Đơn giá";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colLineTotal
            // 
            colLineTotal.HeaderText = "Thành tiền";
            colLineTotal.MinimumWidth = 6;
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            // 
            // btnCloseDetail
            // 
            btnCloseDetail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseDetail.BackColor = Color.FromArgb(36, 38, 65);
            btnCloseDetail.FlatAppearance.BorderSize = 0;
            btnCloseDetail.FlatStyle = FlatStyle.Flat;
            btnCloseDetail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseDetail.ForeColor = Color.WhiteSmoke;
            btnCloseDetail.Location = new Point(1112, 8);
            btnCloseDetail.Name = "btnCloseDetail";
            btnCloseDetail.Size = new Size(30, 30);
            btnCloseDetail.TabIndex = 1;
            btnCloseDetail.Text = "X";
            btnCloseDetail.UseVisualStyleBackColor = false;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetailTitle.ForeColor = Color.WhiteSmoke;
            lblDetailTitle.Location = new Point(15, 10);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(174, 28);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Chi tiết giao dịch";
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransactions.BackgroundColor = Color.FromArgb(36, 38, 80);
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(36, 38, 100);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 44, 80);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTransactions.ColumnHeadersHeight = 40;
            dataGridViewTransactions.Columns.AddRange(new DataGridViewColumn[] { colDate, colDescription, colTotalAmount, colDetails, colStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(41, 44, 100);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTransactions.Dock = DockStyle.Top;
            dataGridViewTransactions.EnableHeadersVisualStyles = false;
            dataGridViewTransactions.GridColor = Color.FromArgb(41, 44, 100);
            dataGridViewTransactions.Location = new Point(20, 320);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.RowHeadersVisible = false;
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.RowTemplate.Height = 35;
            dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransactions.Size = new Size(1160, 200);
            dataGridViewTransactions.TabIndex = 1;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "Date";
            colDate.FillWeight = 110F;
            colDate.HeaderText = "Ngày GD";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Description";
            colDescription.FillWeight = 150F;
            colDescription.HeaderText = "Loại giao dịch";
            colDescription.MinimumWidth = 6;
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 0, 10, 0);
            colTotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            colTotalAmount.FillWeight = 90F;
            colTotalAmount.HeaderText = "Tổng tiền";
            colTotalAmount.MinimumWidth = 6;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colDetails
            // 
            colDetails.FillWeight = 30F;
            colDetails.FlatStyle = FlatStyle.Flat;
            colDetails.HeaderText = "";
            colDetails.MinimumWidth = 6;
            colDetails.Name = "colDetails";
            colDetails.ReadOnly = true;
            colDetails.Text = "▾";
            colDetails.UseColumnTextForButtonValue = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 90F;
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(panelMetrics);
            panelTop.Controls.Add(panelProfile);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(20, 20);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1160, 300);
            panelTop.TabIndex = 0;
            // 
            // panelMetrics
            // 
            panelMetrics.BackColor = Color.FromArgb(36, 38, 65);
            panelMetrics.Controls.Add(lblTimeRemaining);
            panelMetrics.Controls.Add(label9);
            panelMetrics.Controls.Add(lblCurrentBudget);
            panelMetrics.Controls.Add(label7);
            panelMetrics.Controls.Add(lblTotalTimePlayed);
            panelMetrics.Controls.Add(label5);
            panelMetrics.Dock = DockStyle.Fill;
            panelMetrics.Location = new Point(650, 0);
            panelMetrics.Name = "panelMetrics";
            panelMetrics.Size = new Size(510, 300);
            panelMetrics.TabIndex = 1;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTimeRemaining.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTimeRemaining.ForeColor = Color.FromArgb(128, 179, 255);
            lblTimeRemaining.Location = new Point(20, 235);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(470, 45);
            lblTimeRemaining.TabIndex = 5;
            lblTimeRemaining.Text = "00:00:00";
            lblTimeRemaining.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(20, 210);
            label9.Name = "label9";
            label9.Size = new Size(195, 25);
            label9.TabIndex = 4;
            label9.Text = "Thời gian chơi còn lại";
            // 
            // lblCurrentBudget
            // 
            lblCurrentBudget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentBudget.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCurrentBudget.ForeColor = Color.FromArgb(128, 179, 255);
            lblCurrentBudget.Location = new Point(20, 145);
            lblCurrentBudget.Name = "lblCurrentBudget";
            lblCurrentBudget.Size = new Size(470, 45);
            lblCurrentBudget.TabIndex = 3;
            lblCurrentBudget.Text = "0 đ";
            lblCurrentBudget.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(20, 120);
            label7.Name = "label7";
            label7.Size = new Size(207, 25);
            label7.TabIndex = 2;
            label7.Text = "Tiền nạp phiên hiện tại";
            // 
            // lblTotalTimePlayed
            // 
            lblTotalTimePlayed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalTimePlayed.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalTimePlayed.ForeColor = Color.FromArgb(128, 179, 255);
            lblTotalTimePlayed.Location = new Point(20, 55);
            lblTotalTimePlayed.Name = "lblTotalTimePlayed";
            lblTotalTimePlayed.Size = new Size(470, 45);
            lblTotalTimePlayed.TabIndex = 1;
            lblTotalTimePlayed.Text = "0 giờ";
            lblTotalTimePlayed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(20, 30);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 0;
            label5.Text = "Tổng giờ đã chơi";
            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(36, 38, 65);
            panelProfile.Controls.Add(iconPhone);
            panelProfile.Controls.Add(iconEmail);
            panelProfile.Controls.Add(iconJoined);
            panelProfile.Controls.Add(lblPhoneNumber);
            panelProfile.Controls.Add(lblEmail);
            panelProfile.Controls.Add(lblJoinedDate);
            panelProfile.Controls.Add(lblUsername);
            panelProfile.Controls.Add(lblFullName);
            panelProfile.Controls.Add(picProfile);
            panelProfile.Dock = DockStyle.Left;
            panelProfile.Location = new Point(0, 0);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(650, 300);
            panelProfile.TabIndex = 0;
            // 
            // iconPhone
            // 
            iconPhone.BackColor = Color.Transparent;
            iconPhone.ForeColor = Color.WhiteSmoke;
            iconPhone.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconPhone.IconColor = Color.WhiteSmoke;
            iconPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPhone.IconSize = 24;
            iconPhone.Location = new Point(210, 245);
            iconPhone.Name = "iconPhone";
            iconPhone.Size = new Size(24, 24);
            iconPhone.TabIndex = 8;
            iconPhone.TabStop = false;
            // 
            // iconEmail
            // 
            iconEmail.BackColor = Color.Transparent;
            iconEmail.ForeColor = Color.WhiteSmoke;
            iconEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconEmail.IconColor = Color.WhiteSmoke;
            iconEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEmail.IconSize = 24;
            iconEmail.Location = new Point(210, 210);
            iconEmail.Name = "iconEmail";
            iconEmail.Size = new Size(24, 24);
            iconEmail.TabIndex = 7;
            iconEmail.TabStop = false;
            // 
            // iconJoined
            // 
            iconJoined.BackColor = Color.Transparent;
            iconJoined.ForeColor = Color.WhiteSmoke;
            iconJoined.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconJoined.IconColor = Color.WhiteSmoke;
            iconJoined.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconJoined.IconSize = 24;
            iconJoined.Location = new Point(210, 175);
            iconJoined.Name = "iconJoined";
            iconJoined.Size = new Size(24, 24);
            iconJoined.TabIndex = 6;
            iconJoined.TabStop = false;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 11F);
            lblPhoneNumber.ForeColor = Color.WhiteSmoke;
            lblPhoneNumber.Location = new Point(240, 247);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 25);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "09xxxxxxxx";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.ForeColor = Color.WhiteSmoke;
            lblEmail.Location = new Point(240, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(187, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "example@email.com";
            // 
            // lblJoinedDate
            // 
            lblJoinedDate.AutoSize = true;
            lblJoinedDate.Font = new Font("Segoe UI", 11F);
            lblJoinedDate.ForeColor = Color.WhiteSmoke;
            lblJoinedDate.Location = new Point(240, 177);
            lblJoinedDate.Name = "lblJoinedDate";
            lblJoinedDate.Size = new Size(193, 25);
            lblJoinedDate.TabIndex = 3;
            lblJoinedDate.Text = "Joined on 01/01/2025";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(208, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(102, 28);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "username";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(200, 50);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(214, 54);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            lblFullName.Click += lblFullName_Click;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.Transparent;
            picProfile.ForeColor = Color.FromArgb(128, 179, 255);
            picProfile.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            picProfile.IconColor = Color.FromArgb(128, 179, 255);
            picProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProfile.IconSize = 120;
            picProfile.Location = new Point(30, 30);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(120, 120);
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // Form_UserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 55);
            ClientSize = new Size(1200, 750);
            Controls.Add(panelMain);
            Name = "Form_UserInfo";
            Text = "Thông tin người dùng";
            panelMain.ResumeLayout(false);
            panelDetailView.ResumeLayout(false);
            panelDetailView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            panelTop.ResumeLayout(false);
            panelMetrics.ResumeLayout(false);
            panelMetrics.PerformLayout();
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconJoined).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelProfile;
        private FontAwesome.Sharp.IconPictureBox iconPhone;
        private FontAwesome.Sharp.IconPictureBox iconEmail;
        private FontAwesome.Sharp.IconPictureBox iconJoined;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJoinedDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private CustomControl.CircularIconPictureBox picProfile;
        private System.Windows.Forms.Panel panelMetrics;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentBudget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalTimePlayed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Panel panelDetailView;
        private System.Windows.Forms.Button btnCloseDetail;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.DataGridView dgvDetailItems;
        private System.Windows.Forms.Label lblDetailInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}