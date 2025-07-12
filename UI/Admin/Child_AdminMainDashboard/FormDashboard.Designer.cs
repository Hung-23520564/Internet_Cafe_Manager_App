// Dán toàn bộ nội dung này vào file: UI/Admin/Child_AdminMainDashboard/FormDashboard.Designer.cs
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
            dataGridViewPCs.AllowUserToAddRows = false;
            dataGridViewPCs.AllowUserToDeleteRows = false;
            dataGridViewPCs.BackgroundColor = Color.FromArgb(36, 38, 65);
            dataGridViewPCs.BorderStyle = BorderStyle.None;
            dataGridViewPCs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPCs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 38, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(41, 44, 80);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPCs.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(41, 44, 100);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPCs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPCs.Dock = DockStyle.Fill;
            dataGridViewPCs.EnableHeadersVisualStyles = false;
            dataGridViewPCs.GridColor = Color.FromArgb(41, 44, 100);
            dataGridViewPCs.Location = new Point(0, 0);
            dataGridViewPCs.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPCs.Name = "dataGridViewPCs";
            dataGridViewPCs.ReadOnly = true;
            dataGridViewPCs.RowHeadersVisible = false;
            dataGridViewPCs.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 28, 55);
            dataGridViewPCs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPCs.RowTemplate.Height = 35;
            dataGridViewPCs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPCs.Size = new Size(850, 801);
            dataGridViewPCs.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(36, 38, 65);
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
            groupBoxEditPC.Size = new Size(386, 475);
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
            comboBoxEditStatus.Size = new Size(201, 31);
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
            textBoxEditSoTien.Size = new Size(201, 30);
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
            txtEditPhoneNumber.Size = new Size(201, 30);
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
            textBoxEditCurrentUser.Size = new Size(201, 30);
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
            textBoxEditPCName.Size = new Size(201, 30);
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
            textBoxEditDetailInfo.Size = new Size(201, 30);
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
            textBoxSequenceNumber.Size = new Size(201, 30);
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
    }
}