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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.dataGridViewPCs = new System.Windows.Forms.DataGridView();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBoxEditPC = new System.Windows.Forms.GroupBox();
            this.buttonEditClear = new System.Windows.Forms.Button();
            this.buttonEditSave = new System.Windows.Forms.Button();
            this.comboBoxEditStatus = new System.Windows.Forms.ComboBox();
            this.labelEditStatus = new System.Windows.Forms.Label();
            this.labelEditBudget = new System.Windows.Forms.Label();
            this.textBoxEditSoTien = new System.Windows.Forms.TextBox();
            this.textBoxEditCurrentUser = new System.Windows.Forms.TextBox();
            this.labelEditUser = new System.Windows.Forms.Label();
            this.labelEditDetails = new System.Windows.Forms.Label();
            this.labelEditName = new System.Windows.Forms.Label();
            this.textBoxEditPCName = new System.Windows.Forms.TextBox();
            this.textBoxEditDetailInfo = new System.Windows.Forms.TextBox();
            this.groupBoxAddPC = new System.Windows.Forms.GroupBox();
            this.buttonClearAddPC = new System.Windows.Forms.Button();
            this.buttonAddPC = new System.Windows.Forms.Button();
            this.labelAddPC = new System.Windows.Forms.Label();
            this.textBoxSequenceNumber = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPCs)).BeginInit();
            this.panelControls.SuspendLayout();
            this.groupBoxEditPC.SuspendLayout();
            this.groupBoxAddPC.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.panelMain.Controls.Add(this.splitContainerMain);
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 70);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.dataGridViewPCs);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelControls);
            this.splitContainerMain.Size = new System.Drawing.Size(1260, 640);
            this.splitContainerMain.SplitterDistance = 850;
            this.splitContainerMain.TabIndex = 1;
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
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.panelControls.Controls.Add(this.groupBoxEditPC);
            this.panelControls.Controls.Add(this.groupBoxAddPC);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(10);
            this.panelControls.Size = new System.Drawing.Size(406, 640);
            this.panelControls.TabIndex = 0;
            // 
            // groupBoxEditPC
            // 
            this.groupBoxEditPC.Controls.Add(this.buttonEditClear);
            this.groupBoxEditPC.Controls.Add(this.buttonEditSave);
            this.groupBoxEditPC.Controls.Add(this.comboBoxEditStatus);
            this.groupBoxEditPC.Controls.Add(this.labelEditStatus);
            this.groupBoxEditPC.Controls.Add(this.labelEditBudget);
            this.groupBoxEditPC.Controls.Add(this.textBoxEditSoTien);
            this.groupBoxEditPC.Controls.Add(this.textBoxEditCurrentUser);
            this.groupBoxEditPC.Controls.Add(this.labelEditUser);
            this.groupBoxEditPC.Controls.Add(this.labelEditDetails);
            this.groupBoxEditPC.Controls.Add(this.labelEditName);
            this.groupBoxEditPC.Controls.Add(this.textBoxEditPCName);
            this.groupBoxEditPC.Controls.Add(this.textBoxEditDetailInfo);
            this.groupBoxEditPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxEditPC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEditPC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEditPC.Location = new System.Drawing.Point(10, 160);
            this.groupBoxEditPC.Name = "groupBoxEditPC";
            this.groupBoxEditPC.Size = new System.Drawing.Size(386, 380);
            this.groupBoxEditPC.TabIndex = 1;
            this.groupBoxEditPC.TabStop = false;
            this.groupBoxEditPC.Text = "Edit Selected PC";
            // 
            // buttonEditClear
            // 
            this.buttonEditClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonEditClear.FlatAppearance.BorderSize = 0;
            this.buttonEditClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditClear.Location = new System.Drawing.Point(200, 310);
            this.buttonEditClear.Name = "buttonEditClear";
            this.buttonEditClear.Size = new System.Drawing.Size(120, 40);
            this.buttonEditClear.TabIndex = 12;
            this.buttonEditClear.Text = "Clear";
            this.buttonEditClear.UseVisualStyleBackColor = false;
            this.buttonEditClear.Click += new System.EventHandler(this.buttonEditClear_Click);
            // 
            // buttonEditSave
            // 
            this.buttonEditSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.buttonEditSave.FlatAppearance.BorderSize = 0;
            this.buttonEditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEditSave.Location = new System.Drawing.Point(60, 310);
            this.buttonEditSave.Name = "buttonEditSave";
            this.buttonEditSave.Size = new System.Drawing.Size(120, 40);
            this.buttonEditSave.TabIndex = 11;
            this.buttonEditSave.Text = "Save";
            this.buttonEditSave.UseVisualStyleBackColor = false;
            this.buttonEditSave.Click += new System.EventHandler(this.buttonEditSave_Click);
            // 
            // comboBoxEditStatus
            // 
            this.comboBoxEditStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.comboBoxEditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEditStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEditStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxEditStatus.FormattingEnabled = true;
            this.comboBoxEditStatus.Location = new System.Drawing.Point(150, 200);
            this.comboBoxEditStatus.Name = "comboBoxEditStatus";
            this.comboBoxEditStatus.Size = new System.Drawing.Size(220, 25);
            this.comboBoxEditStatus.TabIndex = 9;
            // 
            // labelEditStatus
            // 
            this.labelEditStatus.AutoSize = true;
            this.labelEditStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEditStatus.Location = new System.Drawing.Point(20, 203);
            this.labelEditStatus.Name = "labelEditStatus";
            this.labelEditStatus.Size = new System.Drawing.Size(49, 19);
            this.labelEditStatus.TabIndex = 8;
            this.labelEditStatus.Text = "Status:";
            // 
            // labelEditBudget
            // 
            this.labelEditBudget.AutoSize = true;
            this.labelEditBudget.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEditBudget.Location = new System.Drawing.Point(20, 253);
            this.labelEditBudget.Name = "labelEditBudget";
            this.labelEditBudget.Size = new System.Drawing.Size(58, 19);
            this.labelEditBudget.TabIndex = 10;
            this.labelEditBudget.Text = "Budget:";
            // 
            // textBoxEditSoTien
            // 
            this.textBoxEditSoTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.textBoxEditSoTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditSoTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEditSoTien.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEditSoTien.Location = new System.Drawing.Point(150, 250);
            this.textBoxEditSoTien.Name = "textBoxEditSoTien";
            this.textBoxEditSoTien.Size = new System.Drawing.Size(220, 25);
            this.textBoxEditSoTien.TabIndex = 10;
            // 
            // textBoxEditCurrentUser
            // 
            this.textBoxEditCurrentUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.textBoxEditCurrentUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditCurrentUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEditCurrentUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEditCurrentUser.Location = new System.Drawing.Point(150, 150);
            this.textBoxEditCurrentUser.Name = "textBoxEditCurrentUser";
            this.textBoxEditCurrentUser.Size = new System.Drawing.Size(220, 25);
            this.textBoxEditCurrentUser.TabIndex = 7;
            // 
            // labelEditUser
            // 
            this.labelEditUser.AutoSize = true;
            this.labelEditUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEditUser.Location = new System.Drawing.Point(20, 153);
            this.labelEditUser.Name = "labelEditUser";
            this.labelEditUser.Size = new System.Drawing.Size(91, 19);
            this.labelEditUser.TabIndex = 6;
            this.labelEditUser.Text = "Current User:";
            // 
            // labelEditDetails
            // 
            this.labelEditDetails.AutoSize = true;
            this.labelEditDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEditDetails.Location = new System.Drawing.Point(20, 103);
            this.labelEditDetails.Name = "labelEditDetails";
            this.labelEditDetails.Size = new System.Drawing.Size(84, 19);
            this.labelEditDetails.TabIndex = 4;
            this.labelEditDetails.Text = "Detail Info:";
            // 
            // labelEditName
            // 
            this.labelEditName.AutoSize = true;
            this.labelEditName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelEditName.Location = new System.Drawing.Point(20, 53);
            this.labelEditName.Name = "labelEditName";
            this.labelEditName.Size = new System.Drawing.Size(124, 19);
            this.labelEditName.TabIndex = 2;
            this.labelEditName.Text = "PC Sequence No.:";
            // 
            // textBoxEditPCName
            // 
            this.textBoxEditPCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.textBoxEditPCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditPCName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEditPCName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEditPCName.Location = new System.Drawing.Point(150, 50);
            this.textBoxEditPCName.Name = "textBoxEditPCName";
            this.textBoxEditPCName.Size = new System.Drawing.Size(220, 25);
            this.textBoxEditPCName.TabIndex = 3;
            this.textBoxEditPCName.Leave += new System.EventHandler(this.textBoxEditPCName_Leave);
            // 
            // textBoxEditDetailInfo
            // 
            this.textBoxEditDetailInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.textBoxEditDetailInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEditDetailInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxEditDetailInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxEditDetailInfo.Location = new System.Drawing.Point(150, 100);
            this.textBoxEditDetailInfo.Name = "textBoxEditDetailInfo";
            this.textBoxEditDetailInfo.Size = new System.Drawing.Size(220, 25);
            this.textBoxEditDetailInfo.TabIndex = 5;
            // 
            // groupBoxAddPC
            // 
            this.groupBoxAddPC.Controls.Add(this.buttonClearAddPC);
            this.groupBoxAddPC.Controls.Add(this.buttonAddPC);
            this.groupBoxAddPC.Controls.Add(this.labelAddPC);
            this.groupBoxAddPC.Controls.Add(this.textBoxSequenceNumber);
            this.groupBoxAddPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAddPC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxAddPC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxAddPC.Location = new System.Drawing.Point(10, 10);
            this.groupBoxAddPC.Name = "groupBoxAddPC";
            this.groupBoxAddPC.Size = new System.Drawing.Size(386, 150);
            this.groupBoxAddPC.TabIndex = 0;
            this.groupBoxAddPC.TabStop = false;
            this.groupBoxAddPC.Text = "Add New PC";
            // 
            // buttonClearAddPC
            // 
            this.buttonClearAddPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonClearAddPC.FlatAppearance.BorderSize = 0;
            this.buttonClearAddPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearAddPC.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClearAddPC.Location = new System.Drawing.Point(200, 90);
            this.buttonClearAddPC.Name = "buttonClearAddPC";
            this.buttonClearAddPC.Size = new System.Drawing.Size(120, 40);
            this.buttonClearAddPC.TabIndex = 4;
            this.buttonClearAddPC.Text = "Clear";
            this.buttonClearAddPC.UseVisualStyleBackColor = false;
            this.buttonClearAddPC.Click += new System.EventHandler(this.buttonClearAddPC_Click);
            // 
            // buttonAddPC
            // 
            this.buttonAddPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.buttonAddPC.FlatAppearance.BorderSize = 0;
            this.buttonAddPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPC.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddPC.Location = new System.Drawing.Point(60, 90);
            this.buttonAddPC.Name = "buttonAddPC";
            this.buttonAddPC.Size = new System.Drawing.Size(120, 40);
            this.buttonAddPC.TabIndex = 3;
            this.buttonAddPC.Text = "Add";
            this.buttonAddPC.UseVisualStyleBackColor = false;
            this.buttonAddPC.Click += new System.EventHandler(this.buttonAddPC_Click);
            // 
            // labelAddPC
            // 
            this.labelAddPC.AutoSize = true;
            this.labelAddPC.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelAddPC.Location = new System.Drawing.Point(20, 43);
            this.labelAddPC.Name = "labelAddPC";
            this.labelAddPC.Size = new System.Drawing.Size(95, 19);
            this.labelAddPC.TabIndex = 1;
            this.labelAddPC.Text = "Sequence No:";
            // 
            // textBoxSequenceNumber
            // 
            this.textBoxSequenceNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.textBoxSequenceNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSequenceNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSequenceNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSequenceNumber.Location = new System.Drawing.Point(150, 40);
            this.textBoxSequenceNumber.Name = "textBoxSequenceNumber";
            this.textBoxSequenceNumber.Size = new System.Drawing.Size(220, 25);
            this.textBoxSequenceNumber.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(10, 10);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1260, 60);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1260, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PC Dashboard";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPCs)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.groupBoxEditPC.ResumeLayout(false);
            this.groupBoxEditPC.PerformLayout();
            this.groupBoxAddPC.ResumeLayout(false);
            this.groupBoxAddPC.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

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