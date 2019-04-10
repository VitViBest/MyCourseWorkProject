namespace CourseWork
{
    partial class DateFrom
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
            this.Statist = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryList = new System.Windows.Forms.CheckedListBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.TypeFiltr = new System.Windows.Forms.CheckedListBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateWith = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllCount = new System.Windows.Forms.TextBox();
            this.AllMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Statist)).BeginInit();
            this.SuspendLayout();
            // 
            // Statist
            // 
            this.Statist.AllowUserToAddRows = false;
            this.Statist.AllowUserToDeleteRows = false;
            this.Statist.AllowUserToResizeRows = false;
            this.Statist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Statist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Type,
            this.Category,
            this.Count,
            this.Summ});
            this.Statist.Location = new System.Drawing.Point(12, 12);
            this.Statist.Name = "Statist";
            this.Statist.RowHeadersVisible = false;
            this.Statist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Statist.Size = new System.Drawing.Size(559, 258);
            this.Statist.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Width = 32;
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
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.Width = 72;
            // 
            // Summ
            // 
            this.Summ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Summ.HeaderText = "Сумма";
            this.Summ.Name = "Summ";
            this.Summ.ReadOnly = true;
            this.Summ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Summ.Width = 47;
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(601, 99);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(115, 64);
            this.CategoryList.TabIndex = 31;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(598, 83);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 30;
            this.CategoryLabel.Text = "Категория";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(616, 7);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 29;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // TypeFiltr
            // 
            this.TypeFiltr.FormattingEnabled = true;
            this.TypeFiltr.Location = new System.Drawing.Point(601, 46);
            this.TypeFiltr.Name = "TypeFiltr";
            this.TypeFiltr.Size = new System.Drawing.Size(115, 34);
            this.TypeFiltr.TabIndex = 33;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(598, 30);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(29, 13);
            this.TypeLabel.TabIndex = 32;
            this.TypeLabel.Text = " Тип";
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(691, 218);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 42;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(589, 230);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 41;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(598, 175);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 44;
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
            this.SortPanel.Location = new System.Drawing.Point(601, 191);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 43;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 315);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 45;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // DateTo
            // 
            this.DateTo.CustomFormat = "yyyy-MM-dd";
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTo.Location = new System.Drawing.Point(758, 135);
            this.DateTo.Name = "DateTo";
            this.DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTo.Size = new System.Drawing.Size(139, 20);
            this.DateTo.TabIndex = 47;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateWith_ValueChanged);
            // 
            // DateWith
            // 
            this.DateWith.CustomFormat = "yyyy-MM-dd";
            this.DateWith.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateWith.Location = new System.Drawing.Point(758, 99);
            this.DateWith.Name = "DateWith";
            this.DateWith.Size = new System.Drawing.Size(139, 20);
            this.DateWith.TabIndex = 46;
            this.DateWith.ValueChanged += new System.EventHandler(this.DateWith_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Период";
            // 
            // AllCount
            // 
            this.AllCount.Location = new System.Drawing.Point(172, 276);
            this.AllCount.Name = "AllCount";
            this.AllCount.ReadOnly = true;
            this.AllCount.Size = new System.Drawing.Size(55, 20);
            this.AllCount.TabIndex = 51;
            // 
            // AllMoney
            // 
            this.AllMoney.Location = new System.Drawing.Point(516, 276);
            this.AllMoney.Name = "AllMoney";
            this.AllMoney.ReadOnly = true;
            this.AllMoney.Size = new System.Drawing.Size(55, 20);
            this.AllMoney.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Всего куплено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Всего заработано";
            // 
            // DateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(913, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllMoney);
            this.Controls.Add(this.AllCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateWith);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TypeFiltr);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Statist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.Statist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Statist;
        private System.Windows.Forms.CheckedListBox CategoryList;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.CheckedListBox TypeFiltr;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AllCount;
        private System.Windows.Forms.TextBox AllMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
    }
}