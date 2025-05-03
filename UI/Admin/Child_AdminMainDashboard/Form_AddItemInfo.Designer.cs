namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class Form_AddItemInfo
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
            panel1 = new Panel();
            label1 = new Label();
            iconShop = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 32, 71);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconShop);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(121, 18);
            label1.Name = "label1";
            label1.Size = new Size(161, 34);
            label1.TabIndex = 1;
            label1.Text = "Item Detail";
            // 
            // iconShop
            // 
            iconShop.FlatStyle = FlatStyle.Flat;
            iconShop.IconChar = FontAwesome.Sharp.IconChar.Shop;
            iconShop.IconColor = Color.Gainsboro;
            iconShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconShop.IconSize = 60;
            iconShop.Location = new Point(57, 12);
            iconShop.Name = "iconShop";
            iconShop.Size = new Size(58, 52);
            iconShop.TabIndex = 0;
            iconShop.UseVisualStyleBackColor = true;
            // 
            // Form_AddItemInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form_AddItemInfo";
            Text = "Form_AddItemInfo";
            Load += Form__Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconShop;
        private Label label1;
    }
}