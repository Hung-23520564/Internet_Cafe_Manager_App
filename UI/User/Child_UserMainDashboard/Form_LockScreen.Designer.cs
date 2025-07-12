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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelQRCode = new System.Windows.Forms.Panel();
            this.lblQRInstruction = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.lblQRTitle = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.flowLayoutPanelPackages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelQRCode);
            this.panelMain.Controls.Add(this.panelActions);
            this.panelMain.Controls.Add(this.flowLayoutPanelPackages);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1200, 700);
            this.panelMain.TabIndex = 0;
            // 
            // panelQRCode
            // 
            this.panelQRCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(75)))));
            this.panelQRCode.Controls.Add(this.lblQRInstruction);
            this.panelQRCode.Controls.Add(this.picQRCode);
            this.panelQRCode.Controls.Add(this.lblQRTitle);
            this.panelQRCode.Location = new System.Drawing.Point(747, 169);
            this.panelQRCode.Name = "panelQRCode";
            this.panelQRCode.Padding = new System.Windows.Forms.Padding(15);
            this.panelQRCode.Size = new System.Drawing.Size(360, 470);
            this.panelQRCode.TabIndex = 2;
            this.panelQRCode.Visible = false;
            // 
            // lblQRInstruction
            // 
            this.lblQRInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQRInstruction.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRInstruction.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblQRInstruction.Location = new System.Drawing.Point(15, 335);
            this.lblQRInstruction.Name = "lblQRInstruction";
            this.lblQRInstruction.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.lblQRInstruction.Size = new System.Drawing.Size(330, 120);
            this.lblQRInstruction.TabIndex = 2;
            this.lblQRInstruction.Text = "Nội dung chuyển khoản...";
            this.lblQRInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picQRCode
            // 
            this.picQRCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.picQRCode.Location = new System.Drawing.Point(15, 55);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(330, 280);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 1;
            this.picQRCode.TabStop = false;
            // 
            // lblQRTitle
            // 
            this.lblQRTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQRTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRTitle.ForeColor = System.Drawing.Color.White;
            this.lblQRTitle.Location = new System.Drawing.Point(15, 15);
            this.lblQRTitle.Name = "lblQRTitle";
            this.lblQRTitle.Size = new System.Drawing.Size(330, 40);
            this.lblQRTitle.TabIndex = 0;
            this.lblQRTitle.Text = "Quét mã để thanh toán";
            this.lblQRTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnConfirmPayment);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(20, 600);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1160, 80);
            this.panelActions.TabIndex = 1;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmPayment.FlatAppearance.BorderSize = 0;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(825, 15);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(250, 50);
            this.btnConfirmPayment.TabIndex = 0;
            this.btnConfirmPayment.Text = "Tôi đã chuyển khoản";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Visible = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // flowLayoutPanelPackages
            // 
            this.flowLayoutPanelPackages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelPackages.Location = new System.Drawing.Point(93, 169);
            this.flowLayoutPanelPackages.Name = "flowLayoutPanelPackages";
            this.flowLayoutPanelPackages.Size = new System.Drawing.Size(600, 300);
            this.flowLayoutPanelPackages.TabIndex = 0;
            // 
            // Form_LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Name = "Form_LockScreen";
            this.Text = "Lock Screen";
            this.panelMain.ResumeLayout(false);
            this.panelQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

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