using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internet_Cafe_Manager_App.CustomControls;
using Internet_Cafe_Manager_App.Database;

// THÊM 2 DÒNG USING NÀY ĐỂ SỬ DỤNG CLOUDINARY
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class Form_AdminMenu : Form
    {
        private FirebaseDB firebaseDB;

        // BIẾN NÀY SẼ LƯU URL SAU KHI UPLOAD THÀNH CÔNG
        private string uploadedImageUrl = null;
        private string selectedItemId = null;

        // --- THÔNG TIN TÀI KHOẢN CLOUDINARY ---
        private const string CLOUD_NAME = "dbdtxkpmk";
        private const string API_KEY = "543779257993669";
        private const string API_SECRET = "Yh7X2RX2e6ESUrxOOwS2gp-fhig";
        private static Account cloudinaryAccount;
        private static Cloudinary cloudinary;


        public Form_AdminMenu()
        {
            InitializeComponent();
            firebaseDB = new FirebaseDB();

            // KHỞI TẠO TÀI KHOẢN CLOUDINARY
            cloudinaryAccount = new Account(CLOUD_NAME, API_KEY, API_SECRET);
            cloudinary = new Cloudinary(cloudinaryAccount);
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
                // RENDER ẢNH: Tải ảnh trực tiếp từ URL của Cloudinary
                ImageLocation = item.ImageUrl
            };
            // Xử lý nếu URL không hợp lệ hoặc không có ảnh
            pictureBox.LoadCompleted += (s, e) => {
                if (e.Error != null)
                {
                    ((PictureBox)s).Image = null; // hoặc hiển thị ảnh placeholder
                }
            };

            Label quantityLabel = new Label
            {
                Text = $"Còn lại: {item.Quantity}",
                ForeColor = Color.Orange,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 20,
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
                Height = 32,
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
                Height = 26,
                AutoSize = false,
                BackColor = Color.Transparent
            };

            Panel buttonPanel = new Panel { Height = 35, Dock = DockStyle.Bottom, BackColor = Color.Transparent };

            Button btnEdit = new Button { Text = "Edit", Dock = DockStyle.Left, Width = 80, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(0, 123, 255), ForeColor = Color.White };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) =>
            {
                selectedItemId = item.Id;
                txtName.Text = item.Name;
                lstCategory.Text = item.Type;
                txtPrice.Text = item.Price.ToString();
                txtQuantity.Text = item.Quantity.ToString();
                picItemImage.ImageLocation = item.ImageUrl;
                uploadedImageUrl = item.ImageUrl; // Lưu lại URL ảnh hiện tại
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
                        await LoadAllItems();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            };

            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);
            cardPanel.Controls.Add(buttonPanel);
            cardPanel.Controls.Add(priceLabel);
            cardPanel.Controls.Add(nameLabel);
            cardPanel.Controls.Add(quantityLabel);
            cardPanel.Controls.Add(pictureBox);

            return cardPanel;
        }

        /// <summary>
        /// Mở hộp thoại chọn file và UPLOAD ảnh lên Cloudinary.
        /// </summary>
        private async void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị trạng thái đang tải lên
                    btnUploadImage.Enabled = false;
                    btnUploadImage.Text = "Uploading...";

                    try
                    {
                        // Tạo các tham số để tải lên
                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(ofd.FileName),
                            // Tùy chọn: đặt tên file trên Cloudinary (nếu không sẽ tự tạo)
                            PublicId = $"internet_cafe/items/{Path.GetFileNameWithoutExtension(ofd.FileName)}_{DateTime.Now.Ticks}"
                        };

                        // Thực hiện tải lên
                        var uploadResult = await cloudinary.UploadAsync(uploadParams);

                        // Lấy URL an toàn của ảnh sau khi tải lên thành công
                        if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            uploadedImageUrl = uploadResult.SecureUrl.ToString();
                            picItemImage.ImageLocation = uploadedImageUrl; // Hiển thị ảnh vừa upload
                            MessageBox.Show("Tải ảnh lên thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Tải ảnh thất bại: {uploadResult.Error.Message}", "Lỗi Cloudinary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Khôi phục lại trạng thái nút
                        btnUploadImage.Enabled = true;
                        btnUploadImage.Text = "Upload...";
                    }
                }
            }
        }

        /// <summary>
        /// Thêm sản phẩm mới vào Firebase với URL ảnh từ Cloudinary.
        /// </summary>
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(lstCategory.Text) || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Nếu người dùng chưa tải ảnh lên, thì không cho thêm mới
            if (string.IsNullOrEmpty(uploadedImageUrl))
            {
                MessageBox.Show("Vui lòng tải ảnh cho sản phẩm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item newItem = new Item
            {
                Id = Guid.NewGuid().ToString(),
                Name = txtName.Text,
                Type = lstCategory.Text,
                Price = int.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImageUrl = uploadedImageUrl // SỬ DỤNG URL TỪ CLOUDINARY
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

        /// <summary>
        /// Cập nhật sản phẩm với URL ảnh mới (nếu có).
        /// </summary>
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedItemId))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
                return;
            }

            Item updatedItem = new Item
            {
                Id = selectedItemId,
                Name = txtName.Text,
                Type = lstCategory.Text,
                Price = int.Parse(txtPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ImageUrl = uploadedImageUrl // SỬ DỤNG URL MỚI HOẶC CŨ
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            lstCategory.Text = string.Empty;
            txtPrice.Clear();
            txtQuantity.Clear();
            picItemImage.Image = null;
            picItemImage.ImageLocation = null; // Xóa ảnh hiển thị
            uploadedImageUrl = null; // Reset URL đã upload
            selectedItemId = null;
        }

        private void flowLayoutPanelItems_Paint(object sender, PaintEventArgs e)
        {
            // Có thể để trống
        }
    }
}