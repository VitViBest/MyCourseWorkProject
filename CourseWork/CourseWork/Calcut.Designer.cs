namespace CourseWork
{
    partial class Calcut
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.Summ = new System.Windows.Forms.Label();
            this.GiveLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Give = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Give)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(25, 235);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(103, 26);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Done
            // 
            this.Done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Done.Location = new System.Drawing.Point(325, 235);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(103, 26);
            this.Done.TabIndex = 1;
            this.Done.Text = "Оплачено";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.Location = new System.Drawing.Point(103, 33);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(47, 13);
            this.Summ.TabIndex = 2;
            this.Summ.Text = "Сумма: ";
            // 
            // GiveLabel
            // 
            this.GiveLabel.AutoSize = true;
            this.GiveLabel.Location = new System.Drawing.Point(103, 73);
            this.GiveLabel.Name = "GiveLabel";
            this.GiveLabel.Size = new System.Drawing.Size(40, 13);
            this.GiveLabel.TabIndex = 3;
            this.GiveLabel.Text = "Дали: ";
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(103, 107);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(40, 13);
            this.Back.TabIndex = 4;
            this.Back.Text = "Сдача:";
            // 
            // Give
            // 
            this.Give.Location = new System.Drawing.Point(160, 66);
            this.Give.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Give.Name = "Give";
            this.Give.Size = new System.Drawing.Size(78, 20);
            this.Give.TabIndex = 5;
            this.Give.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Give.ValueChanged += new System.EventHandler(this.Give_ValueChanged);
            // 
            // Calcut
            // 
            this.AcceptButton = this.Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(440, 276);
            this.Controls.Add(this.Give);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.GiveLabel);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calcut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcut";
            ((System.ComponentModel.ISupportInitialize)(this.Give)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label Summ;
        private System.Windows.Forms.Label GiveLabel;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.NumericUpDown Give;
    }
}