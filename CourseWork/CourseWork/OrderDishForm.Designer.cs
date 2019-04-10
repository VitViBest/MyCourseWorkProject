namespace CourseWork
{
    partial class OrderDishForm
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
            this.Dishes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Portion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaloryes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.PortionLabel = new System.Windows.Forms.Label();
            this.PortionList = new System.Windows.Forms.CheckedListBox();
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.MassLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.OnlyCan = new System.Windows.Forms.CheckBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.CostFrom = new System.Windows.Forms.NumericUpDown();
            this.CostTo = new System.Windows.Forms.NumericUpDown();
            this.MassFrom = new System.Windows.Forms.NumericUpDown();
            this.MassTo = new System.Windows.Forms.NumericUpDown();
            this.Change = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.IngredientsFiltr = new System.Windows.Forms.CheckedListBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassTo)).BeginInit();
            this.SuspendLayout();
            // 
            // Dishes
            // 
            this.Dishes.AllowUserToAddRows = false;
            this.Dishes.AllowUserToDeleteRows = false;
            this.Dishes.AllowUserToResizeRows = false;
            this.Dishes.BackgroundColor = System.Drawing.Color.White;
            this.Dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Portion,
            this.Cost,
            this.Mass,
            this.Kaloryes,
            this.Category,
            this.CanShop,
            this.Ingredients});
            this.Dishes.Location = new System.Drawing.Point(15, 81);
            this.Dishes.Name = "Dishes";
            this.Dishes.RowHeadersVisible = false;
            this.Dishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dishes.Size = new System.Drawing.Size(816, 275);
            this.Dishes.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 63;
            // 
            // Portion
            // 
            this.Portion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Portion.HeaderText = "Порция";
            this.Portion.Name = "Portion";
            this.Portion.ReadOnly = true;
            this.Portion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Portion.Width = 51;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cost.Width = 68;
            // 
            // Mass
            // 
            this.Mass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Mass.HeaderText = "Масса";
            this.Mass.Name = "Mass";
            this.Mass.ReadOnly = true;
            this.Mass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mass.Width = 46;
            // 
            // Kaloryes
            // 
            this.Kaloryes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kaloryes.HeaderText = "Калории";
            this.Kaloryes.Name = "Kaloryes";
            this.Kaloryes.ReadOnly = true;
            this.Kaloryes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Kaloryes.Width = 56;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category.Width = 66;
            // 
            // CanShop
            // 
            this.CanShop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CanShop.HeaderText = "Доступен";
            this.CanShop.Name = "CanShop";
            this.CanShop.ReadOnly = true;
            this.CanShop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CanShop.Width = 62;
            // 
            // Ingredients
            // 
            this.Ingredients.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ingredients.HeaderText = "Ингредиенты";
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.ReadOnly = true;
            this.Ingredients.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ingredients.Width = 81;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(511, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 50);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(17, 57);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 4;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "калориям от большего",
            "калориям от меньшего",
            "массе от большего",
            "массе от меньшего",
            "названию от большего",
            "названию от меньшего",
            "стоимости от большего",
            "стоимость от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(110, 54);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 3;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(17, 362);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(832, 13);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 6;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // PortionLabel
            // 
            this.PortionLabel.AutoSize = true;
            this.PortionLabel.Location = new System.Drawing.Point(832, 47);
            this.PortionLabel.Name = "PortionLabel";
            this.PortionLabel.Size = new System.Drawing.Size(45, 13);
            this.PortionLabel.TabIndex = 7;
            this.PortionLabel.Text = "Порция";
            // 
            // PortionList
            // 
            this.PortionList.FormattingEnabled = true;
            this.PortionList.Items.AddRange(new object[] {
            "Маленькая",
            "Стандарт",
            "Большая"});
            this.PortionList.Location = new System.Drawing.Point(835, 63);
            this.PortionList.Name = "PortionList";
            this.PortionList.Size = new System.Drawing.Size(115, 49);
            this.PortionList.TabIndex = 8;
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(837, 134);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(115, 64);
            this.CategoryList.TabIndex = 10;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(834, 118);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Категория";
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(837, 217);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(40, 13);
            this.MassLabel.TabIndex = 11;
            this.MassLabel.Text = "Масса";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(940, 217);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 13);
            this.CostLabel.TabIndex = 14;
            this.CostLabel.Text = "Стоимость";
            // 
            // OnlyCan
            // 
            this.OnlyCan.AutoSize = true;
            this.OnlyCan.Location = new System.Drawing.Point(844, 296);
            this.OnlyCan.Name = "OnlyCan";
            this.OnlyCan.Size = new System.Drawing.Size(120, 17);
            this.OnlyCan.TabIndex = 17;
            this.OnlyCan.Text = "Только доступные";
            this.OnlyCan.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(1012, 333);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(1107, 309);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 19;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // CostFrom
            // 
            this.CostFrom.Location = new System.Drawing.Point(943, 233);
            this.CostFrom.Name = "CostFrom";
            this.CostFrom.Size = new System.Drawing.Size(61, 20);
            this.CostFrom.TabIndex = 20;
            this.CostFrom.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // CostTo
            // 
            this.CostTo.Location = new System.Drawing.Point(943, 259);
            this.CostTo.Name = "CostTo";
            this.CostTo.Size = new System.Drawing.Size(61, 20);
            this.CostTo.TabIndex = 21;
            this.CostTo.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // MassFrom
            // 
            this.MassFrom.Location = new System.Drawing.Point(863, 233);
            this.MassFrom.Name = "MassFrom";
            this.MassFrom.Size = new System.Drawing.Size(61, 20);
            this.MassFrom.TabIndex = 22;
            this.MassFrom.ValueChanged += new System.EventHandler(this.MassFrom_ValueChanged);
            // 
            // MassTo
            // 
            this.MassTo.Location = new System.Drawing.Point(863, 259);
            this.MassTo.Name = "MassTo";
            this.MassTo.Size = new System.Drawing.Size(61, 20);
            this.MassTo.TabIndex = 23;
            this.MassTo.ValueChanged += new System.EventHandler(this.MassFrom_ValueChanged);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(412, 31);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(81, 31);
            this.Change.TabIndex = 24;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(316, 31);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 31);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // IngredientsFiltr
            // 
            this.IngredientsFiltr.FormattingEnabled = true;
            this.IngredientsFiltr.Location = new System.Drawing.Point(999, 63);
            this.IngredientsFiltr.Name = "IngredientsFiltr";
            this.IngredientsFiltr.Size = new System.Drawing.Size(207, 139);
            this.IngredientsFiltr.TabIndex = 26;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(996, 47);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(74, 13);
            this.IngredientsLabel.TabIndex = 27;
            this.IngredientsLabel.Text = "Ингредтенты";
            // 
            // OrderDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(1232, 399);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.IngredientsFiltr);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.MassTo);
            this.Controls.Add(this.MassFrom);
            this.Controls.Add(this.CostTo);
            this.Controls.Add(this.CostFrom);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OnlyCan);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PortionList);
            this.Controls.Add(this.PortionLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Dishes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список блюд";
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MassTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dishes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Label PortionLabel;
        private System.Windows.Forms.CheckedListBox PortionList;
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckBox OnlyCan;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.NumericUpDown CostFrom;
        private System.Windows.Forms.NumericUpDown CostTo;
        private System.Windows.Forms.NumericUpDown MassFrom;
        private System.Windows.Forms.NumericUpDown MassTo;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckedListBox IngredientsFiltr;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Portion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaloryes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
    }
}