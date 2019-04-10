namespace CourseWork
{
    partial class RaitingForm
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
            this.Ratings = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.RadioButton();
            this.Brew = new System.Windows.Forms.RadioButton();
            this.Dish = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Ratings)).BeginInit();
            this.SuspendLayout();
            // 
            // Ratings
            // 
            this.Ratings.AllowUserToAddRows = false;
            this.Ratings.AllowUserToDeleteRows = false;
            this.Ratings.AllowUserToResizeColumns = false;
            this.Ratings.AllowUserToResizeRows = false;
            this.Ratings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ratings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Names,
            this.Raiting});
            this.Ratings.Location = new System.Drawing.Point(12, 12);
            this.Ratings.Name = "Ratings";
            this.Ratings.ReadOnly = true;
            this.Ratings.RowHeadersVisible = false;
            this.Ratings.Size = new System.Drawing.Size(351, 324);
            this.Ratings.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.HeaderText = "type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 82;
            // 
            // Raiting
            // 
            this.Raiting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Raiting.HeaderText = "Рейтинг";
            this.Raiting.Name = "Raiting";
            this.Raiting.ReadOnly = true;
            this.Raiting.Width = 73;
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(288, 342);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 46;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Checked = true;
            this.All.Location = new System.Drawing.Point(370, 45);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(44, 17);
            this.All.TabIndex = 47;
            this.All.TabStop = true;
            this.All.Text = "Все";
            this.All.UseVisualStyleBackColor = true;
            this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // Brew
            // 
            this.Brew.AutoSize = true;
            this.Brew.Location = new System.Drawing.Point(369, 91);
            this.Brew.Name = "Brew";
            this.Brew.Size = new System.Drawing.Size(68, 17);
            this.Brew.TabIndex = 48;
            this.Brew.Text = "Напиток";
            this.Brew.UseVisualStyleBackColor = true;
            this.Brew.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // Dish
            // 
            this.Dish.AutoSize = true;
            this.Dish.Location = new System.Drawing.Point(369, 68);
            this.Dish.Name = "Dish";
            this.Dish.Size = new System.Drawing.Size(58, 17);
            this.Dish.TabIndex = 49;
            this.Dish.Text = "Блюда";
            this.Dish.UseVisualStyleBackColor = true;
            this.Dish.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // RaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(467, 372);
            this.Controls.Add(this.Dish);
            this.Controls.Add(this.Brew);
            this.Controls.Add(this.All);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Ratings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейтинг";
            ((System.ComponentModel.ISupportInitialize)(this.Ratings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ratings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiting;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.RadioButton Brew;
        private System.Windows.Forms.RadioButton Dish;
    }
}