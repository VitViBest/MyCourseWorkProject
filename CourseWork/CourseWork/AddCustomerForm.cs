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
    public partial class AddCustomerForm : MainController
    {
        int Id;
        public AddCustomerForm() : base()
        {
            InitializeComponent();
            ButtonLoad();
            Id = 0;
        }
        public AddCustomerForm(Dictionary<string, string> info) : base()
        {
            InitializeComponent();
            ButtonLoad();
            this.Text = Add.Text = "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            LnameText.Text = info["Lname"];
            FnameText.Text = info["Fname"];
            AdresText.Text = info["Adres"];
            ProcentText.Value =Convert.ToInt32( info["Procent"]);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (LnameText.Text.Length < 1) { Error("Не правильно введена фамилия"); return true; }; return false; });
            tests.Add(delegate () { if (FnameText.Text.Length < 1) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (AdresText.Text.Length < 1) { Error("Не правильно введен адрес"); return true; }; return false; });
            if (CheckTest(tests.ToArray())){
                if (Id == 0)
                    Controller.InsertIn(SpecialSqlController.Tables.customers,new List<string> { FnameText.Text, LnameText.Text, AdresText.Text, ProcentText.Value.ToString() });
                else
                {
                   Controller.UpdateIn(SpecialSqlController.Tables.customers, new List<string> { FnameText.Text, LnameText.Text, AdresText.Text, ProcentText.Value.ToString() }, Id.ToString());
                }
                this.Close();
            }
         
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
