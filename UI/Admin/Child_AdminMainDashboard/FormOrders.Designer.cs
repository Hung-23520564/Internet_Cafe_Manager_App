// Dán toàn bộ mã này vào tệp Form_AdminMenu.Designer.cs

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class Form_AdminMenu
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
            flowLayoutPanelItems = new FlowLayoutPanel();
            panelCRUD = new Panel();
            lstCategory = new ComboBox();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnUploadImage = new Button();
            picItemImage = new PictureBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            panelCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(flowLayoutPanelItems);
            panelMain.Controls.Add(panelCRUD);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1338, 805);
            panelMain.TabIndex = 0;
            // 
            // flowLayoutPanelItems
            // 
            flowLayoutPanelItems.AutoScroll = true;
            flowLayoutPanelItems.BackColor = Color.FromArgb(26, 28, 55);
            flowLayoutPanelItems.Dock = DockStyle.Fill;
            flowLayoutPanelItems.Location = new Point(0, 0);
            flowLayoutPanelItems.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelItems.Name = "flowLayoutPanelItems";
            flowLayoutPanelItems.Padding = new Padding(20, 25, 20, 25);
            flowLayoutPanelItems.Size = new Size(988, 805);
            flowLayoutPanelItems.TabIndex = 1;
            flowLayoutPanelItems.Paint += flowLayoutPanelItems_Paint;
            // 
            // panelCRUD
            // 
            panelCRUD.BackColor = Color.FromArgb(36, 38, 65);
            panelCRUD.Controls.Add(lstCategory);
            panelCRUD.Controls.Add(txtQuantity);
            panelCRUD.Controls.Add(lblQuantity);
            panelCRUD.Controls.Add(btnClear);
            panelCRUD.Controls.Add(btnDelete);
            panelCRUD.Controls.Add(btnUpdate);
            panelCRUD.Controls.Add(btnAdd);
            panelCRUD.Controls.Add(btnUploadImage);
            panelCRUD.Controls.Add(picItemImage);
            panelCRUD.Controls.Add(txtPrice);
            panelCRUD.Controls.Add(lblPrice);
            panelCRUD.Controls.Add(lblCategory);
            panelCRUD.Controls.Add(txtName);
            panelCRUD.Controls.Add(lblName);
            panelCRUD.Controls.Add(lblTitle);
            panelCRUD.Dock = DockStyle.Right;
            panelCRUD.Location = new Point(988, 0);
            panelCRUD.Margin = new Padding(3, 4, 3, 4);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Padding = new Padding(10, 12, 10, 12);
            panelCRUD.Size = new Size(350, 805);
            panelCRUD.TabIndex = 0;
            // 
            // lstCategory
            // 
            lstCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            lstCategory.FormattingEnabled = true;
            lstCategory.Items.AddRange(new object[] { "Drinks", "Rice", "Fried", "Meal" });
            lstCategory.Location = new Point(110, 135);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new Size(220, 28);
            lstCategory.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(110, 237);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 27);
            txtQuantity.TabIndex = 16;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(20, 237);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(81, 23);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(190, 725);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 50);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(40, 725);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 50);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(190, 650);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 50);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(40, 650);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 50);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(125, 535);
            btnUploadImage.Margin = new Padding(3, 4, 3, 4);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(100, 38);
            btnUploadImage.TabIndex = 10;
            btnUploadImage.Text = "Upload...";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // picItemImage
            // 
            picItemImage.BorderStyle = BorderStyle.FixedSingle;
            picItemImage.Location = new Point(80, 335);
            picItemImage.Margin = new Padding(3, 4, 3, 4);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(200, 187);
            picItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            picItemImage.TabIndex = 9;
            picItemImage.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(110, 186);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 27);
            txtPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(20, 186);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(51, 23);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.White;
            lblCategory.Location = new Point(20, 136);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(85, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 86);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(20, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Product";
            // 
            // Form_AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 805);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_AdminMenu";
            Text = "Admin Menu Management";
            Load += Form_AdminMenu_Load;
            panelMain.ResumeLayout(false);
            panelCRUD.ResumeLayout(false);
            panelCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCRUD;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picItemImage;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private ComboBox lstCategory;
    }
}