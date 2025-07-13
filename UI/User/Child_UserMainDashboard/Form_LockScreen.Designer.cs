namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    partial class Form_LockScreen
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
            panelQRCode = new Panel();
            lblQRInstruction = new Label();
            picQRCode = new PictureBox();
            lblQRTitle = new Label();
            panelActions = new Panel();
            btnConfirmPayment = new Button();
            flowLayoutPanelPackages = new FlowLayoutPanel();
            panelMain.SuspendLayout();
            panelQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelQRCode);
            panelMain.Controls.Add(panelActions);
            panelMain.Controls.Add(flowLayoutPanelPackages);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(1200, 875);
            panelMain.TabIndex = 0;
            // 
            // panelQRCode
            // 
            panelQRCode.Anchor = AnchorStyles.None;
            panelQRCode.BackColor = Color.FromArgb(41, 44, 75);
            panelQRCode.Controls.Add(lblQRInstruction);
            panelQRCode.Controls.Add(picQRCode);
            panelQRCode.Controls.Add(lblQRTitle);
            panelQRCode.Location = new Point(747, 211);
            panelQRCode.Margin = new Padding(3, 4, 3, 4);
            panelQRCode.Name = "panelQRCode";
            panelQRCode.Padding = new Padding(15, 19, 15, 19);
            panelQRCode.Size = new Size(360, 588);
            panelQRCode.TabIndex = 2;
            panelQRCode.Visible = false;
            // 
            // lblQRInstruction
            // 
            lblQRInstruction.Dock = DockStyle.Fill;
            lblQRInstruction.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQRInstruction.ForeColor = Color.Gainsboro;
            lblQRInstruction.Location = new Point(15, 419);
            lblQRInstruction.Name = "lblQRInstruction";
            lblQRInstruction.Padding = new Padding(10, 25, 10, 0);
            lblQRInstruction.Size = new Size(330, 150);
            lblQRInstruction.TabIndex = 2;
            lblQRInstruction.Text = "Nội dung chuyển khoản...";
            lblQRInstruction.TextAlign = ContentAlignment.TopCenter;
            // 
            // picQRCode
            // 
            picQRCode.Dock = DockStyle.Top;
            picQRCode.Location = new Point(15, 69);
            picQRCode.Margin = new Padding(3, 4, 3, 4);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(330, 350);
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQRCode.TabIndex = 1;
            picQRCode.TabStop = false;
            // 
            // lblQRTitle
            // 
            lblQRTitle.Dock = DockStyle.Top;
            lblQRTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQRTitle.ForeColor = Color.White;
            lblQRTitle.Location = new Point(15, 19);
            lblQRTitle.Name = "lblQRTitle";
            lblQRTitle.Size = new Size(330, 50);
            lblQRTitle.TabIndex = 0;
            lblQRTitle.Text = "Quét mã để thanh toán";
            lblQRTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnConfirmPayment);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(20, 750);
            panelActions.Margin = new Padding(3, 4, 3, 4);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1160, 100);
            panelActions.TabIndex = 1;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.Anchor = AnchorStyles.Bottom;
            btnConfirmPayment.BackColor = Color.FromArgb(40, 167, 69);
            btnConfirmPayment.FlatAppearance.BorderSize = 0;
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(787, 21);
            btnConfirmPayment.Margin = new Padding(3, 4, 3, 4);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(250, 62);
            btnConfirmPayment.TabIndex = 0;
            btnConfirmPayment.Text = "Tôi đã chuyển khoản";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Visible = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // flowLayoutPanelPackages
            // 
            flowLayoutPanelPackages.Anchor = AnchorStyles.None;
            flowLayoutPanelPackages.Location = new Point(93, 211);
            flowLayoutPanelPackages.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelPackages.Name = "flowLayoutPanelPackages";
            flowLayoutPanelPackages.Size = new Size(600, 515);
            flowLayoutPanelPackages.TabIndex = 0;
            // 
            // Form_LockScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 55);
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_LockScreen";
            Text = "Lock Screen";
            panelMain.ResumeLayout(false);
            panelQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPackages;
        private System.Windows.Forms.Panel panelQRCode;
        private System.Windows.Forms.Label lblQRInstruction;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label lblQRTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnConfirmPayment;
    }
}