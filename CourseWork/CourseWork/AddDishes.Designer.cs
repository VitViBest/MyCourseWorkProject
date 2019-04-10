namespace CourseWork
{
    partial class AddDishes
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
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPortion = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelMass = new System.Windows.Forms.Label();
            this.LabelKalory = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelCanShop = new System.Windows.Forms.Label();
            this.DishName = new System.Windows.Forms.TextBox();
            this.CanShop = new System.Windows.Forms.CheckBox();
            this.Portion = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.Mass = new System.Windows.Forms.NumericUpDown();
            this.Kalories = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Categoryes = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddIng = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Ingredients = new System.Windows.Forms.ListBox();
            this.IngerientsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(27, 38);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название: ";
            // 
            // LabelPortion
            // 
            this.LabelPortion.AutoSize = true;
            this.LabelPortion.Location = new System.Drawing.Point(27, 73);
            this.LabelPortion.Name = "LabelPortion";
            this.LabelPortion.Size = new System.Drawing.Size(51, 13);
            this.LabelPortion.TabIndex = 1;
            this.LabelPortion.Text = "Порция: ";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(27, 112);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(68, 13);
            this.LabelCost.TabIndex = 2;
            this.LabelCost.Text = "Стоимость: ";
            // 
            // LabelMass
            // 
            this.LabelMass.AutoSize = true;
            this.LabelMass.Location = new System.Drawing.Point(27, 154);
            this.LabelMass.Name = "LabelMass";
            this.LabelMass.Size = new System.Drawing.Size(46, 13);
            this.LabelMass.TabIndex = 3;
            this.LabelMass.Text = "Масса: ";
            // 
            // LabelKalory
            // 
            this.LabelKalory.AutoSize = true;
            this.LabelKalory.Location = new System.Drawing.Point(326, 38);
            this.LabelKalory.Name = "LabelKalory";
            this.LabelKalory.Size = new System.Drawing.Size(50, 13);
            this.LabelKalory.TabIndex = 4;
            this.LabelKalory.Text = "Калории";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(326, 73);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(63, 13);
            this.LabelCategory.TabIndex = 5;
            this.LabelCategory.Text = "Категория ";
            // 
            // LabelCanShop
            // 
            this.LabelCanShop.AutoSize = true;
            this.LabelCanShop.Location = new System.Drawing.Point(326, 112);
            this.LabelCanShop.Name = "LabelCanShop";
            this.LabelCanShop.Size = new System.Drawing.Size(73, 13);
            this.LabelCanShop.TabIndex = 6;
            this.LabelCanShop.Text = "Доступность";
            // 
            // DishName
            // 
            this.DishName.Location = new System.Drawing.Point(96, 35);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(100, 20);
            this.DishName.TabIndex = 7;
            // 
            // CanShop
            // 
            this.CanShop.AutoSize = true;
            this.CanShop.Checked = true;
            this.CanShop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CanShop.Location = new System.Drawing.Point(416, 111);
            this.CanShop.Name = "CanShop";
            this.CanShop.Size = new System.Drawing.Size(15, 14);
            this.CanShop.TabIndex = 8;
            this.CanShop.UseVisualStyleBackColor = true;
            // 
            // Portion
            // 
            this.Portion.FormattingEnabled = true;
            this.Portion.Location = new System.Drawing.Point(96, 73);
            this.Portion.Name = "Portion";
            this.Portion.Size = new System.Drawing.Size(121, 21);
            this.Portion.TabIndex = 9;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(395, 70);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 10;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(101, 110);
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
            this.Cost.TabIndex = 11;
            this.Cost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Mass
            // 
            this.Mass.Location = new System.Drawing.Point(101, 154);
            this.Mass.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Mass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(120, 20);
            this.Mass.TabIndex = 12;
            this.Mass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Kalories
            // 
            this.Kalories.Location = new System.Drawing.Point(396, 36);
            this.Kalories.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Kalories.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Kalories.Name = "Kalories";
            this.Kalories.Size = new System.Drawing.Size(120, 20);
            this.Kalories.TabIndex = 13;
            this.Kalories.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(528, 204);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(395, 214);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Categoryes
            // 
            this.Categoryes.Location = new System.Drawing.Point(534, 73);
            this.Categoryes.Name = "Categoryes";
            this.Categoryes.Size = new System.Drawing.Size(75, 23);
            this.Categoryes.TabIndex = 16;
            this.Categoryes.Text = "Категории";
            this.Categoryes.UseVisualStyleBackColor = true;
            this.Categoryes.Click += new System.EventHandler(this.Categoryes_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(34, 257);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 23);
            this.Delete.TabIndex = 45;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddIng
            // 
            this.AddIng.Location = new System.Drawing.Point(288, 342);
            this.AddIng.Name = "AddIng";
            this.AddIng.Size = new System.Drawing.Size(61, 23);
            this.AddIng.TabIndex = 44;
            this.AddIng.Text = "+";
            this.AddIng.UseVisualStyleBackColor = true;
            this.AddIng.Click += new System.EventHandler(this.AddIng_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(225, 342);
            this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(57, 20);
            this.Count.TabIndex = 43;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(101, 342);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(109, 21);
            this.Product.TabIndex = 42;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // Ingredients
            // 
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.Location = new System.Drawing.Point(101, 231);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(257, 95);
            this.Ingredients.TabIndex = 41;
            this.Ingredients.SelectedIndexChanged += new System.EventHandler(this.Ingredients_SelectedIndexChanged);
            // 
            // IngerientsLabel
            // 
            this.IngerientsLabel.AutoSize = true;
            this.IngerientsLabel.Location = new System.Drawing.Point(20, 231);
            this.IngerientsLabel.Name = "IngerientsLabel";
            this.IngerientsLabel.Size = new System.Drawing.Size(75, 13);
            this.IngerientsLabel.TabIndex = 40;
            this.IngerientsLabel.Text = "Ингредиенты";
            // 
            // AddDishes
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddIng);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.IngerientsLabel);
            this.Controls.Add(this.Categoryes);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Kalories);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Portion);
            this.Controls.Add(this.CanShop);
            this.Controls.Add(this.DishName);
            this.Controls.Add(this.LabelCanShop);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelKalory);
            this.Controls.Add(this.LabelMass);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelPortion);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить блюдо";
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPortion;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelMass;
        private System.Windows.Forms.Label LabelKalory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelCanShop;
        private System.Windows.Forms.TextBox DishName;
        private System.Windows.Forms.CheckBox CanShop;
        private System.Windows.Forms.ComboBox Portion;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.NumericUpDown Mass;
        private System.Windows.Forms.NumericUpDown Kalories;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Categoryes;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddIng;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.ListBox Ingredients;
        private System.Windows.Forms.Label IngerientsLabel;
    }
}