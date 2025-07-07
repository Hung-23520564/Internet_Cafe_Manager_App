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
            groupBoxEditPC = new GroupBox();
            buttonEditClear = new Button();
            buttonEditSave = new Button();
            comboBoxEditStatus = new ComboBox();
            labelEditStatus = new Label();
            labelEditBudget = new Label();
            textBoxEditSoTien = new TextBox();
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
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(13, 15, 13, 15);
            panelMain.Size = new Size(1707, 1055);
            panelMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(13, 107);
            splitContainerMain.Margin = new Padding(4, 5, 4, 5);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(dataGridViewPCs);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(panelControls);
            splitContainerMain.Size = new Size(1681, 933);
            splitContainerMain.SplitterDistance = 1134;
            splitContainerMain.SplitterWidth = 5;
            splitContainerMain.TabIndex = 1;
            // 
            // dataGridViewPCs
            // 
            dataGridViewPCs.AllowUserToAddRows = false;
            dataGridViewPCs.AllowUserToDeleteRows = false;
            dataGridViewPCs.BackgroundColor = Color.FromArgb(36, 38, 65);
            dataGridViewPCs.BorderStyle = BorderStyle.None;
            dataGridViewPCs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPCs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 38, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 44, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPCs.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 44, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPCs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPCs.Dock = DockStyle.Fill;
            dataGridViewPCs.EnableHeadersVisualStyles = false;
            dataGridViewPCs.GridColor = Color.FromArgb(41, 44, 100);
            dataGridViewPCs.Location = new Point(0, 0);
            dataGridViewPCs.Margin = new Padding(4, 5, 4, 5);
            dataGridViewPCs.Name = "dataGridViewPCs";
            dataGridViewPCs.ReadOnly = true;
            dataGridViewPCs.RowHeadersVisible = false;
            dataGridViewPCs.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewPCs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPCs.RowTemplate.Height = 35;
            dataGridViewPCs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPCs.Size = new Size(1134, 933);
            dataGridViewPCs.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(36, 38, 65);
            panelControls.Controls.Add(groupBoxEditPC);
            panelControls.Controls.Add(groupBoxAddPC);
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(4, 5, 4, 5);
            panelControls.Name = "panelControls";
            panelControls.Padding = new Padding(13, 15, 13, 15);
            panelControls.Size = new Size(542, 933);
            panelControls.TabIndex = 0;
            // 
            // groupBoxEditPC
            // 
            groupBoxEditPC.Controls.Add(buttonEditClear);
            groupBoxEditPC.Controls.Add(buttonEditSave);
            groupBoxEditPC.Controls.Add(comboBoxEditStatus);
            groupBoxEditPC.Controls.Add(labelEditStatus);
            groupBoxEditPC.Controls.Add(labelEditBudget);
            groupBoxEditPC.Controls.Add(textBoxEditSoTien);
            groupBoxEditPC.Controls.Add(textBoxEditCurrentUser);
            groupBoxEditPC.Controls.Add(labelEditUser);
            groupBoxEditPC.Controls.Add(labelEditDetails);
            groupBoxEditPC.Controls.Add(labelEditName);
            groupBoxEditPC.Controls.Add(textBoxEditPCName);
            groupBoxEditPC.Controls.Add(textBoxEditDetailInfo);
            groupBoxEditPC.Dock = DockStyle.Top;
            groupBoxEditPC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxEditPC.ForeColor = Color.WhiteSmoke;
            groupBoxEditPC.Location = new Point(13, 246);
            groupBoxEditPC.Margin = new Padding(4, 5, 4, 5);
            groupBoxEditPC.Name = "groupBoxEditPC";
            groupBoxEditPC.Padding = new Padding(4, 5, 4, 5);
            groupBoxEditPC.Size = new Size(516, 585);
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
            buttonEditClear.Location = new Point(267, 477);
            buttonEditClear.Margin = new Padding(4, 5, 4, 5);
            buttonEditClear.Name = "buttonEditClear";
            buttonEditClear.Size = new Size(160, 62);
            buttonEditClear.TabIndex = 12;
            buttonEditClear.Text = "Clear";
            buttonEditClear.UseVisualStyleBackColor = false;
            // 
            // buttonEditSave
            // 
            buttonEditSave.BackColor = Color.FromArgb(0, 123, 255);
            buttonEditSave.FlatAppearance.BorderSize = 0;
            buttonEditSave.FlatStyle = FlatStyle.Flat;
            buttonEditSave.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonEditSave.Location = new Point(80, 477);
            buttonEditSave.Margin = new Padding(4, 5, 4, 5);
            buttonEditSave.Name = "buttonEditSave";
            buttonEditSave.Size = new Size(160, 62);
            buttonEditSave.TabIndex = 11;
            buttonEditSave.Text = "Save";
            buttonEditSave.UseVisualStyleBackColor = false;
            buttonEditSave.Click += buttonEditSave_Click;
            // 
            // comboBoxEditStatus
            // 
            comboBoxEditStatus.BackColor = Color.FromArgb(26, 28, 55);
            comboBoxEditStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditStatus.FlatStyle = FlatStyle.Flat;
            comboBoxEditStatus.Font = new Font("Segoe UI", 10F);
            comboBoxEditStatus.ForeColor = Color.WhiteSmoke;
            comboBoxEditStatus.FormattingEnabled = true;
            comboBoxEditStatus.Location = new Point(200, 308);
            comboBoxEditStatus.Margin = new Padding(4, 5, 4, 5);
            comboBoxEditStatus.Name = "comboBoxEditStatus";
            comboBoxEditStatus.Size = new Size(292, 31);
            comboBoxEditStatus.TabIndex = 9;
            // 
            // labelEditStatus
            // 
            labelEditStatus.AutoSize = true;
            labelEditStatus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditStatus.Location = new Point(27, 312);
            labelEditStatus.Margin = new Padding(4, 0, 4, 0);
            labelEditStatus.Name = "labelEditStatus";
            labelEditStatus.Size = new Size(61, 23);
            labelEditStatus.TabIndex = 8;
            labelEditStatus.Text = "Status:";
            // 
            // labelEditBudget
            // 
            labelEditBudget.AutoSize = true;
            labelEditBudget.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditBudget.Location = new Point(27, 389);
            labelEditBudget.Margin = new Padding(4, 0, 4, 0);
            labelEditBudget.Name = "labelEditBudget";
            labelEditBudget.Size = new Size(69, 23);
            labelEditBudget.TabIndex = 10;
            labelEditBudget.Text = "Budget:";
            // 
            // textBoxEditSoTien
            // 
            textBoxEditSoTien.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditSoTien.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditSoTien.Font = new Font("Segoe UI", 10F);
            textBoxEditSoTien.ForeColor = Color.WhiteSmoke;
            textBoxEditSoTien.Location = new Point(200, 385);
            textBoxEditSoTien.Margin = new Padding(4, 5, 4, 5);
            textBoxEditSoTien.Name = "textBoxEditSoTien";
            textBoxEditSoTien.Size = new Size(293, 30);
            textBoxEditSoTien.TabIndex = 10;
            // 
            // textBoxEditCurrentUser
            // 
            textBoxEditCurrentUser.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditCurrentUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditCurrentUser.Font = new Font("Segoe UI", 10F);
            textBoxEditCurrentUser.ForeColor = Color.WhiteSmoke;
            textBoxEditCurrentUser.Location = new Point(200, 231);
            textBoxEditCurrentUser.Margin = new Padding(4, 5, 4, 5);
            textBoxEditCurrentUser.Name = "textBoxEditCurrentUser";
            textBoxEditCurrentUser.Size = new Size(293, 30);
            textBoxEditCurrentUser.TabIndex = 7;
            // 
            // labelEditUser
            // 
            labelEditUser.AutoSize = true;
            labelEditUser.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditUser.Location = new Point(27, 235);
            labelEditUser.Margin = new Padding(4, 0, 4, 0);
            labelEditUser.Name = "labelEditUser";
            labelEditUser.Size = new Size(112, 23);
            labelEditUser.TabIndex = 6;
            labelEditUser.Text = "Current User:";
            // 
            // labelEditDetails
            // 
            labelEditDetails.AutoSize = true;
            labelEditDetails.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditDetails.Location = new Point(27, 158);
            labelEditDetails.Margin = new Padding(4, 0, 4, 0);
            labelEditDetails.Name = "labelEditDetails";
            labelEditDetails.Size = new Size(94, 23);
            labelEditDetails.TabIndex = 4;
            labelEditDetails.Text = "Detail Info:";
            // 
            // labelEditName
            // 
            labelEditName.AutoSize = true;
            labelEditName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelEditName.Location = new Point(27, 82);
            labelEditName.Margin = new Padding(4, 0, 4, 0);
            labelEditName.Name = "labelEditName";
            labelEditName.Size = new Size(146, 23);
            labelEditName.TabIndex = 2;
            labelEditName.Text = "PC Sequence No.:";
            // 
            // textBoxEditPCName
            // 
            textBoxEditPCName.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditPCName.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditPCName.Font = new Font("Segoe UI", 10F);
            textBoxEditPCName.ForeColor = Color.WhiteSmoke;
            textBoxEditPCName.Location = new Point(200, 77);
            textBoxEditPCName.Margin = new Padding(4, 5, 4, 5);
            textBoxEditPCName.Name = "textBoxEditPCName";
            textBoxEditPCName.Size = new Size(293, 30);
            textBoxEditPCName.TabIndex = 3;
            textBoxEditPCName.Leave += textBoxEditPCName_Leave;
            // 
            // textBoxEditDetailInfo
            // 
            textBoxEditDetailInfo.BackColor = Color.FromArgb(26, 28, 55);
            textBoxEditDetailInfo.BorderStyle = BorderStyle.FixedSingle;
            textBoxEditDetailInfo.Font = new Font("Segoe UI", 10F);
            textBoxEditDetailInfo.ForeColor = Color.WhiteSmoke;
            textBoxEditDetailInfo.Location = new Point(200, 154);
            textBoxEditDetailInfo.Margin = new Padding(4, 5, 4, 5);
            textBoxEditDetailInfo.Name = "textBoxEditDetailInfo";
            textBoxEditDetailInfo.Size = new Size(293, 30);
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
            groupBoxAddPC.Location = new Point(13, 15);
            groupBoxAddPC.Margin = new Padding(4, 5, 4, 5);
            groupBoxAddPC.Name = "groupBoxAddPC";
            groupBoxAddPC.Padding = new Padding(4, 5, 4, 5);
            groupBoxAddPC.Size = new Size(516, 231);
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
            buttonClearAddPC.Location = new Point(267, 138);
            buttonClearAddPC.Margin = new Padding(4, 5, 4, 5);
            buttonClearAddPC.Name = "buttonClearAddPC";
            buttonClearAddPC.Size = new Size(160, 62);
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
            buttonAddPC.Location = new Point(80, 138);
            buttonAddPC.Margin = new Padding(4, 5, 4, 5);
            buttonAddPC.Name = "buttonAddPC";
            buttonAddPC.Size = new Size(160, 62);
            buttonAddPC.TabIndex = 3;
            buttonAddPC.Text = "Add";
            buttonAddPC.UseVisualStyleBackColor = false;
            buttonAddPC.Click += buttonAddPC_Click;
            // 
            // labelAddPC
            // 
            labelAddPC.AutoSize = true;
            labelAddPC.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelAddPC.Location = new Point(27, 66);
            labelAddPC.Margin = new Padding(4, 0, 4, 0);
            labelAddPC.Name = "labelAddPC";
            labelAddPC.Size = new Size(116, 23);
            labelAddPC.TabIndex = 1;
            labelAddPC.Text = "Sequence No:";
            // 
            // textBoxSequenceNumber
            // 
            textBoxSequenceNumber.BackColor = Color.FromArgb(26, 28, 55);
            textBoxSequenceNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxSequenceNumber.Font = new Font("Segoe UI", 10F);
            textBoxSequenceNumber.ForeColor = Color.WhiteSmoke;
            textBoxSequenceNumber.Location = new Point(200, 62);
            textBoxSequenceNumber.Margin = new Padding(4, 5, 4, 5);
            textBoxSequenceNumber.Name = "textBoxSequenceNumber";
            textBoxSequenceNumber.Size = new Size(293, 30);
            textBoxSequenceNumber.TabIndex = 2;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(13, 15);
            panelTitle.Margin = new Padding(4, 5, 4, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1681, 92);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(1681, 92);
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
            ClientSize = new Size(1707, 1055);
            Controls.Add(panelMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDashboard";
            Text = "FormDashboard";
            panelMain.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs).EndInit();
            panelControls.ResumeLayout(false);
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
    }
}