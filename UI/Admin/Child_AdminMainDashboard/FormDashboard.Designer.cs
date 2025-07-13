namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMain = new Panel();
            splitContainerMain = new SplitContainer();
            dataGridViewPCs = new DataGridView();
            panelControls = new Panel();
            groupBoxPriceSettings = new GroupBox();
            labelPriceUnit = new Label();
            txtNewTimeMinutes = new TextBox();
            btnSavePriceSettings = new Button();
            labelNewPrice = new Label();
            txtNewPrice = new TextBox();
            lblCurrentPrice = new Label();
            groupBoxEditPC = new GroupBox();
            buttonEditClear = new Button();
            buttonEditSave = new Button();
            comboBoxEditStatus = new ComboBox();
            labelEditStatus = new Label();
            labelEditBudget = new Label();
            textBoxEditSoTien = new TextBox();
            txtEditPhoneNumber = new TextBox();
            labelEditPhoneNumber = new Label();
            textBoxEditCurrentUser = new TextBox();
            labelEditUser = new Label();
            labelEditDetails = new Label();
            labelEditName = new Label();
            textBoxEditPCName = new TextBox();
            textBoxEditDetailInfo = new TextBox();
            groupBoxAddPC = new GroupBox();
            buttonClearAddPC = new Button();
            buttonAddPC = new Button();
            labelAddPC = new Label();
            textBoxSequenceNumber = new TextBox();
            panelTitle = new Panel();
            labelTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs).BeginInit();
            panelControls.SuspendLayout();
            groupBoxPriceSettings.SuspendLayout();
            groupBoxEditPC.SuspendLayout();
            groupBoxAddPC.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(26, 28, 55);
            panelMain.Controls.Add(splitContainerMain);
            panelMain.Controls.Add(panelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10, 12, 10, 12);
            panelMain.Size = new Size(1280, 900);
            panelMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.FixedPanel = FixedPanel.Panel2;
            splitContainerMain.IsSplitterFixed = true;
            splitContainerMain.Location = new Point(10, 87);
            splitContainerMain.Margin = new Padding(3, 4, 3, 4);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridViewPCs);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelControls);
            splitContainerMain.Size = new Size(1260, 801);
            splitContainerMain.SplitterDistance = 850;
            splitContainerMain.TabIndex = 1;
            // 
            // dataGridViewPCs
            // 
            this.dataGridViewPCs.AllowUserToAddRows = false;
            this.dataGridViewPCs.AllowUserToDeleteRows = false;
            this.dataGridViewPCs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.dataGridViewPCs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPCs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPCs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPCs.ColumnHeadersHeight = 40;

            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPCs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPCs.EnableHeadersVisualStyles = false;
            this.dataGridViewPCs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(100)))));
            this.dataGridViewPCs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPCs.Name = "dataGridViewPCs";
            this.dataGridViewPCs.ReadOnly = true;
            this.dataGridViewPCs.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.dataGridViewPCs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPCs.RowTemplate.Height = 35;
            this.dataGridViewPCs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPCs.Size = new System.Drawing.Size(850, 640);
            this.dataGridViewPCs.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(36, 38, 65);
            panelControls.Controls.Add(groupBoxPriceSettings);
            panelControls.Controls.Add(groupBoxEditPC);
            panelControls.Controls.Add(groupBoxAddPC);
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(3, 4, 3, 4);
            panelControls.Name = "panelControls";
            panelControls.Padding = new Padding(10, 12, 10, 12);
            panelControls.Size = new Size(406, 801);
            panelControls.TabIndex = 0;
            // 
            // groupBoxPriceSettings
            // 
            groupBoxPriceSettings.Controls.Add(labelPriceUnit);
            groupBoxPriceSettings.Controls.Add(txtNewTimeMinutes);
            groupBoxPriceSettings.Controls.Add(btnSavePriceSettings);
            groupBoxPriceSettings.Controls.Add(labelNewPrice);
            groupBoxPriceSettings.Controls.Add(txtNewPrice);
            groupBoxPriceSettings.Controls.Add(lblCurrentPrice);
            groupBoxPriceSettings.Dock = DockStyle.Top;
            groupBoxPriceSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxPriceSettings.ForeColor = Color.WhiteSmoke;
            groupBoxPriceSettings.Location = new Point(10, 687);
            groupBoxPriceSettings.Margin = new Padding(3, 4, 3, 4);
            groupBoxPriceSettings.Name = "groupBoxPriceSettings";
            groupBoxPriceSettings.Padding = new Padding(10, 12, 10, 12);
            groupBoxPriceSettings.Size = new Size(386, 170);
            groupBoxPriceSettings.TabIndex = 2;
            groupBoxPriceSettings.TabStop = false;
            groupBoxPriceSettings.Text = "Price Per Unit Settings";
            // 
            // labelPriceUnit
            // 
            labelPriceUnit.AutoSize = true;
            labelPriceUnit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPriceUnit.Location = new Point(243, 78);
            labelPriceUnit.Name = "labelPriceUnit";
            labelPriceUnit.Size = new Size(58, 23);
            labelPriceUnit.TabIndex = 16;
            labelPriceUnit.Text = "VND /";
            // 
            // txtNewTimeMinutes
            // 
            txtNewTimeMinutes.BackColor = Color.FromArgb(26, 28, 55);
            txtNewTimeMinutes.BorderStyle = BorderStyle.FixedSingle;
            txtNewTimeMinutes.Font = new Font("Segoe UI", 10F);
            txtNewTimeMinutes.ForeColor = Color.WhiteSmoke;
            txtNewTimeMinutes.Location = new Point(303, 76);
            txtNewTimeMinutes.Margin = new Padding(3, 4, 3, 4);
            txtNewTimeMinutes.Name = "txtNewTimeMinutes";
            txtNewTimeMinutes.Size = new Size(70, 30);
            txtNewTimeMinutes.TabIndex = 15;
            // 
            // btnSavePriceSettings
            // 
            btnSavePriceSettings.BackColor = Color.FromArgb(23, 162, 184);
            btnSavePriceSettings.FlatAppearance.BorderSize = 0;
            btnSavePriceSettings.FlatStyle = FlatStyle.Flat;
            btnSavePriceSettings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSavePriceSettings.Location = new Point(135, 115);
            btnSavePriceSettings.Margin = new Padding(3, 4, 3, 4);
            btnSavePriceSettings.Name = "btnSavePriceSettings";
            btnSavePriceSettings.Size = new Size(120, 50);
            btnSavePriceSettings.TabIndex = 14;
            btnSavePriceSettings.Text = "Save Price";
            btnSavePriceSettings.UseVisualStyleBackColor = false;
            btnSavePriceSettings.Click += btnSavePriceSettings_Click;
            // 
            // labelNewPrice
            // 
            labelNewPrice.AutoSize = true;
            labelNewPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNewPrice.Location = new Point(20, 78);
            labelNewPrice.Name = "labelNewPrice";
            labelNewPrice.Size = new Size(91, 23);
            labelNewPrice.TabIndex = 2;
            labelNewPrice.Text = "New Price:";
            // 
            // txtNewPrice
            // 
            txtNewPrice.BackColor = Color.FromArgb(26, 28, 55);
            txtNewPrice.BorderStyle = BorderStyle.FixedSingle;
            txtNewPrice.Font = new Font("Segoe UI", 10F);
            txtNewPrice.ForeColor = Color.WhiteSmoke;
            txtNewPrice.Location = new Point(117, 76);
            txtNewPrice.Margin = new Padding(3, 4, 3, 4);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(120, 30);
            txtNewPrice.TabIndex = 1;
            // 
            // lblCurrentPrice
            // 
            lblCurrentPrice.AutoSize = true;
            lblCurrentPrice.Font = new Font("Segoe UI", 10F);
            lblCurrentPrice.ForeColor = Color.FromArgb(170, 216, 211);
            lblCurrentPrice.Location = new Point(20, 40);
            lblCurrentPrice.Name = "lblCurrentPrice";
            lblCurrentPrice.Size = new Size(192, 23);
            lblCurrentPrice.TabIndex = 0;
            lblCurrentPrice.Text = "Current Price: Loading...";
            // 
            // groupBoxEditPC
            // 
            groupBoxEditPC.Controls.Add(buttonEditClear);
            groupBoxEditPC.Controls.Add(buttonEditSave);
            groupBoxEditPC.Controls.Add(comboBoxEditStatus);
            groupBoxEditPC.Controls.Add(labelEditStatus);
            groupBoxEditPC.Controls.Add(labelEditBudget);
            groupBoxEditPC.Controls.Add(textBoxEditSoTien);
            groupBoxEditPC.Controls.Add(txtEditPhoneNumber);
            groupBoxEditPC.Controls.Add(labelEditPhoneNumber);
            groupBoxEditPC.Controls.Add(textBoxEditCurrentUser);
            groupBoxEditPC.Controls.Add(labelEditUser);
            groupBoxEditPC.Controls.Add(labelEditDetails);
            groupBoxEditPC.Controls.Add(labelEditName);
            groupBoxEditPC.Controls.Add(textBoxEditPCName);
            groupBoxEditPC.Controls.Add(textBoxEditDetailInfo);
            groupBoxEditPC.Dock = DockStyle.Top;
            groupBoxEditPC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxEditPC.ForeColor = Color.WhiteSmoke;
            groupBoxEditPC.Location = new Point(10, 200);
            groupBoxEditPC.Margin = new Padding(3, 4, 3, 4);
            groupBoxEditPC.Name = "groupBoxEditPC";
            groupBoxEditPC.Padding = new Padding(10, 12, 10, 12);
            groupBoxEditPC.Size = new Size(386, 487);
            groupBoxEditPC.TabIndex = 1;
            groupBoxEditPC.TabStop = false;
            groupBoxEditPC.Text = "Edit Selected PC";
            // 
            // buttonEditClear
            // 
            buttonEditClear.BackColor = Color.FromArgb(108, 117, 125);
            buttonEditClear.FlatAppearance.BorderSize = 0;
            buttonEditClear.FlatStyle = FlatStyle.Flat;
            buttonEditClear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonEditClear.Location = new Point(200, 369);
            buttonEditClear.Margin = new Padding(3, 4, 3, 4);
            buttonEditClear.Name = "buttonEditClear";
            buttonEditClear.Size = new Size(120, 50);
            buttonEditClear.TabIndex = 12;
            buttonEditClear.Text = "Clear";
            buttonEditClear.UseVisualStyleBackColor = false;
            buttonEditClear.Click += buttonEditClear_Click;
            // 
            // buttonEditSave
            // 
            buttonEditSave.BackColor = Color.FromArgb(0, 123, 255);
            buttonEditSave.FlatAppearance.BorderSize = 0;
            buttonEditSave.FlatStyle = FlatStyle.Flat;
            buttonEditSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonEditSave.Location = new Point(60, 369);
            buttonEditSave.Margin = new Padding(3, 4, 3, 4);
            buttonEditSave.Name = "buttonEditSave";
            buttonEditSave.Size = new Size(120, 50);
            buttonEditSave.TabIndex = 11;
            buttonEditSave.Text = "Save";
            buttonEditSave.UseVisualStyleBackColor = false;
            buttonEditSave.Click += buttonEditSave_Click;
            // 
            // comboBoxEditStatus
            // 
            comboBoxEditStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEditStatus.BackColor = Color.FromArgb(26, 28, 55);
            comboBoxEditStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditStatus.FlatStyle = FlatStyle.Flat;
            comboBoxEditStatus.Font = new Font("Segoe UI", 10F);
            comboBoxEditStatus.ForeColor = Color.WhiteSmoke;
            comboBoxEditStatus.FormattingEnabled = true;
            comboBoxEditStatus.Location = new Point(172, 256);
            comboBoxEditStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxEditStatus.Name = "comboBoxEditStatus";
            comboBoxEditStatus.Size = new Size(204, 31);
            comboBoxEditStatus.TabIndex = 9;
            // 
            // labelEditStatus
            // 
            labelEditStatus.AutoSize = true;
            labelEditStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditStatus.Location = new Point(20, 260);
            labelEditStatus.Name = "labelEditStatus";
            labelEditStatus.Size = new Size(61, 23);
            labelEditStatus.TabIndex = 8;
            labelEditStatus.Text = "Status:";
            // 
            // labelEditBudget
            // 
            labelEditBudget.AutoSize = true;
            labelEditBudget.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditBudget.Location = new Point(20, 310);
            labelEditBudget.Name = "labelEditBudget";
            labelEditBudget.Size = new Size(69, 23);
            labelEditBudget.TabIndex = 10;
            labelEditBudget.Text = "Budget:";
            // 
            // textBoxEditSoTien
            // 
            textBoxEditSoTien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEditSoTien.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditSoTien.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditSoTien.Font = new Font("Segoe UI", 10F);
            textBoxEditSoTien.ForeColor = Color.WhiteSmoke;
            textBoxEditSoTien.Location = new Point(172, 306);
            textBoxEditSoTien.Margin = new Padding(3, 4, 3, 4);
            textBoxEditSoTien.Name = "textBoxEditSoTien";
            textBoxEditSoTien.Size = new Size(204, 30);
            textBoxEditSoTien.TabIndex = 10;
            // 
            // txtEditPhoneNumber
            // 
            txtEditPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEditPhoneNumber.BackColor = Color.FromArgb(26, 28, 55);
            txtEditPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtEditPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtEditPhoneNumber.ForeColor = Color.WhiteSmoke;
            txtEditPhoneNumber.Location = new Point(172, 156);
            txtEditPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtEditPhoneNumber.Name = "txtEditPhoneNumber";
            txtEditPhoneNumber.Size = new Size(204, 30);
            txtEditPhoneNumber.TabIndex = 7;
            // 
            // labelEditPhoneNumber
            // 
            labelEditPhoneNumber.AutoSize = true;
            labelEditPhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditPhoneNumber.Location = new Point(20, 160);
            labelEditPhoneNumber.Name = "labelEditPhoneNumber";
            labelEditPhoneNumber.Size = new Size(132, 23);
            labelEditPhoneNumber.TabIndex = 13;
            labelEditPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxEditCurrentUser
            // 
            textBoxEditCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEditCurrentUser.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditCurrentUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditCurrentUser.Font = new Font("Segoe UI", 10F);
            textBoxEditCurrentUser.ForeColor = Color.WhiteSmoke;
            textBoxEditCurrentUser.Location = new Point(172, 206);
            textBoxEditCurrentUser.Margin = new Padding(3, 4, 3, 4);
            textBoxEditCurrentUser.Name = "textBoxEditCurrentUser";
            textBoxEditCurrentUser.Size = new Size(204, 30);
            textBoxEditCurrentUser.TabIndex = 8;
            // 
            // labelEditUser
            // 
            labelEditUser.AutoSize = true;
            labelEditUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditUser.Location = new Point(20, 210);
            labelEditUser.Name = "labelEditUser";
            labelEditUser.Size = new Size(112, 23);
            labelEditUser.TabIndex = 6;
            labelEditUser.Text = "Current User:";
            // 
            // labelEditDetails
            // 
            labelEditDetails.AutoSize = true;
            labelEditDetails.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditDetails.Location = new Point(20, 110);
            labelEditDetails.Name = "labelEditDetails";
            labelEditDetails.Size = new Size(94, 23);
            labelEditDetails.TabIndex = 4;
            labelEditDetails.Text = "Detail Info:";
            // 
            // labelEditName
            // 
            labelEditName.AutoSize = true;
            labelEditName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditName.Location = new Point(20, 60);
            labelEditName.Name = "labelEditName";
            labelEditName.Size = new Size(142, 23);
            labelEditName.TabIndex = 2;
            labelEditName.Text = "PC Sequence No:";
            // 
            // textBoxEditPCName
            // 
            textBoxEditPCName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEditPCName.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditPCName.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditPCName.Font = new Font("Segoe UI", 10F);
            textBoxEditPCName.ForeColor = Color.WhiteSmoke;
            textBoxEditPCName.Location = new Point(172, 56);
            textBoxEditPCName.Margin = new Padding(3, 4, 3, 4);
            textBoxEditPCName.Name = "textBoxEditPCName";
            textBoxEditPCName.Size = new Size(204, 30);
            textBoxEditPCName.TabIndex = 3;
            textBoxEditPCName.Leave += textBoxEditPCName_Leave;
            // 
            // textBoxEditDetailInfo
            // 
            textBoxEditDetailInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEditDetailInfo.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditDetailInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditDetailInfo.Font = new Font("Segoe UI", 10F);
            textBoxEditDetailInfo.ForeColor = Color.WhiteSmoke;
            textBoxEditDetailInfo.Location = new Point(172, 106);
            textBoxEditDetailInfo.Margin = new Padding(3, 4, 3, 4);
            textBoxEditDetailInfo.Name = "textBoxEditDetailInfo";
            textBoxEditDetailInfo.Size = new Size(204, 30);
            textBoxEditDetailInfo.TabIndex = 5;
            // 
            // groupBoxAddPC
            // 
            groupBoxAddPC.Controls.Add(buttonClearAddPC);
            groupBoxAddPC.Controls.Add(buttonAddPC);
            groupBoxAddPC.Controls.Add(labelAddPC);
            groupBoxAddPC.Controls.Add(textBoxSequenceNumber);
            groupBoxAddPC.Dock = DockStyle.Top;
            groupBoxAddPC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxAddPC.ForeColor = Color.WhiteSmoke;
            groupBoxAddPC.Location = new Point(10, 12);
            groupBoxAddPC.Margin = new Padding(3, 4, 3, 4);
            groupBoxAddPC.Name = "groupBoxAddPC";
            groupBoxAddPC.Padding = new Padding(3, 4, 3, 4);
            groupBoxAddPC.Size = new Size(386, 188);
            groupBoxAddPC.TabIndex = 0;
            groupBoxAddPC.TabStop = false;
            groupBoxAddPC.Text = "Add New PC";
            // 
            // buttonClearAddPC
            // 
            buttonClearAddPC.BackColor = Color.FromArgb(108, 117, 125);
            buttonClearAddPC.FlatAppearance.BorderSize = 0;
            buttonClearAddPC.FlatStyle = FlatStyle.Flat;
            buttonClearAddPC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonClearAddPC.Location = new Point(200, 112);
            buttonClearAddPC.Margin = new Padding(3, 4, 3, 4);
            buttonClearAddPC.Name = "buttonClearAddPC";
            buttonClearAddPC.Size = new Size(120, 50);
            buttonClearAddPC.TabIndex = 4;
            buttonClearAddPC.Text = "Clear";
            buttonClearAddPC.UseVisualStyleBackColor = false;
            buttonClearAddPC.Click += buttonClearAddPC_Click;
            // 
            // buttonAddPC
            // 
            buttonAddPC.BackColor = Color.FromArgb(40, 167, 69);
            buttonAddPC.FlatAppearance.BorderSize = 0;
            buttonAddPC.FlatStyle = FlatStyle.Flat;
            buttonAddPC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonAddPC.Location = new Point(60, 112);
            buttonAddPC.Margin = new Padding(3, 4, 3, 4);
            buttonAddPC.Name = "buttonAddPC";
            buttonAddPC.Size = new Size(120, 50);
            buttonAddPC.TabIndex = 3;
            buttonAddPC.Text = "Add";
            buttonAddPC.UseVisualStyleBackColor = false;
            buttonAddPC.Click += buttonAddPC_Click;
            // 
            // labelAddPC
            // 
            labelAddPC.AutoSize = true;
            labelAddPC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelAddPC.Location = new Point(20, 54);
            labelAddPC.Name = "labelAddPC";
            labelAddPC.Size = new Size(116, 23);
            labelAddPC.TabIndex = 1;
            labelAddPC.Text = "Sequence No:";
            // 
            // textBoxSequenceNumber
            // 
            textBoxSequenceNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSequenceNumber.BackColor = Color.FromArgb(26, 28, 55);
            textBoxSequenceNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxSequenceNumber.Font = new Font("Segoe UI", 10F);
            textBoxSequenceNumber.ForeColor = Color.WhiteSmoke;
            textBoxSequenceNumber.Location = new Point(172, 50);
            textBoxSequenceNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxSequenceNumber.Name = "textBoxSequenceNumber";
            textBoxSequenceNumber.Size = new Size(204, 30);
            textBoxSequenceNumber.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(10, 12);
            panelTitle.Margin = new Padding(3, 4, 3, 4);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1260, 75);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1260, 75);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "PC Dashboard";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += UpdateTimer_Tick;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 900);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDashboard";
            Text = "FormDashboard";
            panelMain.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs).EndInit();
            panelControls.ResumeLayout(false);
            groupBoxPriceSettings.ResumeLayout(false);
            groupBoxPriceSettings.PerformLayout();
            groupBoxEditPC.ResumeLayout(false);
            groupBoxEditPC.PerformLayout();
            groupBoxAddPC.ResumeLayout(false);
            groupBoxAddPC.PerformLayout();
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView dataGridViewPCs;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox groupBoxAddPC;
        private System.Windows.Forms.Button buttonAddPC;
        private System.Windows.Forms.Label labelAddPC;
        private System.Windows.Forms.TextBox textBoxSequenceNumber;
        private System.Windows.Forms.Button buttonClearAddPC;
        private System.Windows.Forms.GroupBox groupBoxEditPC;
        private System.Windows.Forms.Button buttonEditClear;
        private System.Windows.Forms.Button buttonEditSave;
        private System.Windows.Forms.ComboBox comboBoxEditStatus;
        private System.Windows.Forms.Label labelEditStatus;
        private System.Windows.Forms.Label labelEditBudget;
        private System.Windows.Forms.TextBox textBoxEditSoTien;
        private System.Windows.Forms.TextBox textBoxEditCurrentUser;
        private System.Windows.Forms.Label labelEditUser;
        private System.Windows.Forms.Label labelEditDetails;
        private System.Windows.Forms.Label labelEditName;
        private System.Windows.Forms.TextBox textBoxEditPCName;
        private System.Windows.Forms.TextBox textBoxEditDetailInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelEditPhoneNumber;
        private System.Windows.Forms.TextBox txtEditPhoneNumber;
        private System.Windows.Forms.GroupBox groupBoxPriceSettings;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button btnSavePriceSettings;
        private System.Windows.Forms.TextBox txtNewTimeMinutes;
        private System.Windows.Forms.Label labelPriceUnit;
    }
}