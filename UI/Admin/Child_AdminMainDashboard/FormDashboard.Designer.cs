namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class FormDashboard
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

            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelDashBoard = new Label();
            textBoxEditPCName = new TextBox();
            textBoxEditDetailInfo = new TextBox();
            panelInputPC = new Panel();
            buttonEditClear = new Button();
            buttonEditSave = new Button();
            comboBoxEditStatus = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxEditSoTien = new TextBox();
            textBoxEditCurrentUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPCName = new Label();
            dataGridViewPCs = new DataGridView();
            panel1 = new Panel();
            buttonClearAddPC = new Button();
            buttonAddPC = new Button();
            label6 = new Label();
            label5 = new Label();
            textBoxSequenceNumber = new TextBox();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelInputPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDashBoard
            // 
            labelDashBoard.AutoSize = true;
            labelDashBoard.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDashBoard.ForeColor = Color.WhiteSmoke;
            labelDashBoard.Location = new Point(93, 35);
            labelDashBoard.Name = "labelDashBoard";
            labelDashBoard.Size = new Size(346, 70);
            labelDashBoard.TabIndex = 12;
            labelDashBoard.Text = "DashBoard";
            // 
            // textBoxEditPCName
            // 
            textBoxEditPCName.Location = new Point(252, 129);
            textBoxEditPCName.Margin = new Padding(3, 4, 3, 4);
            textBoxEditPCName.Name = "textBoxEditPCName";
            textBoxEditPCName.Size = new Size(229, 27);
            textBoxEditPCName.TabIndex = 1;
            textBoxEditPCName.Leave += textBoxEditPCName_Leave;
            // 
            // textBoxEditDetailInfo
            // 
            textBoxEditDetailInfo.Location = new Point(252, 177);
            textBoxEditDetailInfo.Margin = new Padding(3, 4, 3, 4);
            textBoxEditDetailInfo.Name = "textBoxEditDetailInfo";
            textBoxEditDetailInfo.Size = new Size(229, 27);
            textBoxEditDetailInfo.TabIndex = 3;
            // 
            // panelInputPC
            // 
            panelInputPC.BackColor = Color.FromArgb(34, 33, 74);
            panelInputPC.Controls.Add(buttonEditClear);
            panelInputPC.Controls.Add(buttonEditSave);
            panelInputPC.Controls.Add(comboBoxEditStatus);
            panelInputPC.Controls.Add(label3);
            panelInputPC.Controls.Add(label4);
            panelInputPC.Controls.Add(textBoxEditSoTien);
            panelInputPC.Controls.Add(textBoxEditCurrentUser);
            panelInputPC.Controls.Add(label2);
            panelInputPC.Controls.Add(label1);
            panelInputPC.Controls.Add(textBoxPCName);
            panelInputPC.Controls.Add(labelDashBoard);
            panelInputPC.Controls.Add(textBoxEditPCName);
            panelInputPC.Controls.Add(textBoxEditDetailInfo);
            panelInputPC.Dock = DockStyle.Right;
            panelInputPC.Location = new Point(1158, 0);
            panelInputPC.Margin = new Padding(9, 0, 0, 0);
            panelInputPC.Name = "panelInputPC";
            panelInputPC.Padding = new Padding(9, 11, 9, 11);
            panelInputPC.Size = new Size(512, 893);
            panelInputPC.TabIndex = 16;
            // 
            // buttonEditClear
            // 
            buttonEditClear.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditClear.ForeColor = Color.DarkSlateBlue;
            buttonEditClear.Location = new Point(276, 437);
            buttonEditClear.Name = "buttonEditClear";
            buttonEditClear.Size = new Size(205, 35);
            buttonEditClear.TabIndex = 34;
            buttonEditClear.Text = "Clear";
            buttonEditClear.UseVisualStyleBackColor = true;
            buttonEditClear.Click += buttonEditClear_Click;
            // 
            // buttonEditSave
            // 
            buttonEditSave.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditSave.ForeColor = Color.DarkSlateBlue;
            buttonEditSave.Location = new Point(32, 437);
            buttonEditSave.Name = "buttonEditSave";
            buttonEditSave.Size = new Size(205, 35);
            buttonEditSave.TabIndex = 33;
            buttonEditSave.Text = "Save";
            buttonEditSave.UseVisualStyleBackColor = true;
            buttonEditSave.Click += buttonEditSave_Click;
            // 
            // comboBoxEditStatus
            // 
            comboBoxEditStatus.FormattingEnabled = true;
            comboBoxEditStatus.Location = new Point(252, 275);
            comboBoxEditStatus.Name = "comboBoxEditStatus";
            comboBoxEditStatus.Size = new Size(229, 28);
            comboBoxEditStatus.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(44, 324);
            label3.Name = "label3";
            label3.Size = new Size(71, 22);
            label3.TabIndex = 31;
            label3.Text = "Số tiền ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(44, 227);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 30;
            label4.Text = "Người dùng";
            // 
            // textBoxEditSoTien
            // 
            textBoxEditSoTien.Location = new Point(252, 324);
            textBoxEditSoTien.Margin = new Padding(3, 4, 3, 4);
            textBoxEditSoTien.Name = "textBoxEditSoTien";
            textBoxEditSoTien.Size = new Size(229, 27);
            textBoxEditSoTien.TabIndex = 29;
            // 
            // textBoxEditCurrentUser
            // 
            textBoxEditCurrentUser.Location = new Point(252, 226);
            textBoxEditCurrentUser.Margin = new Padding(3, 4, 3, 4);
            textBoxEditCurrentUser.Name = "textBoxEditCurrentUser";
            textBoxEditCurrentUser.Size = new Size(229, 27);
            textBoxEditCurrentUser.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(44, 275);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 27;
            label2.Text = "Trạng thái ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(44, 178);
            label1.Name = "label1";
            label1.Size = new Size(169, 22);
            label1.TabIndex = 26;
            label1.Text = "Thông tin máy tính";
            // 
            // textBoxPCName
            // 
            textBoxPCName.AutoSize = true;
            textBoxPCName.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPCName.ForeColor = Color.WhiteSmoke;
            textBoxPCName.Location = new Point(44, 129);
            textBoxPCName.Name = "textBoxPCName";
            textBoxPCName.Size = new Size(124, 22);
            textBoxPCName.TabIndex = 21;
            textBoxPCName.Text = "STT của máy ";
            // 
            // dataGridViewPCs
            // 
            dataGridViewPCs.AllowUserToAddRows = false;
            dataGridViewPCs.AllowUserToDeleteRows = false;
            dataGridViewPCs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPCs.BorderStyle = BorderStyle.None;
            dataGridViewPCs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPCs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPCs.Location = new Point(50, 0);
            dataGridViewPCs.Margin = new Padding(0);
            dataGridViewPCs.Name = "dataGridViewPCs";
            dataGridViewPCs.ReadOnly = true;
            dataGridViewPCs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPCs.RowHeadersWidth = 51;
            dataGridViewPCs.RowTemplate.Height = 25;
            dataGridViewPCs.Size = new Size(1108, 688);
            dataGridViewPCs.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 33, 74);
            panel1.Controls.Add(buttonClearAddPC);
            panel1.Controls.Add(buttonAddPC);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxSequenceNumber);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 688);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 205);
            panel1.TabIndex = 17;
            // 
            // buttonClearAddPC
            // 
            buttonClearAddPC.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearAddPC.ForeColor = Color.DarkSlateBlue;
            buttonClearAddPC.Location = new Point(258, 158);
            buttonClearAddPC.Name = "buttonClearAddPC";
            buttonClearAddPC.Size = new Size(162, 35);
            buttonClearAddPC.TabIndex = 37;
            buttonClearAddPC.Text = "Clear";
            buttonClearAddPC.UseVisualStyleBackColor = true;
            buttonClearAddPC.Click += buttonClearAddPC_Click;
            // 
            // buttonAddPC
            // 
            buttonAddPC.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddPC.ForeColor = Color.DarkSlateBlue;
            buttonAddPC.Location = new Point(28, 158);
            buttonAddPC.Name = "buttonAddPC";
            buttonAddPC.Size = new Size(162, 35);
            buttonAddPC.TabIndex = 35;
            buttonAddPC.Text = "Save";
            buttonAddPC.UseVisualStyleBackColor = true;
            buttonAddPC.Click += buttonAddPC_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(58, 102);
            label6.Name = "label6";
            label6.Size = new Size(132, 22);
            label6.TabIndex = 36;
            label6.Text = "Số Thứ Tự Máy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(103, 16);
            label5.Name = "label5";
            label5.Size = new Size(269, 70);
            label5.TabIndex = 35;
            label5.Text = "Add PC ";
            // 
            // textBoxSequenceNumber
            // 
            textBoxSequenceNumber.Location = new Point(266, 102);
            textBoxSequenceNumber.Margin = new Padding(3, 4, 3, 4);
            textBoxSequenceNumber.Name = "textBoxSequenceNumber";
            textBoxSequenceNumber.Size = new Size(154, 27);
            textBoxSequenceNumber.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 33, 74);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(51, 688);
            panel2.TabIndex = 18;
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

            ClientSize = new Size(1670, 893);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelInputPC);
            Controls.Add(dataGridViewPCs);
            Name = "FormDashboard";
            Text = "FormDashboard";
            panelInputPC.ResumeLayout(false);
            panelInputPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPCs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();


            ResumeLayout(false);
        }

        #endregion
        private Label labelDashBoard;
        private Button ekleBtn;
        private Label uyariLbl;
        private Button duzenleBtn;
        private CheckBox yoneticiChk;
        private Button kaldirBtn;
        private TextBox textBoxEditPCName;
        private TextBox textBoxEditDetailInfo;
        private Panel panelInputPC;
        private DataGridView dataGridViewPCs;
        private Label textBoxPCName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxEditSoTien;
        private TextBox textBoxEditCurrentUser;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxEditStatus;
        private Button buttonEditSave;
        private Button buttonEditClear;
        private Button buttonClearAddPC;
        private Button buttonAddPC;
        private Label label6;
        private Label label5;
        private TextBox textBoxSequenceNumber;
        private System.Windows.Forms.Timer timer1;
    }
}