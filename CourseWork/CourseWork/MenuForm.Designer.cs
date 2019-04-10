namespace CourseWork
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.Employeers = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            this.Dishes = new System.Windows.Forms.Button();
            this.Brews = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Tables = new System.Windows.Forms.Button();
            this.CreateCheck = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.Statistica = new System.Windows.Forms.Button();
            this.Raiting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Employeers
            // 
            this.Employeers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Employeers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employeers.Image = ((System.Drawing.Image)(resources.GetObject("Employeers.Image")));
            this.Employeers.Location = new System.Drawing.Point(156, 12);
            this.Employeers.Name = "Employeers";
            this.Employeers.Size = new System.Drawing.Size(110, 150);
            this.Employeers.TabIndex = 1;
            this.Employeers.Text = "Сотрудники";
            this.Employeers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Employeers.UseVisualStyleBackColor = true;
            this.Employeers.Click += new System.EventHandler(this.Employeers_Click);
            // 
            // Profile
            // 
            this.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.Location = new System.Drawing.Point(620, 179);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(110, 150);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Профиль";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Dishes
            // 
            this.Dishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dishes.Image = ((System.Drawing.Image)(resources.GetObject("Dishes.Image")));
            this.Dishes.Location = new System.Drawing.Point(272, 12);
            this.Dishes.Name = "Dishes";
            this.Dishes.Size = new System.Drawing.Size(110, 150);
            this.Dishes.TabIndex = 2;
            this.Dishes.Text = "Блюда";
            this.Dishes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dishes.UseVisualStyleBackColor = true;
            this.Dishes.Click += new System.EventHandler(this.Dishes_Click);
            // 
            // Brews
            // 
            this.Brews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Brews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Brews.Image = ((System.Drawing.Image)(resources.GetObject("Brews.Image")));
            this.Brews.Location = new System.Drawing.Point(388, 12);
            this.Brews.Name = "Brews";
            this.Brews.Size = new System.Drawing.Size(110, 150);
            this.Brews.TabIndex = 3;
            this.Brews.Text = "Напитки";
            this.Brews.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Brews.UseVisualStyleBackColor = true;
            this.Brews.Click += new System.EventHandler(this.Brews_Click);
            // 
            // Customers
            // 
            this.Customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers.Image = ((System.Drawing.Image)(resources.GetObject("Customers.Image")));
            this.Customers.Location = new System.Drawing.Point(620, 12);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(110, 150);
            this.Customers.TabIndex = 4;
            this.Customers.Text = "Клиенты";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Products
            // 
            this.Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Products.Image = ((System.Drawing.Image)(resources.GetObject("Products.Image")));
            this.Products.Location = new System.Drawing.Point(272, 179);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(110, 150);
            this.Products.TabIndex = 5;
            this.Products.Text = "Продукты";
            this.Products.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Tables
            // 
            this.Tables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Tables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tables.Image = ((System.Drawing.Image)(resources.GetObject("Tables.Image")));
            this.Tables.Location = new System.Drawing.Point(388, 179);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(110, 150);
            this.Tables.TabIndex = 6;
            this.Tables.Text = "Столы";
            this.Tables.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tables.UseVisualStyleBackColor = true;
            this.Tables.Click += new System.EventHandler(this.Tables_Click);
            // 
            // CreateCheck
            // 
            this.CreateCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreateCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateCheck.Image = ((System.Drawing.Image)(resources.GetObject("CreateCheck.Image")));
            this.CreateCheck.Location = new System.Drawing.Point(31, 179);
            this.CreateCheck.Name = "CreateCheck";
            this.CreateCheck.Size = new System.Drawing.Size(110, 150);
            this.CreateCheck.TabIndex = 7;
            this.CreateCheck.Text = "Заказ";
            this.CreateCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateCheck.UseVisualStyleBackColor = true;
            this.CreateCheck.Click += new System.EventHandler(this.CreateCheck_Click);
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(655, 352);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders.Image = ((System.Drawing.Image)(resources.GetObject("Orders.Image")));
            this.Orders.Location = new System.Drawing.Point(156, 179);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(110, 150);
            this.Orders.TabIndex = 9;
            this.Orders.Text = "Заказы";
            this.Orders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Statistica
            // 
            this.Statistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Statistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Statistica.Image = ((System.Drawing.Image)(resources.GetObject("Statistica.Image")));
            this.Statistica.Location = new System.Drawing.Point(504, 12);
            this.Statistica.Name = "Statistica";
            this.Statistica.Size = new System.Drawing.Size(110, 150);
            this.Statistica.TabIndex = 10;
            this.Statistica.Text = "Статистика";
            this.Statistica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Statistica.UseVisualStyleBackColor = true;
            this.Statistica.Click += new System.EventHandler(this.Statistica_Click);
            // 
            // Raiting
            // 
            this.Raiting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Raiting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Raiting.Image = ((System.Drawing.Image)(resources.GetObject("Raiting.Image")));
            this.Raiting.Location = new System.Drawing.Point(504, 179);
            this.Raiting.Name = "Raiting";
            this.Raiting.Size = new System.Drawing.Size(110, 150);
            this.Raiting.TabIndex = 11;
            this.Raiting.Text = "Рейтинг";
            this.Raiting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Raiting.UseVisualStyleBackColor = true;
            this.Raiting.Click += new System.EventHandler(this.Raiting_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 143);
            this.panel1.TabIndex = 12;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(742, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Raiting);
            this.Controls.Add(this.Statistica);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CreateCheck);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.Brews);
            this.Controls.Add(this.Dishes);
            this.Controls.Add(this.Employeers);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Действия";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button Employeers;
        private System.Windows.Forms.Button Dishes;
        private System.Windows.Forms.Button Brews;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Tables;
        private System.Windows.Forms.Button CreateCheck;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Orders;
        private System.Windows.Forms.Button Statistica;
        private System.Windows.Forms.Button Raiting;
        private System.Windows.Forms.Panel panel1;
    }
}