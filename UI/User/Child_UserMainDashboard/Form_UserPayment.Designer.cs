namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    partial class Form_UserPayment
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTopUp = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPackages = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTopUpTitle = new System.Windows.Forms.Label();
            this.panelFoodOrder = new System.Windows.Forms.Panel();
            this.lblTotalFoodBill = new System.Windows.Forms.Label();
            this.btnPayFood = new System.Windows.Forms.Button();
            this.dgvFoodOrders = new System.Windows.Forms.DataGridView();
            this.lblFoodOrderTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.panelActions.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelTopUp.SuspendLayout();
            this.panelFoodOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelQRCode);
            this.panelMain.Controls.Add(this.panelActions);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1200, 700);
            this.panelMain.TabIndex = 0;
            // 
            // panelQRCode
            // 
            this.panelQRCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(75)))));
            this.panelQRCode.Controls.Add(this.lblQRInstruction);
            this.panelQRCode.Controls.Add(this.picQRCode);
            this.panelQRCode.Controls.Add(this.lblQRTitle);
            this.panelQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQRCode.Location = new System.Drawing.Point(820, 20);
            this.panelQRCode.Name = "panelQRCode";
            this.panelQRCode.Padding = new System.Windows.Forms.Padding(15);
            this.panelQRCode.Size = new System.Drawing.Size(360, 560);
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
            this.lblQRInstruction.Size = new System.Drawing.Size(330, 210);
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
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.panelActions.Controls.Add(this.btnConfirmPayment);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(20, 580);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1160, 100);
            this.panelActions.TabIndex = 1;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmPayment.FlatAppearance.BorderSize = 0;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(455, 25);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(250, 50);
            this.btnConfirmPayment.TabIndex = 0;
            this.btnConfirmPayment.Text = "Tôi đã chuyển khoản";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Visible = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelTopUp);
            this.panelContent.Controls.Add(this.panelFoodOrder);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContent.Location = new System.Drawing.Point(20, 20);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 660);
            this.panelContent.TabIndex = 0;
            // 
            // panelTopUp
            // 
            this.panelTopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.panelTopUp.Controls.Add(this.flowLayoutPanelPackages);
            this.panelTopUp.Controls.Add(this.lblTopUpTitle);
            this.panelTopUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopUp.Location = new System.Drawing.Point(0, 330);
            this.panelTopUp.Name = "panelTopUp";
            this.panelTopUp.Padding = new System.Windows.Forms.Padding(10);
            this.panelTopUp.Size = new System.Drawing.Size(800, 330);
            this.panelTopUp.TabIndex = 1;
            // 
            // flowLayoutPanelPackages
            // 
            this.flowLayoutPanelPackages.AutoScroll = true;
            this.flowLayoutPanelPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPackages.Location = new System.Drawing.Point(10, 45);
            this.flowLayoutPanelPackages.Name = "flowLayoutPanelPackages";
            this.flowLayoutPanelPackages.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelPackages.Size = new System.Drawing.Size(780, 275);
            this.flowLayoutPanelPackages.TabIndex = 1;
            // 
            // lblTopUpTitle
            // 
            this.lblTopUpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopUpTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTopUpTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopUpTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTopUpTitle.Name = "lblTopUpTitle";
            this.lblTopUpTitle.Size = new System.Drawing.Size(780, 35);
            this.lblTopUpTitle.TabIndex = 0;
            this.lblTopUpTitle.Text = "Mua thêm giờ chơi";
            // 
            // panelFoodOrder
            // 
            this.panelFoodOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.panelFoodOrder.Controls.Add(this.lblTotalFoodBill);
            this.panelFoodOrder.Controls.Add(this.btnPayFood);
            this.panelFoodOrder.Controls.Add(this.dgvFoodOrders);
            this.panelFoodOrder.Controls.Add(this.lblFoodOrderTitle);
            this.panelFoodOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFoodOrder.Location = new System.Drawing.Point(0, 0);
            this.panelFoodOrder.Name = "panelFoodOrder";
            this.panelFoodOrder.Padding = new System.Windows.Forms.Padding(10);
            this.panelFoodOrder.Size = new System.Drawing.Size(800, 330);
            this.panelFoodOrder.TabIndex = 0;
            // 
            // lblTotalFoodBill
            // 
            this.lblTotalFoodBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalFoodBill.AutoSize = true;
            this.lblTotalFoodBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFoodBill.ForeColor = System.Drawing.Color.White;
            this.lblTotalFoodBill.Location = new System.Drawing.Point(15, 290);
            this.lblTotalFoodBill.Name = "lblTotalFoodBill";
            this.lblTotalFoodBill.Size = new System.Drawing.Size(102, 21);
            this.lblTotalFoodBill.TabIndex = 3;
            this.lblTotalFoodBill.Text = "Tổng cộng: ";
            // 
            // btnPayFood
            // 
            this.btnPayFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnPayFood.FlatAppearance.BorderSize = 0;
            this.btnPayFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayFood.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnPayFood.ForeColor = System.Drawing.Color.White;
            this.btnPayFood.Location = new System.Drawing.Point(620, 280);
            this.btnPayFood.Name = "btnPayFood";
            this.btnPayFood.Size = new System.Drawing.Size(170, 40);
            this.btnPayFood.TabIndex = 2;
            this.btnPayFood.Text = "Thanh toán đồ ăn";
            this.btnPayFood.UseVisualStyleBackColor = false;
            this.btnPayFood.Click += new System.EventHandler(this.btnPayFood_Click);
            // 
            // dgvFoodOrders
            // 
            this.dgvFoodOrders.AllowUserToAddRows = false;
            this.dgvFoodOrders.AllowUserToDeleteRows = false;
            this.dgvFoodOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.dgvFoodOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFoodOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFoodOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Định nghĩa style cho tiêu đề
            System.Windows.Forms.DataGridViewCellStyle dgvFoodHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvFoodHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvFoodHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            dgvFoodHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvFoodHeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFoodOrders.ColumnHeadersDefaultCellStyle = dgvFoodHeaderStyle;
            this.dgvFoodOrders.ColumnHeadersHeight = 40;

            // Định nghĩa style cho các ô dữ liệu
            System.Windows.Forms.DataGridViewCellStyle dgvFoodCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvFoodCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            dgvFoodCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvFoodCellStyle.ForeColor = System.Drawing.Color.Gainsboro;
            dgvFoodCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            dgvFoodCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFoodOrders.DefaultCellStyle = dgvFoodCellStyle;

            // Thêm các cột vào bảng
            this.dgvFoodOrders.Columns.Clear();
            this.dgvFoodOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "colItemName", HeaderText = "Tên món", DataPropertyName = "ItemName", FillWeight = 150 },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "colQuantity", HeaderText = "Số lượng", DataPropertyName = "Quantity" },
            new System.Windows.Forms.DataGridViewTextBoxColumn() { Name = "colLineTotal", HeaderText = "Thành tiền", DataPropertyName = "LineTotal", DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle() { Format = "N0" } }
            });

            this.dgvFoodOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFoodOrders.EnableHeadersVisualStyles = false;
            this.dgvFoodOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(100)))));
            this.dgvFoodOrders.Location = new System.Drawing.Point(10, 45);
            this.dgvFoodOrders.Name = "dgvFoodOrders";
            this.dgvFoodOrders.ReadOnly = true;
            this.dgvFoodOrders.RowHeadersVisible = false;
            this.dgvFoodOrders.RowTemplate.Height = 35;
            this.dgvFoodOrders.Size = new System.Drawing.Size(780, 220);
            this.dgvFoodOrders.TabIndex = 1;
            // 
            // lblFoodOrderTitle
            // 
            this.lblFoodOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoodOrderTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodOrderTitle.ForeColor = System.Drawing.Color.White;
            this.lblFoodOrderTitle.Location = new System.Drawing.Point(10, 10);
            this.lblFoodOrderTitle.Name = "lblFoodOrderTitle";
            this.lblFoodOrderTitle.Size = new System.Drawing.Size(780, 35);
            this.lblFoodOrderTitle.TabIndex = 0;
            this.lblFoodOrderTitle.Text = "Hóa đơn đồ ăn chưa thanh toán";
            // 
            // Form_UserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Name = "Form_UserPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Form_UserPayment_Load);
            this.panelMain.ResumeLayout(false);
            this.panelQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelTopUp.ResumeLayout(false);
            this.panelFoodOrder.ResumeLayout(false);
            this.panelFoodOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTopUp;
        private System.Windows.Forms.Panel panelFoodOrder;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelQRCode;
        private System.Windows.Forms.Label lblFoodOrderTitle;
        private System.Windows.Forms.DataGridView dgvFoodOrders;
        private System.Windows.Forms.Button btnPayFood;
        private System.Windows.Forms.Label lblTotalFoodBill;
        private System.Windows.Forms.Label lblTopUpTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPackages;
        private System.Windows.Forms.Label lblQRTitle;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label lblQRInstruction;
        private System.Windows.Forms.Button btnConfirmPayment;
    }
}