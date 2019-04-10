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
    public partial class AddEmployerForm : MainController
    {
        List<List<string>> Jobs;
        int Id;
    
        public AddEmployerForm():base()
        {
            InitializeComponent();
            Id = 0;
            Random r = new Random();
            string PasswordRand;
            do
            {
                PasswordRand = "";
                for (int i = 0; i < 7; i++)
                {
                    PasswordRand += (int)r.Next(0, 9);
                }
            } while (Controller.GetAllFrom(SpecialSqlController.Tables.employeers, "Password='" + PasswordRand + "'").Count != 0);
            Password.Text += PasswordRand;
            BornText.MinDate = DateTime.Now.Date.AddYears(-50);
            BornText.MaxDate = DateTime.Now.Date.AddYears(-18);
            GetJobs();
            DaysText.DropDownStyle = ComboBoxStyle.DropDownList;
            DaysText.SelectedIndex = 0;
            JobText.DropDownStyle = ComboBoxStyle.DropDownList;
          
        }

        public AddEmployerForm(Dictionary<string, string> info):base()
        {
            InitializeComponent();
            DaysText.DropDownStyle = JobText.DropDownStyle = ComboBoxStyle.DropDownList;
            GetJobs();
            this.Text = "Изменить";
            Add.Text= "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            FnameText.Text = info["Fname"];
             LnameText.Text = info["Lname"];
            SnameText.Text = info["Sname"];
            BornText.Text = info["Born"];
            NumberText.Text = info["Number"];
            AdresText.Text = info["Adres"];
            DaysText.Text = info["Days"];
            JobText.Text = info["Job"];

            if (info["Password"].Length>0)
            {
                Password.Text += info["Password"];
                NeedPassword.Checked = true;
            }
            else
            {
                Random r = new Random();
                string PasswordRand;
                do
                {
                    PasswordRand = "";
                    for (int i = 0; i < 7; i++)
                    {
                        PasswordRand += (int)r.Next(0, 9);
                    }
                } while (Controller.GetAllFrom(SpecialSqlController.Tables.employeers, "Password='" + PasswordRand + "'").Count != 0);
                Password.Text += PasswordRand;
            }
            BornText.MinDate = DateTime.Now.Date.AddYears(-50);
            BornText.MaxDate = DateTime.Now.Date.AddYears(-18);
        }
        private void GetJobs()
        {
            JobText.Items.Clear();
             Jobs = Controller.GetAllFrom(SpecialSqlController.Tables.job, "Enable=1");
            foreach (var j in Jobs)
            {
                JobText.Items.Add(j[1]);
            }
        }

        private void NumberText_Click(object sender, EventArgs e)
        {
           (sender as MaskedTextBox).Clear();
           (sender as MaskedTextBox).SelectionStart = 0;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (FnameText.Text.Length < 1) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (LnameText.Text.Length < 1) { Error("Не правильно введена фамилия"); return true; }; return false; });
            tests.Add(delegate () { if (SnameText.Text.Length < 1) { Error("Не правильно введено отчество"); return true; }; return false; });
            tests.Add(delegate () { if (NumberText.Text.Where(c => Char.IsDigit(c)).Count() < 10) { Error("Не правильно введен номер"); return true; }; return false; });
            tests.Add(delegate () { if (AdresText.Text.Length < 3) { Error("Не правильно введен адрес"); return true; }; return false; });
           tests.Add(delegate () { if (JobText.SelectedIndex < 0) { Error("Должность не выбрана"); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                string job = Jobs.Where(c => c[1] == JobText.Text).First()[0];
                string number = "";
                foreach (var n in NumberText.Text)
                {
                    if (char.IsDigit(n)) number += n;
                }
                if (Id != 0)
                    Controller.UpdateIn(SpecialSqlController.Tables.employeers, new List<string> { LnameText.Text, FnameText.Text, SnameText.Text, BornText.Text, number, AdresText.Text, job, DaysText.Text, NeedPassword.Checked ? Password.Text.Split(' ')[1] : null },Id.ToString());

                else
                    Controller.InsertIn(SpecialSqlController.Tables.employeers, new List<string> { LnameText.Text, FnameText.Text, SnameText.Text, BornText.Text, number, AdresText.Text, job, DaysText.Text, NeedPassword.Checked ? Password.Text.Split(' ')[1] : null });
                this.Close();
            }
        }

        private void EditJob_Click(object sender, EventArgs e)
        {
           OpenForm( new Edit(SpecialSqlController.Tables.job));
            GetJobs();
        }
    }
}
