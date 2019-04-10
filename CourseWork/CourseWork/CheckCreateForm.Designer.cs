namespace CourseWork
{
    partial class CheckCreateForm
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.TextBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.ComboBox();
            this.Employeer = new System.Windows.Forms.ComboBox();
            this.EmployeerLabel = new System.Windows.Forms.Label();
            this.TimeOrder = new System.Windows.Forms.DateTimePicker();
            this.TimeOrderLabel = new System.Windows.Forms.Label();
            this.DateGive = new System.Windows.Forms.DateTimePicker();
            this.DateGiveLabel = new System.Windows.Forms.Label();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.Label();
            this.Statys = new System.Windows.Forms.ComboBox();
            this.StatysLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.MaskedTextBox();
            this.Dishes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tovar = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.AllMoney = new System.Windows.Forms.TextBox();
            this.AllLabel = new System.Windows.Forms.Label();
            this.CountTov = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTov)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(12, 28);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(59, 13);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Закащик: ";
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(77, 25);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(164, 20);
            this.Customer.TabIndex = 1;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(12, 71);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(34, 13);
            this.TableLabel.TabIndex = 2;
            this.TableLabel.Text = "Стол ";
            // 
            // Table
            // 
            this.Table.FormattingEnabled = true;
            this.Table.Location = new System.Drawing.Point(77, 68);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(126, 21);
            this.Table.TabIndex = 3;
            this.Table.Click += new System.EventHandler(this.AdresText_Click);
            // 
            // Employeer
            // 
            this.Employeer.FormattingEnabled = true;
            this.Employeer.Location = new System.Drawing.Point(77, 111);
            this.Employeer.Name = "Employeer";
            this.Employeer.Size = new System.Drawing.Size(126, 21);
            this.Employeer.TabIndex = 5;
            // 
            // EmployeerLabel
            // 
            this.EmployeerLabel.AutoSize = true;
            this.EmployeerLabel.Location = new System.Drawing.Point(12, 114);
            this.EmployeerLabel.Name = "EmployeerLabel";
            this.EmployeerLabel.Size = new System.Drawing.Size(60, 13);
            this.EmployeerLabel.TabIndex = 4;
            this.EmployeerLabel.Text = "Сотрудник";
            // 
            // TimeOrder
            // 
            this.TimeOrder.CustomFormat = "yyyy-MM-dd-HH-mm";
            this.TimeOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOrder.Location = new System.Drawing.Point(470, 35);
            this.TimeOrder.Name = "TimeOrder";
            this.TimeOrder.Size = new System.Drawing.Size(200, 20);
            this.TimeOrder.TabIndex = 27;
            // 
            // TimeOrderLabel
            // 
            this.TimeOrderLabel.AutoSize = true;
            this.TimeOrderLabel.Location = new System.Drawing.Point(372, 35);
            this.TimeOrderLabel.Name = "TimeOrderLabel";
            this.TimeOrderLabel.Size = new System.Drawing.Size(82, 13);
            this.TimeOrderLabel.TabIndex = 26;
            this.TimeOrderLabel.Text = "Время заказа:";
            // 
            // DateGive
            // 
            this.DateGive.CustomFormat = "yyyy-MM-dd-HH-mm";
            this.DateGive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateGive.Location = new System.Drawing.Point(470, 71);
            this.DateGive.Name = "DateGive";
            this.DateGive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateGive.Size = new System.Drawing.Size(200, 20);
            this.DateGive.TabIndex = 29;
            // 
            // DateGiveLabel
            // 
            this.DateGiveLabel.AutoSize = true;
            this.DateGiveLabel.Location = new System.Drawing.Point(372, 71);
            this.DateGiveLabel.Name = "DateGiveLabel";
            this.DateGiveLabel.Size = new System.Drawing.Size(83, 13);
            this.DateGiveLabel.TabIndex = 28;
            this.DateGiveLabel.Text = "Время выдачи:";
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(399, 114);
            this.AdresText.MaxLength = 140;
            this.AdresText.Multiline = true;
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(271, 64);
            this.AdresText.TabIndex = 32;
            this.AdresText.Click += new System.EventHandler(this.AdresText_Click);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(27, 522);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 27);
            this.Back.TabIndex = 31;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(349, 121);
            this.Adres.MaximumSize = new System.Drawing.Size(300, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(44, 13);
            this.Adres.TabIndex = 30;
            this.Adres.Text = "Адрес: ";
            // 
            // Statys
            // 
            this.Statys.FormattingEnabled = true;
            this.Statys.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Доставляется",
            "Выдан"});
            this.Statys.Location = new System.Drawing.Point(77, 157);
            this.Statys.Name = "Statys";
            this.Statys.Size = new System.Drawing.Size(126, 21);
            this.Statys.TabIndex = 34;
            this.Statys.SelectedIndexChanged += new System.EventHandler(this.Statys_SelectedIndexChanged);
            // 
            // StatysLabel
            // 
            this.StatysLabel.AutoSize = true;
            this.StatysLabel.Location = new System.Drawing.Point(12, 160);
            this.StatysLabel.Name = "StatysLabel";
            this.StatysLabel.Size = new System.Drawing.Size(41, 13);
            this.StatysLabel.TabIndex = 33;
            this.StatysLabel.Text = "Статус";
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.Location = new System.Drawing.Point(441, 204);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(60, 13);
            this.CardLabel.TabIndex = 35;
            this.CardLabel.Text = "Код карты";
            // 
            // Card
            // 
            this.Card.Location = new System.Drawing.Point(520, 197);
            this.Card.Mask = "000000";
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(100, 20);
            this.Card.TabIndex = 37;
            this.Card.ValidatingType = typeof(int);
            this.Card.Click += new System.EventHandler(this.Card_Click);
            this.Card.TextChanged += new System.EventHandler(this.Card_TextChanged);
            // 
            // Dishes
            // 
            this.Dishes.AllowUserToAddRows = false;
            this.Dishes.AllowUserToDeleteRows = false;
            this.Dishes.AllowUserToResizeRows = false;
            this.Dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category,
            this.Names,
            this.Count,
            this.Cost});
            this.Dishes.Location = new System.Drawing.Point(60, 242);
            this.Dishes.MultiSelect = false;
            this.Dishes.Name = "Dishes";
            this.Dishes.RowHeadersVisible = false;
            this.Dishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dishes.Size = new System.Drawing.Size(713, 198);
            this.Dishes.TabIndex = 38;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
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
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 91;
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
            // Tovar
            // 
            this.Tovar.DropDownHeight = 100;
            this.Tovar.FormattingEnabled = true;
            this.Tovar.IntegralHeight = false;
            this.Tovar.Location = new System.Drawing.Point(60, 446);
            this.Tovar.Name = "Tovar";
            this.Tovar.Size = new System.Drawing.Size(217, 21);
            this.Tovar.TabIndex = 39;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(352, 441);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 25);
            this.Add.TabIndex = 40;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 270);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(45, 25);
            this.Delete.TabIndex = 41;
            this.Delete.Text = "-";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(652, 522);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(121, 27);
            this.Create.TabIndex = 42;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AllMoney
            // 
            this.AllMoney.Location = new System.Drawing.Point(676, 446);
            this.AllMoney.Name = "AllMoney";
            this.AllMoney.ReadOnly = true;
            this.AllMoney.Size = new System.Drawing.Size(97, 20);
            this.AllMoney.TabIndex = 44;
            this.AllMoney.Text = "0";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Location = new System.Drawing.Point(611, 454);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(37, 13);
            this.AllLabel.TabIndex = 43;
            this.AllLabel.Text = "Всего";
            // 
            // CountTov
            // 
            this.CountTov.Location = new System.Drawing.Point(290, 446);
            this.CountTov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountTov.Name = "CountTov";
            this.CountTov.Size = new System.Drawing.Size(56, 20);
            this.CountTov.TabIndex = 45;
            this.CountTov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckCreateForm
            // 
            this.AcceptButton = this.Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.CountTov);
            this.Controls.Add(this.AllMoney);
            this.Controls.Add(this.AllLabel);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Tovar);
            this.Controls.Add(this.Dishes);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.Statys);
            this.Controls.Add(this.StatysLabel);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.DateGive);
            this.Controls.Add(this.DateGiveLabel);
            this.Controls.Add(this.TimeOrder);
            this.Controls.Add(this.TimeOrderLabel);
            this.Controls.Add(this.Employeer);
            this.Controls.Add(this.EmployeerLabel);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.CustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckCreateForm";
            this.Text = "Создать чек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckCreateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Dishes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountTov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox Table;
        private System.Windows.Forms.ComboBox Employeer;
        private System.Windows.Forms.Label EmployeerLabel;
        private System.Windows.Forms.DateTimePicker TimeOrder;
        private System.Windows.Forms.Label TimeOrderLabel;
        private System.Windows.Forms.DateTimePicker DateGive;
        private System.Windows.Forms.Label DateGiveLabel;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.ComboBox Statys;
        private System.Windows.Forms.Label StatysLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.MaskedTextBox Card;
        private System.Windows.Forms.DataGridView Dishes;
        private System.Windows.Forms.ComboBox Tovar;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox AllMoney;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.NumericUpDown CountTov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}