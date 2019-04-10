namespace CourseWork
{
    partial class AddProductsForm
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
            this.Products = new System.Windows.Forms.DataGridView();
            this.NamesLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.OnesLabel = new System.Windows.Forms.Label();
            this.NamesText = new System.Windows.Forms.ComboBox();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.OnesText = new System.Windows.Forms.ComboBox();
            this.AddRow = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Buy = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.AllowUserToAddRows = false;
            this.Products.AllowUserToDeleteRows = false;
            this.Products.AllowUserToResizeRows = false;
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Count,
            this.Ones,
            this.MinCount});
            this.Products.Location = new System.Drawing.Point(24, 12);
            this.Products.Name = "Products";
            this.Products.RowHeadersVisible = false;
            this.Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Products.Size = new System.Drawing.Size(288, 198);
            this.Products.TabIndex = 40;
            this.Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_CellContentClick);
            // 
            // NamesLabel
            // 
            this.NamesLabel.AutoSize = true;
            this.NamesLabel.Location = new System.Drawing.Point(31, 238);
            this.NamesLabel.Name = "NamesLabel";
            this.NamesLabel.Size = new System.Drawing.Size(57, 13);
            this.NamesLabel.TabIndex = 41;
            this.NamesLabel.Text = "Название";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(31, 285);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 13);
            this.CountLabel.TabIndex = 42;
            this.CountLabel.Text = "Количество";
            // 
            // OnesLabel
            // 
            this.OnesLabel.AutoSize = true;
            this.OnesLabel.Location = new System.Drawing.Point(161, 285);
            this.OnesLabel.Name = "OnesLabel";
            this.OnesLabel.Size = new System.Drawing.Size(52, 13);
            this.OnesLabel.TabIndex = 43;
            this.OnesLabel.Text = "Единицы";
            // 
            // NamesText
            // 
            this.NamesText.FormattingEnabled = true;
            this.NamesText.Location = new System.Drawing.Point(119, 235);
            this.NamesText.Name = "NamesText";
            this.NamesText.Size = new System.Drawing.Size(121, 21);
            this.NamesText.TabIndex = 45;
            this.NamesText.TextChanged += new System.EventHandler(this.NamesText_SelectedIndexChanged);
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(34, 313);
            this.CountText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(63, 20);
            this.CountText.TabIndex = 46;
            this.CountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OnesText
            // 
            this.OnesText.FormattingEnabled = true;
            this.OnesText.Location = new System.Drawing.Point(164, 312);
            this.OnesText.Name = "OnesText";
            this.OnesText.Size = new System.Drawing.Size(49, 21);
            this.OnesText.TabIndex = 47;
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(318, 178);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(83, 49);
            this.AddRow.TabIndex = 49;
            this.AddRow.Text = "Добавить строку";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Location = new System.Drawing.Point(318, 125);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(83, 47);
            this.DeleteRow.TabIndex = 50;
            this.DeleteRow.Text = "Удалить строку";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(22, 360);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 51;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(346, 360);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(75, 23);
            this.Buy.TabIndex = 52;
            this.Buy.Text = "Закупить";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
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
            this.MinCount.Width = 61;
            // 
            // AddProductsForm
            // 
            this.AcceptButton = this.Buy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(433, 395);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.OnesText);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.NamesText);
            this.Controls.Add(this.OnesLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.NamesLabel);
            this.Controls.Add(this.Products);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закупка";
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Label NamesLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label OnesLabel;
        private System.Windows.Forms.ComboBox NamesText;
        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.ComboBox OnesText;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ones;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinCount;
    }
}