namespace CourseWork
{
    partial class ProductsForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CountTo = new System.Windows.Forms.NumericUpDown();
            this.CountFrom = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.OnesList = new System.Windows.Forms.CheckedListBox();
            this.OnesLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.CountZero = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 320);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 40;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.AllowUserToAddRows = false;
            this.Products.AllowUserToDeleteRows = false;
            this.Products.AllowUserToResizeColumns = false;
            this.Products.AllowUserToResizeRows = false;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Count,
            this.Ones,
            this.MinCount});
            this.Products.Location = new System.Drawing.Point(12, 106);
            this.Products.Name = "Products";
            this.Products.RowHeadersVisible = false;
            this.Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Products.Size = new System.Drawing.Size(288, 198);
            this.Products.TabIndex = 39;
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
            this.Names.ReadOnly = true;
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 63;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Обьем";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.Width = 47;
            // 
            // Ones
            // 
            this.Ones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Ones.HeaderText = "Единицы";
            this.Ones.Name = "Ones";
            this.Ones.ReadOnly = true;
            this.Ones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ones.Width = 58;
            // 
            // MinCount
            // 
            this.MinCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MinCount.HeaderText = "Минимум";
            this.MinCount.Name = "MinCount";
            this.MinCount.ReadOnly = true;
            this.MinCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MinCount.Visible = false;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(414, 273);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 52;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(312, 285);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CountTo
            // 
            this.CountTo.Location = new System.Drawing.Point(356, 246);
            this.CountTo.Name = "CountTo";
            this.CountTo.Size = new System.Drawing.Size(61, 20);
            this.CountTo.TabIndex = 50;
            this.CountTo.ValueChanged += new System.EventHandler(this.CountFrom_ValueChanged);
            // 
            // CountFrom
            // 
            this.CountFrom.Location = new System.Drawing.Point(356, 220);
            this.CountFrom.Name = "CountFrom";
            this.CountFrom.Size = new System.Drawing.Size(61, 20);
            this.CountFrom.TabIndex = 49;
            this.CountFrom.ValueChanged += new System.EventHandler(this.CountFrom_ValueChanged);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(327, 192);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 13);
            this.CountLabel.TabIndex = 44;
            this.CountLabel.Text = "Количество";
            // 
            // OnesList
            // 
            this.OnesList.FormattingEnabled = true;
            this.OnesList.Location = new System.Drawing.Point(330, 125);
            this.OnesList.Name = "OnesList";
            this.OnesList.Size = new System.Drawing.Size(115, 64);
            this.OnesList.TabIndex = 43;
            // 
            // OnesLabel
            // 
            this.OnesLabel.AutoSize = true;
            this.OnesLabel.Location = new System.Drawing.Point(327, 106);
            this.OnesLabel.Name = "OnesLabel";
            this.OnesLabel.Size = new System.Drawing.Size(52, 13);
            this.OnesLabel.TabIndex = 42;
            this.OnesLabel.Text = "Единицы";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(327, 79);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 41;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(17, 74);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 54;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "количеству от большего",
            "количеству от меньшего",
            "названию от большего",
            "названию от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(110, 71);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 53;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // CountZero
            // 
            this.CountZero.Location = new System.Drawing.Point(311, 22);
            this.CountZero.Name = "CountZero";
            this.CountZero.Size = new System.Drawing.Size(81, 31);
            this.CountZero.TabIndex = 57;
            this.CountZero.Text = "Списать";
            this.CountZero.UseVisualStyleBackColor = true;
            this.CountZero.Click += new System.EventHandler(this.CountZero_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(435, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 50);
            this.Add.TabIndex = 56;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(206, 22);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 31);
            this.Delete.TabIndex = 55;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(575, 354);
            this.Controls.Add(this.CountZero);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CountTo);
            this.Controls.Add(this.CountFrom);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.OnesList);
            this.Controls.Add(this.OnesLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукты";
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown CountTo;
        private System.Windows.Forms.NumericUpDown CountFrom;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.CheckedListBox OnesList;
        private System.Windows.Forms.Label OnesLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button CountZero;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ones;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCount;
    }
}