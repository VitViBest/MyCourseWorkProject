namespace CourseWork
{
    partial class AddBrewForm
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
            this.Categoryes = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.Category = new System.Windows.Forms.ComboBox();
            this.CanShop = new System.Windows.Forms.CheckBox();
            this.BrewName = new System.Windows.Forms.TextBox();
            this.LabelCanShop = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.IngerientsLabel = new System.Windows.Forms.Label();
            this.Ingredients = new System.Windows.Forms.ListBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.AddIng = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Categoryes
            // 
            this.Categoryes.Location = new System.Drawing.Point(229, 145);
            this.Categoryes.Name = "Categoryes";
            this.Categoryes.Size = new System.Drawing.Size(75, 23);
            this.Categoryes.TabIndex = 33;
            this.Categoryes.Text = "Категории";
            this.Categoryes.UseVisualStyleBackColor = true;
            this.Categoryes.Click += new System.EventHandler(this.Categoryes_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(415, 226);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 32;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(527, 216);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 31;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(90, 107);
            this.Volume.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Volume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(120, 20);
            this.Volume.TabIndex = 29;
            this.Volume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(90, 63);
            this.Cost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Cost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(120, 20);
            this.Cost.TabIndex = 28;
            this.Cost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(90, 142);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 27;
            // 
            // CanShop
            // 
            this.CanShop.AutoSize = true;
            this.CanShop.Checked = true;
            this.CanShop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CanShop.Location = new System.Drawing.Point(111, 183);
            this.CanShop.Name = "CanShop";
            this.CanShop.Size = new System.Drawing.Size(15, 14);
            this.CanShop.TabIndex = 25;
            this.CanShop.UseVisualStyleBackColor = true;
            // 
            // BrewName
            // 
            this.BrewName.Location = new System.Drawing.Point(90, 22);
            this.BrewName.Name = "BrewName";
            this.BrewName.Size = new System.Drawing.Size(100, 20);
            this.BrewName.TabIndex = 24;
            // 
            // LabelCanShop
            // 
            this.LabelCanShop.AutoSize = true;
            this.LabelCanShop.Location = new System.Drawing.Point(21, 184);
            this.LabelCanShop.Name = "LabelCanShop";
            this.LabelCanShop.Size = new System.Drawing.Size(73, 13);
            this.LabelCanShop.TabIndex = 23;
            this.LabelCanShop.Text = "Доступность";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(21, 145);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(63, 13);
            this.LabelCategory.TabIndex = 22;
            this.LabelCategory.Text = "Категория ";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(16, 107);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(42, 13);
            this.LabelVolume.TabIndex = 20;
            this.LabelVolume.Text = "Объем";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(16, 65);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(68, 13);
            this.LabelCost.TabIndex = 19;
            this.LabelCost.Text = "Стоимость: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(21, 25);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 13);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Название: ";
            // 
            // IngerientsLabel
            // 
            this.IngerientsLabel.AutoSize = true;
            this.IngerientsLabel.Location = new System.Drawing.Point(270, 9);
            this.IngerientsLabel.Name = "IngerientsLabel";
            this.IngerientsLabel.Size = new System.Drawing.Size(75, 13);
            this.IngerientsLabel.TabIndex = 34;
            this.IngerientsLabel.Text = "Ингредиенты";
            // 
            // Ingredients
            // 
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.Location = new System.Drawing.Point(351, 9);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(257, 95);
            this.Ingredients.TabIndex = 35;
            this.Ingredients.SelectedIndexChanged += new System.EventHandler(this.Ingredients_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(351, 120);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(109, 21);
            this.Product.TabIndex = 36;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(475, 120);
            this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(57, 20);
            this.Count.TabIndex = 37;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddIng
            // 
            this.AddIng.Location = new System.Drawing.Point(538, 120);
            this.AddIng.Name = "AddIng";
            this.AddIng.Size = new System.Drawing.Size(61, 23);
            this.AddIng.TabIndex = 38;
            this.AddIng.Text = "+";
            this.AddIng.UseVisualStyleBackColor = true;
            this.AddIng.Click += new System.EventHandler(this.AddIng_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(284, 35);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 23);
            this.Delete.TabIndex = 39;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddBrewForm
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(620, 254);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddIng);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.IngerientsLabel);
            this.Controls.Add(this.Categoryes);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.CanShop);
            this.Controls.Add(this.BrewName);
            this.Controls.Add(this.LabelCanShop);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить напиток";
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Categoryes;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown Volume;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.CheckBox CanShop;
        private System.Windows.Forms.TextBox BrewName;
        private System.Windows.Forms.Label LabelCanShop;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label IngerientsLabel;
        private System.Windows.Forms.ListBox Ingredients;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Button AddIng;
        private System.Windows.Forms.Button Delete;
    }
}