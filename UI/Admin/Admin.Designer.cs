namespace Internet_Cafe_Manager_App
{
    partial class Admin
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
            Menu_bar = new Panel();
            btn_Drink = new Button();
            btn_Food = new Button();
            btn_Home = new Button();
            Display_field = new Panel();
            Display_Drink = new Panel();
            Display_Food = new Panel();
            Display_Home = new Panel();
            Menu_bar.SuspendLayout();
            Display_field.SuspendLayout();
            SuspendLayout();
            // 
            // Menu_bar
            // 
            Menu_bar.BackColor = SystemColors.GradientInactiveCaption;
            Menu_bar.Controls.Add(btn_Drink);
            Menu_bar.Controls.Add(btn_Food);
            Menu_bar.Controls.Add(btn_Home);
            Menu_bar.Dock = DockStyle.Left;
            Menu_bar.ForeColor = SystemColors.ControlText;
            Menu_bar.Location = new Point(0, 0);
            Menu_bar.Name = "Menu_bar";
            Menu_bar.Size = new Size(80, 593);
            Menu_bar.TabIndex = 0;
            // 
            // btn_Drink
            // 
            btn_Drink.Location = new Point(10, 90);
            btn_Drink.Name = "btn_Drink";
            btn_Drink.Size = new Size(60, 30);
            btn_Drink.TabIndex = 3;
            btn_Drink.Text = "Drink";
            btn_Drink.UseVisualStyleBackColor = true;
            btn_Drink.Click += btn_Drink_Click;
            // 
            // btn_Food
            // 
            btn_Food.Location = new Point(10, 50);
            btn_Food.Name = "btn_Food";
            btn_Food.Size = new Size(60, 30);
            btn_Food.TabIndex = 2;
            btn_Food.Text = "Food";
            btn_Food.UseVisualStyleBackColor = true;
            btn_Food.Click += btn_Food_Click;
            // 
            // btn_Home
            // 
            btn_Home.Location = new Point(10, 10);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(60, 30);
            btn_Home.TabIndex = 0;
            btn_Home.Text = "Home";
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // Display_field
            // 
            Display_field.Controls.Add(Display_Drink);
            Display_field.Controls.Add(Display_Food);
            Display_field.Controls.Add(Display_Home);
            Display_field.Dock = DockStyle.Fill;
            Display_field.Location = new Point(80, 0);
            Display_field.Name = "Display_field";
            Display_field.Size = new Size(1027, 593);
            Display_field.TabIndex = 1;
            // 
            // Display_Drink
            // 
            Display_Drink.Dock = DockStyle.Fill;
            Display_Drink.Location = new Point(0, 0);
            Display_Drink.Name = "Display_Drink";
            Display_Drink.Size = new Size(1027, 593);
            Display_Drink.TabIndex = 0;
            // 
            // Display_Food
            // 
            Display_Food.Dock = DockStyle.Fill;
            Display_Food.Location = new Point(0, 0);
            Display_Food.Name = "Display_Food";
            Display_Food.Size = new Size(1027, 593);
            Display_Food.TabIndex = 0;
            // 
            // Display_Home
            // 
            Display_Home.Dock = DockStyle.Fill;
            Display_Home.Location = new Point(0, 0);
            Display_Home.Name = "Display_Home";
            Display_Home.Size = new Size(1027, 593);
            Display_Home.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 593);
            Controls.Add(Display_field);
            Controls.Add(Menu_bar);
            Name = "Admin";
            Text = "Admin";
            Menu_bar.ResumeLayout(false);
            Display_field.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu_bar;
        private Panel Display_field;
        private Button btn_Home;
        private Button btn_Food;
        private Button btn_Drink;
        private Panel Display_Home;
        private Panel Display_Food;
        private Panel Display_Drink;
    }
}