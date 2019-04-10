namespace CourseWork
{
    partial class AddCustomerForm
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
            this.LnameText = new System.Windows.Forms.TextBox();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.ProcentText = new System.Windows.Forms.NumericUpDown();
            this.Procent = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcentText)).BeginInit();
            this.SuspendLayout();
            // 
            // LnameText
            // 
            this.LnameText.Location = new System.Drawing.Point(92, 65);
            this.LnameText.MaxLength = 20;
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(100, 20);
            this.LnameText.TabIndex = 27;
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(92, 28);
            this.FnameText.MaxLength = 20;
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(100, 20);
            this.FnameText.TabIndex = 26;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(24, 68);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(62, 13);
            this.Lname.TabIndex = 25;
            this.Lname.Text = "Фамилия: ";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(26, 35);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(35, 13);
            this.Fname.TabIndex = 24;
            this.Fname.Text = "Имя: ";
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(76, 105);
            this.AdresText.MaxLength = 140;
            this.AdresText.Multiline = true;
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(271, 64);
            this.AdresText.TabIndex = 29;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(26, 112);
            this.Adres.MaximumSize = new System.Drawing.Size(300, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(44, 13);
            this.Adres.TabIndex = 28;
            this.Adres.Text = "Адрес: ";
            // 
            // ProcentText
            // 
            this.ProcentText.Location = new System.Drawing.Point(92, 193);
            this.ProcentText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProcentText.Name = "ProcentText";
            this.ProcentText.Size = new System.Drawing.Size(120, 20);
            this.ProcentText.TabIndex = 31;
            this.ProcentText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Procent
            // 
            this.Procent.AutoSize = true;
            this.Procent.Location = new System.Drawing.Point(18, 193);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(56, 13);
            this.Procent.TabIndex = 30;
            this.Procent.Text = "Процент: ";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(9, 244);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add.Location = new System.Drawing.Point(142, 234);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 32;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddCustomerForm
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ProcentText);
            this.Controls.Add(this.Procent);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.LnameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить клиента";
            ((System.ComponentModel.ISupportInitialize)(this.ProcentText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.NumericUpDown ProcentText;
        private System.Windows.Forms.Label Procent;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
    }
}