namespace CourseWork
{
    partial class ProfileForm
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
            this.Fname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Born = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(26, 27);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(35, 13);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "Имя: ";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(24, 60);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(62, 13);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "Фамилия: ";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(26, 88);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(60, 13);
            this.Sname.TabIndex = 2;
            this.Sname.Text = "Отчество: ";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(24, 227);
            this.Adres.MaximumSize = new System.Drawing.Size(300, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(44, 13);
            this.Adres.TabIndex = 5;
            this.Adres.Text = "Адрес: ";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(24, 185);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(99, 13);
            this.Number.TabIndex = 4;
            this.Number.Text = "Номер телефона: ";
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(24, 152);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(92, 13);
            this.Born.TabIndex = 3;
            this.Born.Text = "Дата рождения: ";
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(361, 102);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(74, 13);
            this.Days.TabIndex = 8;
            this.Days.Text = "Дни работы: ";
            // 
            // Job
            // 
            this.Job.AutoSize = true;
            this.Job.Location = new System.Drawing.Point(361, 60);
            this.Job.MaximumSize = new System.Drawing.Size(200, 0);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(71, 13);
            this.Job.TabIndex = 7;
            this.Job.Text = "Должность: ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(361, 138);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(51, 13);
            this.Password.TabIndex = 9;
            this.Password.Text = "Пароль: ";
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(468, 269);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 27);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AcceptButton = this.Back;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(601, 308);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Born);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label Job;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Back;
    }
}