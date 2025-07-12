// Dán toàn bộ mã này vào tệp Form_AdminMenu.cs

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using Internet_Cafe_Manager_App.CustomControls;
using Internet_Cafe_Manager_App.Database;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class Form_AdminMenu : Form
    {
        private FirebaseDB firebaseDB;
        private string selectedImagePath = null;
        private string selectedItemId = null;

        public Form_AdminMenu()
        {
            InitializeComponent();
            firebaseDB = new FirebaseDB();
        }

        private async void Form_AdminMenu_Load(object sender, EventArgs e)
        {
            await LoadAllItems();
        }

        private async Task LoadAllItems()
        {
            flowLayoutPanelItems.Controls.Clear();
            var allItems = await firebaseDB.GetAllItems();
            if (allItems != null && allItems.Any())
            {
                foreach (var item in allItems)
                {
                    Panel itemCard = CreateItemCard(item);
                    flowLayoutPanelItems.Controls.Add(itemCard);
                }
            }
        }

        private Panel CreateItemCard(Item item)
        {
            RoundedPanel cardPanel = new RoundedPanel
            {
                Width = 180,
                Height = 340,
                BackColor = Color.FromArgb(42, 42, 48),
                Margin = new Padding(12),
                Padding = new Padding(8),
                CornerRadius = 15,
                Tag = item
            };

            PictureBox pictureBox = new PictureBox
            {
                Width = cardPanel.Width - cardPanel.Padding.Horizontal - 1,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                ImageLocation = item.Url // Load ảnh từ URL
            };

            Label quantityLabel = new Label
            {
                Text = $"Còn lại: {item.Quantity}",
                ForeColor = Color.Orange,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 20, // Thêm dòng này
                AutoSize = false,
                BackColor = Color.Transparent
            };

            Label nameLabel = new Label
            {
                Text = item.Name,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 32, // thêm
                AutoSize = false,
                AutoEllipsis = true,
                Padding = new Padding(0, 4, 0, 4),
                BackColor = Color.Transparent
            };

            Label priceLabel = new Label
            {
                Text = $"{item.Price:N0} đ",
                ForeColor = Color.PaleGreen,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 26, // thêm
                AutoSize = false,
                BackColor = Color.Transparent
            };


            
            //Label nameLabel = new Label { Text = item.Name, ForeColor = Color.WhiteSmoke, Font = new Font("Segoe UI", 10.5F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Top, Padding = new Padding(0, 6, 0, 3), AutoSize = false, AutoEllipsis = true, Height = 28, BackColor = Color.Transparent };
            //Label priceLabel = new Label { Text = $"{item.Price:N0} đ", ForeColor = Color.PaleGreen, Font = new Font("Segoe UI", 11F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Top, Padding = new Padding(0, 0, 0, 6), BackColor = Color.Transparent };

            Panel buttonPanel = new Panel { Height = 35, Dock = DockStyle.Bottom, BackColor = Color.Transparent };

            Button btnEdit = new Button { Text = "Edit", Dock = DockStyle.Left, Width = 80, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(0, 123, 255), ForeColor = Color.White };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) =>
            {
                selectedItemId = item.Id;
                //txtId.Text = item.Id;
                txtName.Text = item.Name;
                lstCategory.Text = item.Type;
                txtPrice.Text = item.Price.ToString();
                txtQuantity.Text = item.Quantity.ToString();
                picItemImage.ImageLocation = item.Url;
                selectedImagePath = null; // Reset image path
            };

            Button btnDelete = new Button { Text = "Delete", Dock = DockStyle.Right, Width = 80, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += async (s, e) =>
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa '{item.Name}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool success = await firebaseDB.DeleteItem(item.Id);
                    if (success)
                    {
                        MessageBox.Show("Xóa thành công!");
                        await LoadAllItems(); // Tải lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            };

            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);
            cardPanel.Controls.Add(buttonPanel);     // Bottom
            cardPanel.Controls.Add(priceLabel);      // Dưới tên
            cardPanel.Controls.Add(nameLabel);       // Trên giá
            cardPanel.Controls.Add(quantityLabel);   // Trên tên
            cardPanel.Controls.Add(pictureBox);      // Trên cùng


            return cardPanel;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    picItemImage.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtName.Text) ||
            string.IsNullOrEmpty(txtPrice.Text) ||
            string.IsNullOrEmpty(lstCategory.Text) ||
            string.IsNullOrEmpty(txtQuantity.Text))

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string imageUrl = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                // Upload ảnh và lấy URL (chưa được triển khai trong FirebaseDB.cs)
                // Giả sử bạn có một phương thức để làm điều này
                // imageUrl = await firebaseDB.UploadImage(selectedImagePath);
                // Vì chưa có, chúng ta sẽ tạm thời bỏ qua bước này
                MessageBox.Show("Chức năng Upload ảnh chưa được hỗ trợ trong FirebaseDB.cs.");
            }

            Item newItem = new Item
            {
                //Id = string.IsNullOrEmpty(txtId.Text) ? Guid.NewGuid().ToString() : txtId.Text,
                Id = Guid.NewGuid().ToString(),
                Name = txtName.Text,
                Type = lstCategory.Text,
                Price = int.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Url = imageUrl // Sẽ là null nếu chưa upload
            };

            bool success = await firebaseDB.AddOrUpdateItem(newItem);
            if (success)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                await LoadAllItems();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemId))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
                return;
            }

            string imageUrl = picItemImage.ImageLocation;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Chức năng Upload ảnh chưa được hỗ trợ trong FirebaseDB.cs.");
                // imageUrl = await firebaseDB.UploadImage(selectedImagePath);
            }

            Item updatedItem = new Item
            {
                Id = selectedItemId,
                Name = txtName.Text,
                Type = lstCategory.Text,
                Price = int.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Url = imageUrl
            };

            bool success = await firebaseDB.AddOrUpdateItem(updatedItem);
            if (success)
            {
                MessageBox.Show("Cập nhật thành công!");
                await LoadAllItems();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemId))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = await firebaseDB.DeleteItem(selectedItemId);
                if (success)
                {
                    MessageBox.Show("Xóa thành công!");
                    await LoadAllItems();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            //txtId.Clear();
            txtName.Clear();
            lstCategory.Text = string.Empty;
            txtPrice.Clear();
            picItemImage.Image = null;
            selectedImagePath = null;
            selectedItemId = null;
        }

        private void flowLayoutPanelItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}