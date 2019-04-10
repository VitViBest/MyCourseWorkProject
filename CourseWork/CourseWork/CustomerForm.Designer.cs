namespace CourseWork
{
    partial class CustomerForm
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
            this.Customers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.PercentTo = new System.Windows.Forms.NumericUpDown();
            this.PercentFrom = new System.Windows.Forms.NumericUpDown();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Change = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.AllowUserToAddRows = false;
            this.Customers.AllowUserToDeleteRows = false;
            this.Customers.AllowUserToResizeRows = false;
            this.Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fname,
            this.Adres,
            this.Procent});
            this.Customers.Location = new System.Drawing.Point(12, 173);
            this.Customers.Name = "Customers";
            this.Customers.RowHeadersVisible = false;
            this.Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Customers.Size = new System.Drawing.Size(344, 169);
            this.Customers.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Код";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 32;
            // 
            // Fname
            // 
            this.Fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fname.HeaderText = "Имя";
            this.Fname.Name = "Fname";
            this.Fname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fname.Width = 35;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adres.HeaderText = "Адрес";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adres.Width = 44;
            // 
            // Procent
            // 
            this.Procent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Procent.HeaderText = "Процент";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            this.Procent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Procent.Width = 56;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(365, 264);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 52;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(365, 317);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PercentTo
            // 
            this.PercentTo.Location = new System.Drawing.Point(365, 238);
            this.PercentTo.Name = "PercentTo";
            this.PercentTo.Size = new System.Drawing.Size(61, 20);
            this.PercentTo.TabIndex = 48;
            this.PercentTo.ValueChanged += new System.EventHandler(this.PercentFrom_ValueChanged);
            // 
            // PercentFrom
            // 
            this.PercentFrom.Location = new System.Drawing.Point(365, 212);
            this.PercentFrom.Name = "PercentFrom";
            this.PercentFrom.Size = new System.Drawing.Size(61, 20);
            this.PercentFrom.TabIndex = 47;
            this.PercentFrom.ValueChanged += new System.EventHandler(this.PercentFrom_ValueChanged);
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(362, 196);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(50, 13);
            this.PercentLabel.TabIndex = 45;
            this.PercentLabel.Text = "Процент";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(362, 173);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 41;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 380);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 53;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(15, 140);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 55;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "названию от большего",
            "названию от меньшего",
            "проценту от большего",
            "проценту от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(108, 137);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 54;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(253, 45);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(81, 31);
            this.Change.TabIndex = 58;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(377, 35);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 50);
            this.Add.TabIndex = 57;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(148, 45);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 31);
            this.Delete.TabIndex = 56;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(487, 415);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.PercentTo);
            this.Controls.Add(this.PercentFrom);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Customers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Постоянные клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PercentFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Customers;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown PercentTo;
        private System.Windows.Forms.NumericUpDown PercentFrom;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
    }
}