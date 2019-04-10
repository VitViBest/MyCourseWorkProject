namespace CourseWork
{
    partial class OrderBrewForm
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
            this.Brews = new System.Windows.Forms.DataGridView();
            this.VolumeTo = new System.Windows.Forms.NumericUpDown();
            this.VolumeFrom = new System.Windows.Forms.NumericUpDown();
            this.CostTo = new System.Windows.Forms.NumericUpDown();
            this.CostFrom = new System.Windows.Forms.NumericUpDown();
            this.OnlyCan = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.IngredientsFiltr = new System.Windows.Forms.CheckedListBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Brews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // Brews
            // 
            this.Brews.AllowUserToAddRows = false;
            this.Brews.AllowUserToDeleteRows = false;
            this.Brews.AllowUserToResizeRows = false;
            this.Brews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Brews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Volume,
            this.Cost,
            this.Category,
            this.CanShop,
            this.Ingredients});
            this.Brews.Location = new System.Drawing.Point(28, 88);
            this.Brews.Name = "Brews";
            this.Brews.RowHeadersVisible = false;
            this.Brews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Brews.Size = new System.Drawing.Size(644, 256);
            this.Brews.TabIndex = 1;
            // 
            // VolumeTo
            // 
            this.VolumeTo.Location = new System.Drawing.Point(731, 181);
            this.VolumeTo.Name = "VolumeTo";
            this.VolumeTo.Size = new System.Drawing.Size(61, 20);
            this.VolumeTo.TabIndex = 35;
            this.VolumeTo.ValueChanged += new System.EventHandler(this.VolumeFrom_ValueChanged);
            // 
            // VolumeFrom
            // 
            this.VolumeFrom.Location = new System.Drawing.Point(731, 155);
            this.VolumeFrom.Name = "VolumeFrom";
            this.VolumeFrom.Size = new System.Drawing.Size(61, 20);
            this.VolumeFrom.TabIndex = 34;
            this.VolumeFrom.ValueChanged += new System.EventHandler(this.VolumeFrom_ValueChanged);
            // 
            // CostTo
            // 
            this.CostTo.Location = new System.Drawing.Point(811, 181);
            this.CostTo.Name = "CostTo";
            this.CostTo.Size = new System.Drawing.Size(61, 20);
            this.CostTo.TabIndex = 33;
            this.CostTo.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // CostFrom
            // 
            this.CostFrom.Location = new System.Drawing.Point(811, 155);
            this.CostFrom.Name = "CostFrom";
            this.CostFrom.Size = new System.Drawing.Size(61, 20);
            this.CostFrom.TabIndex = 32;
            this.CostFrom.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // OnlyCan
            // 
            this.OnlyCan.AutoSize = true;
            this.OnlyCan.Location = new System.Drawing.Point(734, 208);
            this.OnlyCan.Name = "OnlyCan";
            this.OnlyCan.Size = new System.Drawing.Size(120, 17);
            this.OnlyCan.TabIndex = 31;
            this.OnlyCan.Text = "Только доступные";
            this.OnlyCan.UseVisualStyleBackColor = true;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(808, 139);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 13);
            this.CostLabel.TabIndex = 30;
            this.CostLabel.Text = "Стоимость";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(736, 139);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(41, 13);
            this.VolumeLabel.TabIndex = 29;
            this.VolumeLabel.Text = "Обьем";
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(739, 62);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(115, 64);
            this.CategoryList.TabIndex = 28;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(736, 46);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 27;
            this.CategoryLabel.Text = "Категория";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(762, 22);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 24;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(54, 64);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 37;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "названию от большего",
            "названию от меньшего",
            "объему от большего",
            "объему от меньшего",
            "стоимости от большего",
            "стоимость от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(147, 61);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 36;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 38;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(831, 246);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 40;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(739, 270);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 39;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(373, 51);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 31);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(574, 32);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 50);
            this.Add.TabIndex = 42;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(475, 51);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(81, 31);
            this.Change.TabIndex = 43;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(875, 46);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(74, 13);
            this.IngredientsLabel.TabIndex = 45;
            this.IngredientsLabel.Text = "Ингредтенты";
            // 
            // IngredientsFiltr
            // 
            this.IngredientsFiltr.FormattingEnabled = true;
            this.IngredientsFiltr.Location = new System.Drawing.Point(878, 62);
            this.IngredientsFiltr.Name = "IngredientsFiltr";
            this.IngredientsFiltr.Size = new System.Drawing.Size(207, 139);
            this.IngredientsFiltr.TabIndex = 44;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 22;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 63;
            // 
            // Volume
            // 
            this.Volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Volume.HeaderText = "Обьем";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            this.Volume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Volume.Width = 47;
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
            // OrderBrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(1118, 364);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.IngredientsFiltr);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.VolumeTo);
            this.Controls.Add(this.VolumeFrom);
            this.Controls.Add(this.CostTo);
            this.Controls.Add(this.CostFrom);
            this.Controls.Add(this.OnlyCan);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Brews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderBrewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Напитки";
            ((System.ComponentModel.ISupportInitialize)(this.Brews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Brews;
        private System.Windows.Forms.NumericUpDown VolumeTo;
        private System.Windows.Forms.NumericUpDown VolumeFrom;
        private System.Windows.Forms.NumericUpDown CostTo;
        private System.Windows.Forms.NumericUpDown CostFrom;
        private System.Windows.Forms.CheckBox OnlyCan;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.CheckedListBox IngredientsFiltr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
    }
}