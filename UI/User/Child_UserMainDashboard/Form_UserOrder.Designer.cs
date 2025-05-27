namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    partial class Form_UserOrder
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
            panelTitleBar = new Panel();
            panel1 = new Panel();
            labelCurrentTitle = new Label();
            panelRightActions = new Panel();
            btnViewOrder = new FontAwesome.Sharp.IconButton();
            panelFilters = new Panel();
            flowLayoutPanelItems = new FlowLayoutPanel();
            labelAllItems = new Label();
            panelCartView = new Panel();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            panelRightActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(31, 40, 71);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1688, 87);
            panelTitleBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelCurrentTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1688, 87);
            panel1.TabIndex = 0;
            // 
            // labelCurrentTitle
            // 
            labelCurrentTitle.Anchor = AnchorStyles.None;
            labelCurrentTitle.AutoSize = true;
            labelCurrentTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentTitle.ForeColor = Color.White;
            labelCurrentTitle.Location = new Point(719, 18);
            labelCurrentTitle.Name = "labelCurrentTitle";
            labelCurrentTitle.Size = new Size(248, 54);
            labelCurrentTitle.TabIndex = 0;
            labelCurrentTitle.Text = "Product List";
            // 
            // panelRightActions
            // 
            panelRightActions.BackColor = Color.FromArgb(31, 40, 71);
            panelRightActions.Controls.Add(btnViewOrder);
            panelRightActions.Dock = DockStyle.Right;
            panelRightActions.Location = new Point(1566, 152);
            panelRightActions.Name = "panelRightActions";
            panelRightActions.Size = new Size(122, 788);
            panelRightActions.TabIndex = 2;
            // 
            // btnViewOrder
            // 
            btnViewOrder.FlatAppearance.BorderSize = 0;
            btnViewOrder.FlatStyle = FlatStyle.Flat;
            btnViewOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewOrder.ForeColor = Color.WhiteSmoke;
            btnViewOrder.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnViewOrder.IconColor = Color.WhiteSmoke;
            btnViewOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewOrder.IconSize = 36;
            btnViewOrder.ImageAlign = ContentAlignment.TopCenter;
            btnViewOrder.Location = new Point(0, 0);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Padding = new Padding(0, 8, 0, 8);
            btnViewOrder.Size = new Size(122, 120);
            btnViewOrder.TabIndex = 0;
            btnViewOrder.Text = "View My Order";
            btnViewOrder.TextImageRelation = TextImageRelation.ImageAboveText;
            btnViewOrder.UseVisualStyleBackColor = true;
            // 
            // panelFilters
            // 
            panelFilters.BackColor = Color.FromArgb(24, 25, 59);
            panelFilters.Dock = DockStyle.Top;
            panelFilters.Location = new Point(0, 87);
            panelFilters.Name = "panelFilters";
            panelFilters.Padding = new Padding(15, 8, 15, 8);
            panelFilters.Size = new Size(1688, 65);
            panelFilters.TabIndex = 1;
            // 
            // flowLayoutPanelItems
            // 
            flowLayoutPanelItems.AutoScroll = true;
            flowLayoutPanelItems.BackColor = Color.FromArgb(25, 26, 30);
            flowLayoutPanelItems.Dock = DockStyle.Fill;
            flowLayoutPanelItems.Location = new Point(0, 152);
            flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            flowLayoutPanelItems.Padding = new Padding(20, 55, 20, 20);
            flowLayoutPanelItems.Size = new Size(1048, 788);
            flowLayoutPanelItems.TabIndex = 4;
            // 
            // labelAllItems
            // 
            labelAllItems.AutoSize = true;
            labelAllItems.BackColor = Color.FromArgb(25, 26, 30);
            labelAllItems.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelAllItems.ForeColor = Color.White;
            labelAllItems.Location = new Point(20, 160);
            labelAllItems.Name = "labelAllItems";
            labelAllItems.Padding = new Padding(0, 5, 0, 10);
            labelAllItems.Size = new Size(115, 47);
            labelAllItems.TabIndex = 5;
            labelAllItems.Text = "All Items";
            // 
            // panelCartView
            // 
            panelCartView.BackColor = Color.FromArgb(37, 38, 43);
            panelCartView.Dock = DockStyle.Right;
            panelCartView.Location = new Point(1048, 152);
            panelCartView.Name = "panelCartView";
            panelCartView.Size = new Size(518, 788);
            panelCartView.TabIndex = 3;
            panelCartView.Visible = false;
            // 
            // Form_UserOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 30);
            ClientSize = new Size(1688, 940);
            Controls.Add(labelAllItems);
            Controls.Add(flowLayoutPanelItems);
            Controls.Add(panelCartView);
            Controls.Add(panelRightActions);
            Controls.Add(panelFilters);
            Controls.Add(panelTitleBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form_UserOrder";
            Text = "Products & Cart";
            Load += FormOrders_Load;
            panelTitleBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRightActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelCurrentTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRightActions;
        private FontAwesome.Sharp.IconButton btnViewOrder;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private System.Windows.Forms.Label labelAllItems;
        private System.Windows.Forms.Panel panelCartView;
    }
}