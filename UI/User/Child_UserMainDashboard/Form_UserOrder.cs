// Dán toàn bộ mã này vào tệp Form_UserOrder.cs

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
        private List<Item> allSampleItems = new List<Item>();
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
        FirebaseDB firebaseDB;
        public Form_UserOrder()
        {
            InitializeComponent();
            InitializeCartPanelUI();
            if (this.Controls.Contains(this.labelAllItems))
            {
                this.labelAllItems.BringToFront();
            }
        }

        public Form_UserOrder(Internet_Cafe_Manager_App.Database.Users user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            InitializeCartPanelUI();
        }

        private void InitializeCartPanelUI()
        {
            panelCartView.Padding = new Padding(10);
            btnCloseCart = new IconButton
            {
                IconChar = IconChar.Times,
                IconColor = Color.WhiteSmoke,
                IconSize = 20,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(28, 28),
                Location = new Point(panelCartView.ClientSize.Width - 28 - 3, 3),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand
            };
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
            panel1.Layout += (s, ev) =>
            {
                if (panel1.Width > 0 && labelCurrentTitle.Width > 0)
                {
                    labelCurrentTitle.Location = new Point((panel1.Width - labelCurrentTitle.Width) / 2, (panel1.Height - labelCurrentTitle.Height) / 2);
                }
            };
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

            var allButton = panelFilters.Controls.OfType<FlowLayoutPanel>().FirstOrDefault()?.Controls.OfType<Button>().FirstOrDefault(b => b.Tag?.ToString() == "All");
            if (allButton != null)
            {
                ActivateFilterButton(allButton);
            }
            AdjustLayoutForCart();
        }

        private void AdjustLayoutForCart()
        {
            panelRightActions.Visible = !panelCartView.Visible;
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

        private void LoadCategoryFilters()
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

            panelFilters.Layout += (s, ev) =>
            {
                if (panelFilters.Width > 0)
                {
                    filterFlowPanel.Padding = new Padding(
                        Math.Max(0, (panelFilters.Width - (categories.Length * buttonWidth + (categories.Length - 1) * spacing)) / 2),
                        (panelFilters.Height - buttonHeight) / 2, 0, 0);
                }
            };

            if (panelFilters.Width > 0)
            {
                filterFlowPanel.Padding = new Padding(
                   Math.Max(0, (panelFilters.Width - (categories.Length * buttonWidth + (categories.Length - 1) * spacing)) / 2),
                   (panelFilters.Height - buttonHeight) / 2, 0, 0);
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
                    var filteredItems = allSampleItems.Where(Item =>
                    (Item.Type != null && Item.Type.Equals(category, StringComparison.OrdinalIgnoreCase)) ||
                    (Item.Name != null && Item.Name.ToLower().Contains(category.ToLower()))
                    ).ToList();
                    DisplayItems(filteredItems);
                }
            }
        }

        private Item ConvertToItemData(Item item)
        {
            // Bây giờ lớp Item đã có ImageUrl, ta sẽ map nó
            return new Item
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                ImageUrl = item.ImageUrl, // Sử dụng ImageUrl
                Type = item.Type,
                Quantity = item.Quantity
            };
        }

        private async Task LoadSampleItems()
        {
            try
            {
                firebaseDB = new FirebaseDB();
                var firebaseItems = await firebaseDB.GetAllItems();

                allSampleItems.Clear();
                if (firebaseItems != null)
                {
                    foreach (var item in firebaseItems)
                    {
                        allSampleItems.Add(ConvertToItemData(item));
                    }
                }
                DisplayItems(allSampleItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Firebase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayItems(List<Item> itemsToDisplay)
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

        private Panel CreateItemCard(Item itemData)
        {
            RoundedPanel cardPanel = new RoundedPanel
            {
                Width = 175,
                Height = 270,
                Margin = new Padding(12),
                Padding = new Padding(8),
                CornerRadius = 15,
                BackColor = Color.FromArgb(45, 45, 50)
            };

            PictureBox pictureBox = new PictureBox
            {
                // THAY ĐỔI QUAN TRỌNG: Dùng ImageLocation để tải ảnh từ URL
                ImageLocation = itemData.ImageUrl,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(cardPanel.Width - 16, 110),
                Location = new Point(8, 8)
            };
            // Xử lý nếu không tải được ảnh
            pictureBox.LoadCompleted += (s, e) => {
                if (e.Error != null) ((PictureBox)s).Image = null; // Hoặc hiển thị ảnh placeholder
            };

            Label nameLabel = new Label
            {
                Text = itemData.Name,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Bold),
                Size = new Size(cardPanel.Width - 16, 22),
                Location = new Point(8, pictureBox.Bottom + 6),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            Label quantityLabel = new Label
            {
                Text = $"Còn lại: {itemData.Quantity}",
                ForeColor = Color.Orange,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                Size = new Size(cardPanel.Width - 16, 18),
                Location = new Point(8, nameLabel.Bottom + 2),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Transparent
            };

            Panel bottomPanel = new Panel { Height = 45, Dock = DockStyle.Bottom, BackColor = Color.Transparent };
            decimal priceValue = (decimal)itemData.Price;
            Label priceLabel = new Label
            {
                Text = $"{(decimal)itemData.Price:N0}",
                ForeColor = Color.FromArgb(130, 255, 130),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                Padding = new Padding(5, 0, 0, 0),
                BackColor = Color.Transparent
            };

            IconButton addButton = new IconButton { IconChar = IconChar.Plus, IconColor = Color.White, IconSize = 18, BackColor = Color.FromArgb(30, 180, 30), FlatStyle = FlatStyle.Flat, Size = new Size(36, 36), Location = new Point(bottomPanel.Width - 36 - 5, (bottomPanel.Height - 36) / 2), Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Cursor = Cursors.Hand, Tag = itemData };
            addButton.FlatAppearance.BorderSize = 0;
            addButton.Click += AddToCart_Click;

            bottomPanel.Controls.Add(priceLabel);
            bottomPanel.Controls.Add(addButton);
            addButton.BringToFront();

            cardPanel.Controls.Add(bottomPanel);
            cardPanel.Controls.Add(quantityLabel);
            cardPanel.Controls.Add(nameLabel);
            cardPanel.Controls.Add(pictureBox);

            return cardPanel;
        }

        // PHƯƠNG THỨC NÀY KHÔNG CÒN CẦN THIẾT NỮA VÌ DÙNG ImageLocation
        /*
        private Image LoadItemImage(string imagePath)
        {
            // ...
        }
        */

        private void AddToCart_Click(object sender, EventArgs e)
        {
            IconButton clickedButton = sender as IconButton;
            if (clickedButton != null && clickedButton.Tag is Item itemData)
            {
                CartItemEntry existingCartItem = shoppingCart.FirstOrDefault(ci => ci.Product.Id == itemData.Id);

                if (existingCartItem != null)
                {
                    if (existingCartItem.Quantity >= itemData.Quantity)
                    {
                        MessageBox.Show($"Sản phẩm '{itemData.Name}' chỉ còn {itemData.Quantity} cái trong kho.");
                        return;
                    }

                    existingCartItem.Quantity++;
                }
                else
                {
                    if (itemData.Quantity <= 0)
                    {
                        MessageBox.Show($"Sản phẩm '{itemData.Name}' đã hết hàng.");
                        return;
                    }

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
                Height = 85,
                BackColor = Color.FromArgb(50, 52, 58),
                Margin = new Padding(0, 0, 0, 5)
            };

            PictureBox itemImage = new PictureBox
            {
                // TƯƠNG TỰ: DÙNG ImageLocation
                ImageLocation = cartEntry.Product.ImageUrl,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(50, 50),
                Location = new Point(10, (itemPanel.Height - 50) / 2)
            };
            itemImage.LoadCompleted += (s, e) => {
                if (e.Error != null) ((PictureBox)s).Image = null;
            };

            // ... (Phần còn lại của hàm CreateCartItemPanel giữ nguyên)
            // ... (Phần này không cần thay đổi logic) ...

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

            Label lblStockRemaining = new Label
            {
                Text = $"Còn lại: {cartEntry.Product.Quantity}",
                ForeColor = Color.Orange,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                AutoSize = true,
                Location = new Point(leftControlsX, itemUnitPrice.Bottom + 2),
                BackColor = Color.Transparent
            };

            itemPanel.Controls.Add(itemImage);
            itemPanel.Controls.Add(itemName);
            itemPanel.Controls.Add(itemUnitPrice);
            itemPanel.Controls.Add(lblStockRemaining);
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
                Type = TransactionType.FoodOrder,
                Description = $"Gọi {shoppingCart.Count} món"
            };

            FirebaseDB firebaseDB = new FirebaseDB();
            bool orderSuccess = await firebaseDB.AddOrder(newOrder);

            if (orderSuccess)
            {
                bool allItemsUpdated = true;

                foreach (var cartItem in shoppingCart)
                {
                    if (string.IsNullOrEmpty(cartItem.Product.Id))
                    {
                        MessageBox.Show($" Sản phẩm '{cartItem.Product.Name}' không có ID. Không thể cập nhật tồn kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allItemsUpdated = false;
                        continue;
                    }

                    cartItem.Product.Quantity -= cartItem.Quantity;

                    bool updateSuccess = await firebaseDB.AddOrUpdateItem(cartItem.Product);
                    if (!updateSuccess)
                    {
                        MessageBox.Show($" Lỗi khi cập nhật tồn kho cho sản phẩm: {cartItem.Product.Name}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        allItemsUpdated = false;
                    }
                }

                if (allItemsUpdated)
                {
                    MessageBox.Show(" Đặt hàng thành công và tồn kho đã được cập nhật!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã đặt nhưng có lỗi khi cập nhật tồn kho một số sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                shoppingCart.Clear();
                RefreshCartOnScreen();
                await LoadSampleItems();
            }
            else
            {
                MessageBox.Show(" Không thể đặt hàng. Vui lòng thử lại.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelFilters_Paint(object sender, PaintEventArgs e) { }
        private void labelCurrentTitle_Click(object sender, EventArgs e) { }
    }

    public class CartItemEntry
    {
        public Item Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice => Convert.ToDecimal(Product.Price);
        public decimal LineTotal => UnitPrice * Quantity;
        public CartItemEntry() { }
        public CartItemEntry(Item product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}