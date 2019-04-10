using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AurhorizationForm : MainController
    {
        public AurhorizationForm() : base() { InitializeComponent(); ButtonLoad(); Label_password.Font = Label_login.Font; }


        private void Login_Click(object sender, EventArgs e)
        {
          (sender as TextBox ).Clear();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Fail.Hide();
            string days = "";
            if (DateTime.Now.Day % 2 == 1)
                days = "Нечетные";
            else
                days = "Четные";
            int userId = Controller.AuthorizationUser(Login.Text, Password.Text,days);
            if (userId != 0)
            {
                OpenForm(new MenuForm(userId),false);
                this.Close();
            }
            else
                Fail.Show();
        }


    }
}
