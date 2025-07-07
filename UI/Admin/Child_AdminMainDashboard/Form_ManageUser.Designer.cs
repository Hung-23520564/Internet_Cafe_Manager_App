namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class Form_ManageUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panelTitleBar = new Panel();
            labelTitle = new Label();
            panelControls = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtSearchUser = new TextBox();
            lblSearch = new Label();
            splitContainerMain = new SplitContainer();
            dataGridViewUsers = new DataGridView();
            colUserID = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colUserFullName = new DataGridViewTextBoxColumn();
            colUserStatus = new DataGridViewTextBoxColumn();
            panelUserDetails = new Panel();
            panelHireTime = new Panel();
            dataGridViewHireTime = new DataGridView();
            colHireDateTime = new DataGridViewTextBoxColumn();
            colHireTimeDuration = new DataGridViewTextBoxColumn();
            colHireTotalAmount = new DataGridViewTextBoxColumn();
            colHireStatus = new DataGridViewTextBoxColumn();
            colMarkAsCompleteHire = new DataGridViewButtonColumn();
            lblHireTimeTitle = new Label();
            panelOrderHistory = new Panel();
            dataGridViewUserOrders = new DataGridView();
            colOrderTimestamp = new DataGridViewTextBoxColumn();
            colOrderItems = new DataGridViewTextBoxColumn();
            colOrderTotal = new DataGridViewTextBoxColumn();
            colOrderStatus = new DataGridViewTextBoxColumn();
            colMarkAsCompleteOrder = new DataGridViewButtonColumn();
            lblUserOrdersTitle = new Label();
            panelUserInfo = new Panel();
            lblUserEmail = new Label();
            lblUserFullName = new Label();
            lblUsername = new Label();
            lblUserInfoTitle = new Label();
            panelTitleBar.SuspendLayout();
            panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelUserDetails.SuspendLayout();
            panelHireTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHireTime).BeginInit();
            panelOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserOrders).BeginInit();
            panelUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(36, 38, 65);
            panelTitleBar.Controls.Add(labelTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1284, 60);
            panelTitleBar.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(515, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(253, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "User Management";
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(36, 38, 65);
            panelControls.Controls.Add(btnRefresh);
            panelControls.Controls.Add(txtSearchUser);
            panelControls.Controls.Add(lblSearch);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 60);
            panelControls.Name = "panelControls";
            panelControls.Padding = new Padding(10);
            panelControls.Size = new Size(1284, 60);
            panelControls.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(128, 179, 255);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(26, 28, 55);
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnRefresh.IconColor = Color.FromArgb(26, 28, 55);
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 24;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1162, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(5, 0, 0, 0);
            btnRefresh.Size = new Size(110, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchUser.BackColor = Color.FromArgb(26, 28, 55);
            txtSearchUser.BorderStyle = BorderStyle.FixedSingle;
            txtSearchUser.Font = new Font("Segoe UI", 10F);
            txtSearchUser.ForeColor = Color.WhiteSmoke;
            txtSearchUser.Location = new Point(140, 15);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(1004, 30);
            txtSearchUser.TabIndex = 1;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.WhiteSmoke;
            lblSearch.Location = new Point(13, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search User:";
            // 
            // splitContainerMain
            // 
            splitContainerMain.BackColor = Color.FromArgb(26, 28, 55);
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 120);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridViewUsers);
            splitContainerMain.Panel1.Padding = new Padding(10, 10, 5, 10);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelUserDetails);
            splitContainerMain.Panel2.Padding = new Padding(5, 10, 10, 10);
            splitContainerMain.Size = new Size(1284, 641);
            splitContainerMain.SplitterDistance = 500;
            splitContainerMain.SplitterWidth = 6;
            splitContainerMain.TabIndex = 2;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = Color.FromArgb(36, 38, 65);
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 38, 65);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeight = 40;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { colUserID, colUserName, colUserFullName, colUserStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.GridColor = Color.FromArgb(41, 44, 75);
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.RowTemplate.Height = 35;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(485, 621);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // colUserID
            // 
            colUserID.DataPropertyName = "UserId";
            colUserID.FillWeight = 80F;
            colUserID.HeaderText = "UserID";
            colUserID.MinimumWidth = 6;
            colUserID.Name = "colUserID";
            colUserID.ReadOnly = true;
            // 
            // colUserName
            // 
            colUserName.DataPropertyName = "Username";
            colUserName.FillWeight = 120F;
            colUserName.HeaderText = "Username";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            // 
            // colUserFullName
            // 
            colUserFullName.DataPropertyName = "FullName";
            colUserFullName.FillWeight = 150F;
            colUserFullName.HeaderText = "Full Name";
            colUserFullName.MinimumWidth = 6;
            colUserFullName.Name = "colUserFullName";
            colUserFullName.ReadOnly = true;
            // 
            // colUserStatus
            // 
            colUserStatus.DataPropertyName = "IsUserActive";
            colUserStatus.FillWeight = 80F;
            colUserStatus.HeaderText = "Active";
            colUserStatus.MinimumWidth = 6;
            colUserStatus.Name = "colUserStatus";
            colUserStatus.ReadOnly = true;
            // 
            // panelUserDetails
            // 
            panelUserDetails.BackColor = Color.FromArgb(36, 38, 65);
            panelUserDetails.Controls.Add(panelHireTime);
            panelUserDetails.Controls.Add(panelOrderHistory);
            panelUserDetails.Controls.Add(panelUserInfo);
            panelUserDetails.Dock = DockStyle.Fill;
            panelUserDetails.Location = new Point(5, 10);
            panelUserDetails.Name = "panelUserDetails";
            panelUserDetails.Padding = new Padding(10);
            panelUserDetails.Size = new Size(763, 621);
            panelUserDetails.TabIndex = 0;
            // 
            // panelHireTime
            // 
            panelHireTime.Controls.Add(dataGridViewHireTime);
            panelHireTime.Controls.Add(lblHireTimeTitle);
            panelHireTime.Dock = DockStyle.Fill;
            panelHireTime.Location = new Point(10, 385);
            panelHireTime.Name = "panelHireTime";
            panelHireTime.Size = new Size(743, 226);
            panelHireTime.TabIndex = 2;
            // 
            // dataGridViewHireTime
            // 
            dataGridViewHireTime.AllowUserToAddRows = false;
            dataGridViewHireTime.AllowUserToDeleteRows = false;
            dataGridViewHireTime.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHireTime.BackgroundColor = Color.FromArgb(26, 28, 55);
            dataGridViewHireTime.BorderStyle = BorderStyle.None;
            dataGridViewHireTime.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHireTime.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(36, 38, 65);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(36, 38, 65);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHireTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHireTime.ColumnHeadersHeight = 35;
            dataGridViewHireTime.Columns.AddRange(new DataGridViewColumn[] { colHireDateTime, colHireTimeDuration, colHireTotalAmount, colHireStatus, colMarkAsCompleteHire });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle6.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewHireTime.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewHireTime.Dock = DockStyle.Fill;
            dataGridViewHireTime.EnableHeadersVisualStyles = false;
            dataGridViewHireTime.GridColor = Color.FromArgb(41, 44, 75);
            dataGridViewHireTime.Location = new Point(0, 43);
            dataGridViewHireTime.Name = "dataGridViewHireTime";
            dataGridViewHireTime.ReadOnly = true;
            dataGridViewHireTime.RowHeadersVisible = false;
            dataGridViewHireTime.RowHeadersWidth = 51;
            dataGridViewHireTime.RowTemplate.Height = 30;
            dataGridViewHireTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHireTime.Size = new Size(743, 183);
            dataGridViewHireTime.TabIndex = 1;
            dataGridViewHireTime.CellContentClick += dataGridViewHireTime_CellContentClick;
            dataGridViewHireTime.CellFormatting += dataGridViewHireTime_CellFormatting;
            // 
            // colHireDateTime
            // 
            colHireDateTime.DataPropertyName = "Timestamp";
            colHireDateTime.HeaderText = "Date/Time";
            colHireDateTime.MinimumWidth = 6;
            colHireDateTime.Name = "colHireDateTime";
            colHireDateTime.ReadOnly = true;
            // 
            // colHireTimeDuration
            // 
            colHireTimeDuration.DataPropertyName = "TimePurchased";
            colHireTimeDuration.HeaderText = "Hire Time";
            colHireTimeDuration.MinimumWidth = 6;
            colHireTimeDuration.Name = "colHireTimeDuration";
            colHireTimeDuration.ReadOnly = true;
            // 
            // colHireTotalAmount
            // 
            dataGridViewCellStyle4.Format = "N0";
            colHireTotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            colHireTotalAmount.HeaderText = "Total";
            colHireTotalAmount.MinimumWidth = 6;
            colHireTotalAmount.Name = "colHireTotalAmount";
            colHireTotalAmount.ReadOnly = true;
            // 
            // colHireStatus
            // 
            colHireStatus.DataPropertyName = "Status";
            colHireStatus.HeaderText = "Status";
            colHireStatus.MinimumWidth = 6;
            colHireStatus.Name = "colHireStatus";
            colHireStatus.ReadOnly = true;
            // 
            // colMarkAsCompleteHire
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SeaGreen;
            colMarkAsCompleteHire.DefaultCellStyle = dataGridViewCellStyle5;
            colMarkAsCompleteHire.FillWeight = 80F;
            colMarkAsCompleteHire.FlatStyle = FlatStyle.Flat;
            colMarkAsCompleteHire.HeaderText = "Action";
            colMarkAsCompleteHire.MinimumWidth = 6;
            colMarkAsCompleteHire.Name = "colMarkAsCompleteHire";
            colMarkAsCompleteHire.ReadOnly = true;
            colMarkAsCompleteHire.Text = "Complete";
            colMarkAsCompleteHire.UseColumnTextForButtonValue = true;
            // 
            // lblHireTimeTitle
            // 
            lblHireTimeTitle.AutoSize = true;
            lblHireTimeTitle.Dock = DockStyle.Top;
            lblHireTimeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHireTimeTitle.ForeColor = Color.WhiteSmoke;
            lblHireTimeTitle.Location = new Point(0, 0);
            lblHireTimeTitle.Name = "lblHireTimeTitle";
            lblHireTimeTitle.Padding = new Padding(0, 10, 0, 5);
            lblHireTimeTitle.Size = new Size(186, 43);
            lblHireTimeTitle.TabIndex = 0;
            lblHireTimeTitle.Text = "Hire Time History:";
            // 
            // panelOrderHistory
            // 
            panelOrderHistory.Controls.Add(dataGridViewUserOrders);
            panelOrderHistory.Controls.Add(lblUserOrdersTitle);
            panelOrderHistory.Dock = DockStyle.Top;
            panelOrderHistory.Location = new Point(10, 155);
            panelOrderHistory.Name = "panelOrderHistory";
            panelOrderHistory.Size = new Size(743, 230);
            panelOrderHistory.TabIndex = 1;
            // 
            // dataGridViewUserOrders
            // 
            dataGridViewUserOrders.AllowUserToAddRows = false;
            dataGridViewUserOrders.AllowUserToDeleteRows = false;
            dataGridViewUserOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUserOrders.BackgroundColor = Color.FromArgb(26, 28, 55);
            dataGridViewUserOrders.BorderStyle = BorderStyle.None;
            dataGridViewUserOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewUserOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(36, 38, 65);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(36, 38, 65);
            dataGridViewCellStyle7.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewUserOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewUserOrders.ColumnHeadersHeight = 35;
            dataGridViewUserOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderTimestamp, colOrderItems, colOrderTotal, colOrderStatus, colMarkAsCompleteOrder });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(41, 44, 75);
            dataGridViewCellStyle9.SelectionForeColor = Color.Gainsboro;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridViewUserOrders.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewUserOrders.Dock = DockStyle.Fill;
            dataGridViewUserOrders.EnableHeadersVisualStyles = false;
            dataGridViewUserOrders.GridColor = Color.FromArgb(41, 44, 75);
            dataGridViewUserOrders.Location = new Point(0, 43);
            dataGridViewUserOrders.Name = "dataGridViewUserOrders";
            dataGridViewUserOrders.ReadOnly = true;
            dataGridViewUserOrders.RowHeadersVisible = false;
            dataGridViewUserOrders.RowHeadersWidth = 51;
            dataGridViewUserOrders.RowTemplate.Height = 30;
            dataGridViewUserOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUserOrders.Size = new Size(743, 187);
            dataGridViewUserOrders.TabIndex = 1;
            dataGridViewUserOrders.CellContentClick += dataGridViewUserOrders_CellContentClick;
            dataGridViewUserOrders.CellFormatting += dataGridViewUserOrders_CellFormatting;
            // 
            // colOrderTimestamp
            // 
            colOrderTimestamp.DataPropertyName = "Timestamp";
            colOrderTimestamp.HeaderText = "Date/Time";
            colOrderTimestamp.MinimumWidth = 6;
            colOrderTimestamp.Name = "colOrderTimestamp";
            colOrderTimestamp.ReadOnly = true;
            // 
            // colOrderItems
            // 
            colOrderItems.DataPropertyName = "ItemsSummary";
            colOrderItems.FillWeight = 150F;
            colOrderItems.HeaderText = "Items";
            colOrderItems.MinimumWidth = 6;
            colOrderItems.Name = "colOrderItems";
            colOrderItems.ReadOnly = true;
            // 
            // colOrderTotal
            // 
            colOrderTotal.DataPropertyName = "GrandTotal";
            dataGridViewCellStyle8.Format = "N0";
            colOrderTotal.DefaultCellStyle = dataGridViewCellStyle8;
            colOrderTotal.HeaderText = "Total";
            colOrderTotal.MinimumWidth = 6;
            colOrderTotal.Name = "colOrderTotal";
            colOrderTotal.ReadOnly = true;
            // 
            // colOrderStatus
            // 
            colOrderStatus.DataPropertyName = "Status";
            colOrderStatus.HeaderText = "Status";
            colOrderStatus.MinimumWidth = 6;
            colOrderStatus.Name = "colOrderStatus";
            colOrderStatus.ReadOnly = true;
            // 
            // colMarkAsCompleteOrder
            // 
            colMarkAsCompleteOrder.DefaultCellStyle = dataGridViewCellStyle5;
            colMarkAsCompleteOrder.FillWeight = 80F;
            colMarkAsCompleteOrder.FlatStyle = FlatStyle.Flat;
            colMarkAsCompleteOrder.HeaderText = "Action";
            colMarkAsCompleteOrder.MinimumWidth = 6;
            colMarkAsCompleteOrder.Name = "colMarkAsCompleteOrder";
            colMarkAsCompleteOrder.ReadOnly = true;
            colMarkAsCompleteOrder.Text = "Confirm";
            colMarkAsCompleteOrder.UseColumnTextForButtonValue = true;
            // 
            // lblUserOrdersTitle
            // 
            lblUserOrdersTitle.AutoSize = true;
            lblUserOrdersTitle.Dock = DockStyle.Top;
            lblUserOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserOrdersTitle.ForeColor = Color.WhiteSmoke;
            lblUserOrdersTitle.Location = new Point(0, 0);
            lblUserOrdersTitle.Name = "lblUserOrdersTitle";
            lblUserOrdersTitle.Padding = new Padding(0, 10, 0, 5);
            lblUserOrdersTitle.Size = new Size(147, 43);
            lblUserOrdersTitle.TabIndex = 0;
            lblUserOrdersTitle.Text = "Order History:";
            // 
            // panelUserInfo
            // 
            panelUserInfo.Controls.Add(lblUserEmail);
            panelUserInfo.Controls.Add(lblUserFullName);
            panelUserInfo.Controls.Add(lblUsername);
            panelUserInfo.Controls.Add(lblUserInfoTitle);
            panelUserInfo.Dock = DockStyle.Top;
            panelUserInfo.Location = new Point(10, 10);
            panelUserInfo.Name = "panelUserInfo";
            panelUserInfo.Padding = new Padding(5);
            panelUserInfo.Size = new Size(743, 145);
            panelUserInfo.TabIndex = 0;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Font = new Font("Segoe UI", 9.5F);
            lblUserEmail.ForeColor = Color.Gainsboro;
            lblUserEmail.Location = new Point(15, 105);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(61, 21);
            lblUserEmail.TabIndex = 3;
            lblUserEmail.Text = "Email: -";
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.Font = new Font("Segoe UI", 9.5F);
            lblUserFullName.ForeColor = Color.Gainsboro;
            lblUserFullName.Location = new Point(15, 75);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(94, 21);
            lblUserFullName.TabIndex = 2;
            lblUserFullName.Text = "Full Name: -";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9.5F);
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(15, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username: -";
            // 
            // lblUserInfoTitle
            // 
            lblUserInfoTitle.AutoSize = true;
            lblUserInfoTitle.Dock = DockStyle.Top;
            lblUserInfoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserInfoTitle.ForeColor = Color.WhiteSmoke;
            lblUserInfoTitle.Location = new Point(5, 5);
            lblUserInfoTitle.Name = "lblUserInfoTitle";
            lblUserInfoTitle.Padding = new Padding(0, 0, 0, 5);
            lblUserInfoTitle.Size = new Size(178, 33);
            lblUserInfoTitle.TabIndex = 0;
            lblUserInfoTitle.Text = "User Information:";
            // 
            // Form_ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 55);
            ClientSize = new Size(1284, 761);
            Controls.Add(splitContainerMain);
            Controls.Add(panelControls);
            Controls.Add(panelTitleBar);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_ManageUser";
            Text = "User Management";
            Load += Form_ManageUser_Load;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelUserDetails.ResumeLayout(false);
            panelHireTime.ResumeLayout(false);
            panelHireTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHireTime).EndInit();
            panelOrderHistory.ResumeLayout(false);
            panelOrderHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserOrders).EndInit();
            panelUserInfo.ResumeLayout(false);
            panelUserInfo.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Label lblSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserInfoTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Panel panelOrderHistory;
        private System.Windows.Forms.DataGridView dataGridViewUserOrders;
        private System.Windows.Forms.Label lblUserOrdersTitle;
        private System.Windows.Forms.Panel panelHireTime;
        private System.Windows.Forms.DataGridView dataGridViewHireTime;
        private System.Windows.Forms.Label lblHireTimeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireTimeDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsCompleteHire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTimestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colMarkAsCompleteOrder;
    }
}