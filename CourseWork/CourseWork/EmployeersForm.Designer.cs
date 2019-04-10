namespace CourseWork
{
    partial class EmployeersForm
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
            this.Employeers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Sort_label = new System.Windows.Forms.Label();
            this.Filtrs_Label = new System.Windows.Forms.Label();
            this.Job_Filtr = new System.Windows.Forms.CheckedListBox();
            this.JobFiltr_Label = new System.Windows.Forms.Label();
            this.FiltrDays = new System.Windows.Forms.CheckedListBox();
            this.Days_Label = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Employeers)).BeginInit();
            this.SuspendLayout();
            // 
            // Employeers
            // 
            this.Employeers.AllowUserToAddRows = false;
            this.Employeers.AllowUserToDeleteRows = false;
            this.Employeers.AllowUserToResizeColumns = false;
            this.Employeers.AllowUserToResizeRows = false;
            this.Employeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employeers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FLName,
            this.Job,
            this.Days,
            this.Number});
            this.Employeers.Location = new System.Drawing.Point(12, 79);
            this.Employeers.MultiSelect = false;
            this.Employeers.Name = "Employeers";
            this.Employeers.ReadOnly = true;
            this.Employeers.RowHeadersVisible = false;
            this.Employeers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Employeers.Size = new System.Drawing.Size(569, 334);
            this.Employeers.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 100;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FLName
            // 
            this.FLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FLName.HeaderText = "Имя";
            this.FLName.Name = "FLName";
            this.FLName.ReadOnly = true;
            this.FLName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FLName.Width = 35;
            // 
            // Job
            // 
            this.Job.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Job.HeaderText = "Должность";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            this.Job.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Job.Width = 71;
            // 
            // Days
            // 
            this.Days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Days.HeaderText = "Дни работы";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            this.Days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Days.Width = 74;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Number.Width = 47;
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "должности от большего",
            "должности от меньшего",
            "имени от большего",
            "имени от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(124, 52);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(190, 21);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 1;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(31, 55);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(87, 13);
            this.Sort_label.TabIndex = 2;
            this.Sort_label.Text = "Сортировать по";
            // 
            // Filtrs_Label
            // 
            this.Filtrs_Label.AutoSize = true;
            this.Filtrs_Label.Location = new System.Drawing.Point(587, 79);
            this.Filtrs_Label.Name = "Filtrs_Label";
            this.Filtrs_Label.Size = new System.Drawing.Size(74, 13);
            this.Filtrs_Label.TabIndex = 3;
            this.Filtrs_Label.Text = "Фильтрация:";
            // 
            // Job_Filtr
            // 
            this.Job_Filtr.FormattingEnabled = true;
            this.Job_Filtr.Location = new System.Drawing.Point(590, 121);
            this.Job_Filtr.Name = "Job_Filtr";
            this.Job_Filtr.ScrollAlwaysVisible = true;
            this.Job_Filtr.Size = new System.Drawing.Size(120, 79);
            this.Job_Filtr.TabIndex = 4;
            // 
            // JobFiltr_Label
            // 
            this.JobFiltr_Label.AutoSize = true;
            this.JobFiltr_Label.Location = new System.Drawing.Point(587, 105);
            this.JobFiltr_Label.Name = "JobFiltr_Label";
            this.JobFiltr_Label.Size = new System.Drawing.Size(65, 13);
            this.JobFiltr_Label.TabIndex = 5;
            this.JobFiltr_Label.Text = "Должность";
            // 
            // FiltrDays
            // 
            this.FiltrDays.FormattingEnabled = true;
            this.FiltrDays.Items.AddRange(new object[] {
            "Четные",
            "Нечетные"});
            this.FiltrDays.Location = new System.Drawing.Point(590, 241);
            this.FiltrDays.Name = "FiltrDays";
            this.FiltrDays.ScrollAlwaysVisible = true;
            this.FiltrDays.Size = new System.Drawing.Size(120, 49);
            this.FiltrDays.TabIndex = 6;
            // 
            // Days_Label
            // 
            this.Days_Label.AutoSize = true;
            this.Days_Label.Location = new System.Drawing.Point(587, 225);
            this.Days_Label.Name = "Days_Label";
            this.Days_Label.Size = new System.Drawing.Size(28, 13);
            this.Days_Label.TabIndex = 7;
            this.Days_Label.Text = "Дни";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(676, 380);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(87, 33);
            this.Apply.TabIndex = 13;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(595, 390);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 419);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 23);
            this.Back.TabIndex = 15;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(688, 33);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 23);
            this.Add.TabIndex = 16;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(584, 33);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(98, 23);
            this.Update.TabIndex = 19;
            this.Update.Text = "Изменить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(475, 33);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(103, 23);
            this.Info.TabIndex = 20;
            this.Info.Text = "Информация";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(364, 33);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(105, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EmployeersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Days_Label);
            this.Controls.Add(this.FiltrDays);
            this.Controls.Add(this.JobFiltr_Label);
            this.Controls.Add(this.Job_Filtr);
            this.Controls.Add(this.Filtrs_Label);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.Employeers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.Employeers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employeers;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.Label Filtrs_Label;
        private System.Windows.Forms.CheckedListBox Job_Filtr;
        private System.Windows.Forms.Label JobFiltr_Label;
        private System.Windows.Forms.CheckedListBox FiltrDays;
        private System.Windows.Forms.Label Days_Label;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}