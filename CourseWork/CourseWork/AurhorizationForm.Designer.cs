namespace CourseWork
{
    partial class AurhorizationForm
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
            this.Enter = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Label_login = new System.Windows.Forms.Label();
            this.Label_password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Fail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Location = new System.Drawing.Point(425, 277);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(310, 277);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Label_login
            // 
            this.Label_login.AutoSize = true;
            this.Label_login.Location = new System.Drawing.Point(114, 182);
            this.Label_login.Name = "Label_login";
            this.Label_login.Size = new System.Drawing.Size(56, 13);
            this.Label_login.TabIndex = 2;
            this.Label_login.Text = "Фамилия";
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.Location = new System.Drawing.Point(114, 226);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(45, 13);
            this.Label_password.TabIndex = 3;
            this.Label_password.Text = "Пароль";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(176, 175);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(251, 20);
            this.Login.TabIndex = 4;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(176, 223);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(251, 20);
            this.Password.TabIndex = 5;
            this.Password.Click += new System.EventHandler(this.Login_Click);
            // 
            // Fail
            // 
            this.Fail.AutoSize = true;
            this.Fail.BackColor = System.Drawing.SystemColors.Control;
            this.Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fail.ForeColor = System.Drawing.Color.Red;
            this.Fail.Location = new System.Drawing.Point(148, 9);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(279, 144);
            this.Fail.TabIndex = 6;
            this.Fail.Text = "Вход в систему запрещен!\r\nВозможные причины:\r\n-Неверный логин.\r\n-Неверный пароль." +
    "\r\n-Вы сегодня не работаете.\r\n-У вас нет доступа к системе.";
            this.Fail.Visible = false;
            // 
            // AurhorizationForm
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(554, 327);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.Label_login);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AurhorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Войти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Label_login;
        private System.Windows.Forms.Label Label_password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Fail;
    }
}