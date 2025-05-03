namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class FormOrders
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
            panelTitleBar = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnAddItem = new FontAwesome.Sharp.IconButton();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(249, 118, 176);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1118, 87);
            panelTitleBar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 40, 71);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 87);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(380, 6);
            label2.Name = "label2";
            label2.Size = new Size(320, 64);
            label2.TabIndex = 3;
            label2.Text = "Product List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 64);
            label1.TabIndex = 3;
            label1.Text = "Product List";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 40, 71);
            panel2.Controls.Add(btnAddItem);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(996, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 606);
            panel2.TabIndex = 3;
            // 
            // btnAddItem
            // 
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            btnAddItem.IconColor = Color.White;
            btnAddItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddItem.ImageAlign = ContentAlignment.BottomCenter;
            btnAddItem.Location = new Point(0, 176);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(128, 199);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add Item";
            btnAddItem.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 693);
            Controls.Add(panel2);
            Controls.Add(panelTitleBar);
            Name = "FormOrders";
            Text = "FormOrders";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddItem;
    }
}