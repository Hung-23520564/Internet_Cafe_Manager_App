using FontAwesome.Sharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.IO;
using Internet_Cafe_Manager_App.Database;
using Internet_Cafe_Manager_App.UI.Admin;
using Internet_Cafe_Manager_App.UI.User;
using Internet_Cafe_Manager_App.CustomControls;
using System.Runtime.CompilerServices;


namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{

    public partial class Form_UserOrder : Form
    {
        private List<ItemData> allSampleItems = new List<ItemData>();
        private Button currentFilterButton = null;
        private Color activeFilterButtonColor = Color.FromArgb(239, 79, 45);
        private Color inactiveFilterButtonColor = Color.FromArgb(55, 58, 64);

        private List<CartItemEntry> shoppingCart = new List<CartItemEntry>();
        private FlowLayoutPanel flowLayoutPanelCartItemsDisplay;
        private Label lblGrandTotal;
        private Label lblCartTitle;
        private Button btnCheckout;
        private IconButton btnCloseCart;
        private readonly Internet_Cafe_Manager_App.Database.Users loggedInUser;

        public Form_UserOrder()
        {
            InitializeComponent();
            InitializeCartPanelUI();
            // Đảm bảo labelAllItems ở trên cùng nếu nó được thêm vào Form.Controls
            // và không phải là con của flowLayoutPanelItems
            if (this.Controls.Contains(this.labelAllItems))
            {
                this.labelAllItems.BringToFront();
            }
        }

        public Form_UserOrder(Internet_Cafe_Manager_App.Database.Users user)
        {
            InitializeComponent();
            this.loggedInUser = user; // Lưu lại người dùng để sử dụng sau
            InitializeCartPanelUI();
        }

        private void InitializeCartPanelUI() // Giữ nguyên như lần trước
        {
            panelCartView.Padding = new Padding(10);
            btnCloseCart = new IconButton
            {
                IconChar = IconChar.Times,
                IconColor = Color.WhiteSmoke,
                IconSize = 20,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(28, 28),
                // Điều chỉnh Location của btnCloseCart dựa trên ClientSize của panelCartView để chính xác hơn
                Location = new Point(panelCartView.ClientSize.Width - 28 - 3, 3), // 3 là padding nhỏ
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };
            // ... (phần còn lại của InitializeCartPanelUI giữ nguyên) ...
            btnCloseCart.FlatAppearance.BorderSize = 0;
            btnCloseCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            btnCloseCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            btnCloseCart.Click += BtnCloseCart_Click;
            panelCartView.Controls.Add(btnCloseCart);
            btnCloseCart.BringToFront();

            lblCartTitle = new Label
            {
                Text = "My Cart",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 40,
            };
            panelCartView.Controls.Add(lblCartTitle);
            lblCartTitle.SendToBack();

            flowLayoutPanelCartItemsDisplay = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = panelCartView.BackColor
            };
            panelCartView.Controls.Add(flowLayoutPanelCartItemsDisplay);
            flowLayoutPanelCartItemsDisplay.BringToFront();

            Panel bottomCartPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 100,
                BackColor = panelCartView.BackColor
            };

            lblGrandTotal = new Label
            {
                Text = "Total: 0",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 10, 5),
                Height = 40
            };
            bottomCartPanel.Controls.Add(lblGrandTotal);

            btnCheckout = new Button
            {
                Text = "Start Bill",
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.FromArgb(30, 180, 30),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold)
            };
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.Click += BtnCheckout_Click;
            bottomCartPanel.Controls.Add(btnCheckout);

            panelCartView.Controls.Add(bottomCartPanel);
            bottomCartPanel.BringToFront();
        }

        private void BtnCloseCart_Click(object sender, EventArgs e)
        {
            panelCartView.Visible = false;
            AdjustLayoutForCart();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            this.Text = "Products & Cart";
            // Căn giữa labelCurrentTitle sau khi panel1 có kích thước
            panel1.Layout += (s, ev) => {
                if (panel1.Width > 0 && labelCurrentTitle.Width > 0)
                { // Kiểm tra để tránh lỗi chia cho 0
                    labelCurrentTitle.Location = new Point((panel1.Width - labelCurrentTitle.Width) / 2, (panel1.Height - labelCurrentTitle.Height) / 2);
                }
            };
            // Kích hoạt layout một lần để căn giữa ban đầu nếu kích thước đã có
            if (panel1.Width > 0 && labelCurrentTitle.Width > 0)
            {
                labelCurrentTitle.Location = new Point((panel1.Width - labelCurrentTitle.Width) / 2, (panel1.Height - labelCurrentTitle.Height) / 2);
            }


            btnViewOrder.Text = "View My Order";
            btnViewOrder.IconChar = IconChar.ShoppingCart;
            btnViewOrder.Click -= btnViewOrder_Click;
            btnViewOrder.Click += btnViewOrder_Click;
            LoadCategoryFilters();
            LoadSampleItems();
            DisplayItems(allSampleItems);
            var allButton = panelFilters.Controls.OfType<FlowLayoutPanel>().FirstOrDefault()?.Controls.OfType<Button>().FirstOrDefault(b => b.Tag?.ToString() == "All");
            if (allButton != null)
            {
                ActivateFilterButton(allButton);
            }
            // Initial layout adjustment
            AdjustLayoutForCart();
        }

        private void AdjustLayoutForCart()
        {
            // Chỉ cần ẩn/hiện panel và gọi PerformLayout để Docking tự xử lý
            if (panelCartView.Visible)
            {
                panelRightActions.Visible = false;
            }
            else
            {
                panelRightActions.Visible = true;
            }
            // Buộc Form và các control con tính toán lại layout
            this.PerformLayout();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            panelCartView.Visible = !panelCartView.Visible;
            if (panelCartView.Visible)
            {
                RefreshCartOnScreen();
                panelCartView.BringToFront();
            }
            AdjustLayoutForCart();
        }

        private void LoadCategoryFilters() // Giữ nguyên như lần trước
        {
            panelFilters.Controls.Clear();
            string[] categories = { "All", "Rice", "Fried", "Drinks", "Meal" };
            int buttonWidth = 90;
            int buttonHeight = 38;
            int spacing = 8;
            FlowLayoutPanel filterFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(0),
                WrapContents = false,
                BackColor = Color.Transparent
            };
            // Căn giữa các button trong panelFilters động hơn
            panelFilters.Layout += (s, ev) => {
                if (panelFilters.Width > 0)
                { // Chỉ tính toán khi Width > 0
                    filterFlowPanel.Padding = new Padding(
                        Math.Max(0, (panelFilters.Width - (categories.Length * buttonWidth + (categories.Length - 1) * spacing)) / 2),
                        (panelFilters.Height - buttonHeight) / 2,
                        0,
                        0);
                }
            };
            // Kích hoạt một lần để căn giữa ban đầu
            if (panelFilters.Width > 0)
            {
                filterFlowPanel.Padding = new Padding(
                   Math.Max(0, (panelFilters.Width - (categories.Length * buttonWidth + (categories.Length - 1) * spacing)) / 2),
                   (panelFilters.Height - buttonHeight) / 2,
                   0,
                   0);
            }

            for (int i = 0; i < categories.Length; i++)
            {
                Button filterButton = new Button
                {
                    Text = categories[i],
                    Size = new Size(buttonWidth, buttonHeight),
                    Margin = new Padding(0, 0, spacing, 0),
                    ForeColor = Color.WhiteSmoke,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI Semibold", 9.5F),
                    Cursor = Cursors.Hand,
                    Tag = categories[i],
                    BackColor = inactiveFilterButtonColor
                };
                filterButton.FlatAppearance.BorderSize = 0;
                filterButton.Click += FilterButton_Click;
                filterFlowPanel.Controls.Add(filterButton);
            }
            panelFilters.Controls.Add(filterFlowPanel);
        }

        // ... (Các hàm còn lại: ActivateFilterButton, FilterButton_Click, LoadSampleItems, DisplayItems, CreateItemCard, LoadItemImage, AddToCart_Click, RefreshCartOnScreen, CreateCartItemPanel, BtnCartItemIncrement_Click, BtnCartItemDecrement_Click, BtnCartItemRemove_Click, BtnCheckout_Click giữ nguyên như phiên bản đã sửa nút +/- và xóa item)
        // ... (Class ItemData giữ nguyên) ...
        // Copy các hàm này từ phiên bản trước vào đây
        private void ActivateFilterButton(Button activeButton)
        {
            if (currentFilterButton != null)
            {
                currentFilterButton.BackColor = inactiveFilterButtonColor;
            }
            currentFilterButton = activeButton;
            currentFilterButton.BackColor = activeFilterButtonColor;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                ActivateFilterButton(clickedButton);
                string category = clickedButton.Tag.ToString();
                if (category == "All")
                {
                    DisplayItems(allSampleItems);
                }
                else
                {
                    var filteredItems = allSampleItems.Where(item =>
                        (item.Category != null && item.Category.Equals(category, StringComparison.OrdinalIgnoreCase)) ||
                        (item.Name != null && item.Name.ToLower().Contains(category.ToLower()))
                    ).ToList();
                    DisplayItems(filteredItems);
                }
            }
        }

        private void LoadSampleItems()
        {
            allSampleItems.Clear();
 
            allSampleItems.Add(new ItemData { Name = "7up Cane", Description = "Cool and crisp", Price = "10000", ImagePath = "images/7up_cane.png", Category = "Drinks" });
            allSampleItems.Add(new ItemData { Name = "Salad", Description = "Fresh and green", Price = "15000", ImagePath = "images/salad.png", Category = "Meal" });
            allSampleItems.Add(new ItemData { Name = "Egg with Bread", Description = "Classic breakfast", Price = "20000", ImagePath = "images/egg_with_bread.png", Category = "Meal" });
            allSampleItems.Add(new ItemData { Name = "Soup", Description = "Warm and comforting", Price = "22000", ImagePath = "images/soup.png", Category = "Meal" });
        }

        private void DisplayItems(List<ItemData> itemsToDisplay)
        {
            flowLayoutPanelItems.Controls.Clear();
            if (!itemsToDisplay.Any())
            {
                Label noItemsLabel = new Label
                {
                    Text = "No items found for this category.",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 12F),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0, flowLayoutPanelItems.Height / 3, 0, 0)
                };
                flowLayoutPanelItems.Controls.Add(noItemsLabel);
                return;
            }
            foreach (var itemData in itemsToDisplay)
            {
                Panel itemCard = CreateItemCard(itemData);
                flowLayoutPanelItems.Controls.Add(itemCard);
            }
        }

        private Panel CreateItemCard(ItemData itemData) // Hàm này trả về Panel, nhưng chúng ta tạo RoundedPanel
        {
            // Thay vì Panel, sử dụng RoundedPanel
            RoundedPanel cardPanel = new RoundedPanel // THAY ĐỔI Ở ĐÂY
            {
                Width = 175,
                Height = 270,
                // BackColor đã được đặt mặc định trong RoundedPanel, nhưng bạn có thể ghi đè ở đây nếu muốn
                // BackColor = Color.FromArgb(42, 42, 48), 
                Margin = new Padding(12),
                Padding = new Padding(8),
                CornerRadius = 15 // Đặt bán kính bo góc mong muốn (ví dụ: 15)
            };

            PictureBox pictureBox = new PictureBox { Width = cardPanel.Width - cardPanel.Padding.Horizontal - 1, Height = 110, SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Top, Image = LoadItemImage(itemData.ImagePath) };
            


            Label nameLabel = new Label
            {
                Text = itemData.Name,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top, // Sẽ nằm dưới PictureBox
                Padding = new Padding(0, 6, 0, 3),
                AutoSize = false,
                AutoEllipsis = true,
                Height = 28,
                // Làm cho nền của Label trong suốt để thấy nền bo tròn của RoundedPanel
                BackColor = Color.Transparent
            };

            Label descriptionLabel = new Label
            {
                Text = itemData.Description,
                ForeColor = Color.FromArgb(180, 180, 180),
                Font = new Font("Segoe UI", 7.5F),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top, // Sẽ nằm dưới nameLabel
                Padding = new Padding(0, 0, 0, 6),
                AutoSize = false,
                AutoEllipsis = true,
                Height = 36,
                BackColor = Color.Transparent // Nền trong suốt
            };

            Panel bottomPanel = new Panel { Height = 45, Dock = DockStyle.Bottom, BackColor = Color.Transparent }; // Nền trong suốt
            decimal priceValue = 0;
            if (decimal.TryParse(itemData.Price, out priceValue)) { }
            Label priceLabel = new Label { Text = $"{priceValue:N0}", ForeColor = Color.FromArgb(130, 255, 130), Font = new Font("Segoe UI", 11F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleLeft, Dock = DockStyle.Fill, Padding = new Padding(5, 0, 0, 0), BackColor = Color.Transparent };

            IconButton addButton = new IconButton { IconChar = IconChar.Plus, IconColor = Color.White, IconSize = 18, BackColor = Color.FromArgb(30, 180, 30), FlatStyle = FlatStyle.Flat, Size = new Size(36, 36), Location = new Point(bottomPanel.Width - 36 - 5, (bottomPanel.Height - 36) / 2), Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Cursor = Cursors.Hand, Tag = itemData };
            addButton.FlatAppearance.BorderSize = 0;
            addButton.Click += AddToCart_Click;

            bottomPanel.Controls.Add(priceLabel);
            bottomPanel.Controls.Add(addButton);
            addButton.BringToFront();

            // Thứ tự thêm control vào cardPanel
            cardPanel.Controls.Add(bottomPanel);      // Dock Bottom trước
            cardPanel.Controls.Add(descriptionLabel); // Sau đó là các control Dock Top từ dưới lên
            cardPanel.Controls.Add(nameLabel);
            cardPanel.Controls.Add(pictureBox);       // PictureBox Dock Top sẽ ở trên cùng

            return cardPanel; // Hàm vẫn trả về Panel, nhưng thực tế là một RoundedPanel
        }


        private Image LoadItemImage(string imagePath)
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = Path.Combine(basePath, imagePath);
                if (File.Exists(fullPath)) { using (Image originalImage = Image.FromFile(fullPath)) { return new Bitmap(originalImage); } }
                else { Console.WriteLine($"Image not found: {fullPath}"); }
            }
            catch (Exception ex) { Console.WriteLine($"Error loading image {imagePath}: {ex.Message}"); }
            Bitmap placeholder = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(placeholder)) { g.Clear(Color.FromArgb(60, 60, 60)); TextRenderer.DrawText(g, "No Image", new Font("Segoe UI", 8F), new Rectangle(0, 0, 100, 100), Color.DarkGray, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter); }
            return placeholder;
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            IconButton clickedButton = sender as IconButton;
            if (clickedButton != null && clickedButton.Tag is ItemData itemData)
            {
                CartItemEntry existingCartItem = shoppingCart.FirstOrDefault(ci => ci.Product.Name == itemData.Name);
                if (existingCartItem != null)
                {
                    existingCartItem.Quantity++;
                }
                else
                {
                    shoppingCart.Add(new CartItemEntry(itemData, 1));
                }
                if (panelCartView.Visible)
                {
                    RefreshCartOnScreen();
                }
            }
        }

        private void RefreshCartOnScreen()
        {
            flowLayoutPanelCartItemsDisplay.Controls.Clear();
            decimal grandTotal = 0;
            if (!shoppingCart.Any())
            {
                Label emptyCartLabel = new Label { Text = "Your cart is empty.", ForeColor = Color.Gray, Font = new Font("Segoe UI", 10F), AutoSize = false, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
                flowLayoutPanelCartItemsDisplay.Controls.Add(emptyCartLabel);
                lblGrandTotal.Text = "Total: 0";
                return;
            }
            foreach (var cartEntry in shoppingCart)
            {
                Panel cartItemPanel = CreateCartItemPanel(cartEntry);
                flowLayoutPanelCartItemsDisplay.Controls.Add(cartItemPanel);
                grandTotal += cartEntry.LineTotal;
            }
            lblGrandTotal.Text = $"Total: {grandTotal:N0}";
        }

        private Panel CreateCartItemPanel(CartItemEntry cartEntry)
        {
            int panelWidth = flowLayoutPanelCartItemsDisplay.ClientSize.Width - flowLayoutPanelCartItemsDisplay.Padding.Horizontal;
            if (flowLayoutPanelCartItemsDisplay.VerticalScroll.Visible)
            {
                panelWidth -= SystemInformation.VerticalScrollBarWidth;
            }
            panelWidth = Math.Max(280, panelWidth - 5);

            Panel itemPanel = new Panel
            {
                Width = panelWidth,
                Height = 70,
                BackColor = Color.FromArgb(50, 52, 58),
                Margin = new Padding(0, 0, 0, 5)
            };

            PictureBox itemImage = new PictureBox
            {
                Image = LoadItemImage(cartEntry.Product.ImagePath),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(50, 50),
                Location = new Point(10, (itemPanel.Height - 50) / 2)
            };

            int rightMargin = 10;
            int currentX = itemPanel.Width - rightMargin;
            int controlHeight = 25;
            int iconSize = 18;
            int verticalPosition = (itemPanel.Height - controlHeight) / 2;

            IconButton btnRemove = new IconButton
            {
                IconChar = IconChar.Times,
                IconColor = Color.WhiteSmoke,
                IconSize = iconSize,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(controlHeight, controlHeight),
                Tag = cartEntry,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                ImageAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            btnRemove.Click += BtnCartItemRemove_Click;
            currentX -= btnRemove.Width;
            btnRemove.Location = new Point(currentX, verticalPosition);

            currentX -= 5;

            Label lblLineTotal = new Label { Text = $"{cartEntry.LineTotal:N0}", ForeColor = Color.PaleGreen, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Size = new Size(65, controlHeight), TextAlign = ContentAlignment.MiddleRight };
            currentX -= lblLineTotal.Width;
            lblLineTotal.Location = new Point(currentX, verticalPosition);

            currentX -= 5;

            IconButton btnIncrement = new IconButton
            {
                IconChar = IconChar.PlusCircle,
                IconColor = Color.White,
                IconSize = iconSize,
                BackColor = Color.FromArgb(70, 180, 70),
                Size = new Size(controlHeight, controlHeight),
                FlatStyle = FlatStyle.Flat,
                Tag = cartEntry,
                ImageAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };
            btnIncrement.FlatAppearance.BorderSize = 0;
            btnIncrement.Click += BtnCartItemIncrement_Click;
            currentX -= btnIncrement.Width;
            btnIncrement.Location = new Point(currentX, verticalPosition);

            currentX -= 2;

            Label lblQuantity = new Label { Text = cartEntry.Quantity.ToString(), ForeColor = Color.White, Font = new Font("Segoe UI", 10F, FontStyle.Bold), Size = new Size(30, controlHeight), TextAlign = ContentAlignment.MiddleCenter };
            currentX -= lblQuantity.Width;
            lblQuantity.Location = new Point(currentX, verticalPosition);

            currentX -= 2;

            IconButton btnDecrement = new IconButton
            {
                IconChar = IconChar.MinusCircle,
                IconColor = Color.White,
                IconSize = iconSize,
                BackColor = Color.FromArgb(200, 70, 70),
                Size = new Size(controlHeight, controlHeight),
                FlatStyle = FlatStyle.Flat,
                Tag = cartEntry,
                ImageAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };
            btnDecrement.FlatAppearance.BorderSize = 0;
            btnDecrement.Click += BtnCartItemDecrement_Click;
            currentX -= btnDecrement.Width;
            btnDecrement.Location = new Point(currentX, verticalPosition);

            int leftControlsX = itemImage.Right + 8;
            int availableWidthForNameAndPrice = currentX - leftControlsX - 8;

            Label itemName = new Label
            {
                Text = cartEntry.Product.Name,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(Math.Max(60, availableWidthForNameAndPrice), 22),
                Location = new Point(leftControlsX, 12),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label itemUnitPrice = new Label
            {
                Text = $"@{cartEntry.UnitPrice:N0}",
                ForeColor = Color.LightGray,
                Font = new Font("Segoe UI", 8.5F),
                AutoSize = false,
                AutoEllipsis = true,
                Size = new Size(Math.Max(50, availableWidthForNameAndPrice), 18),
                Location = new Point(leftControlsX, itemName.Bottom + 2),
                TextAlign = ContentAlignment.MiddleLeft
            };

            itemPanel.Controls.Add(itemImage);
            itemPanel.Controls.Add(itemName);
            itemPanel.Controls.Add(itemUnitPrice);
            itemPanel.Controls.Add(btnDecrement);
            itemPanel.Controls.Add(lblQuantity);
            itemPanel.Controls.Add(btnIncrement);
            itemPanel.Controls.Add(lblLineTotal);
            itemPanel.Controls.Add(btnRemove);

            return itemPanel;
        }


        private void BtnCartItemIncrement_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null && btn.Tag is CartItemEntry entry)
            {
                entry.Quantity++;
                RefreshCartOnScreen();
            }
        }

        private void BtnCartItemDecrement_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null && btn.Tag is CartItemEntry entry)
            {
                entry.Quantity--;
                if (entry.Quantity <= 0)
                {
                    shoppingCart.Remove(entry);
                }
                RefreshCartOnScreen();
            }
        }

        private void BtnCartItemRemove_Click(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            if (btn != null && btn.Tag is CartItemEntry entry)
            {
                shoppingCart.Remove(entry);
                RefreshCartOnScreen();
            }
        }

        private async void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (!shoppingCart.Any())
            {
                MessageBox.Show("Your cart is empty.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.loggedInUser == null)
            {
                MessageBox.Show("Cannot identify logged in user. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Order mới
            var newOrder = new Internet_Cafe_Manager_App.Database.Order
            {
                OrderId = Guid.NewGuid().ToString(),
                UserID = this.loggedInUser.UserId,
                Username = this.loggedInUser.Username,
                UserFullName = this.loggedInUser.FullName,
                Items = new List<CartItemEntry>(shoppingCart),
                GrandTotal = shoppingCart.Sum(item => item.LineTotal),
                Timestamp = DateTime.UtcNow,
                Status = "Pending",
                // <--- SỬA ĐỔI QUAN TRỌNG: Thêm dòng này ---
                Type = TransactionType.FoodOrder,
                Description = $"Gọi {shoppingCart.Count} món"
            };

            // Gọi phương thức lưu vào Firebase
            FirebaseDB firebaseDB = new FirebaseDB();
            bool success = await firebaseDB.AddOrder(newOrder);

            if (success)
            {
                MessageBox.Show("Your order has been placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                shoppingCart.Clear();
                RefreshCartOnScreen();
            }
            else
            {
                MessageBox.Show("Failed to place your order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class ItemData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
    }

    public class CartItemEntry // Không thay đổi
    {
        public ItemData Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice => Convert.ToDecimal(Product.Price);
        public decimal LineTotal => UnitPrice * Quantity;
        public CartItemEntry() { }
        public CartItemEntry(ItemData product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}