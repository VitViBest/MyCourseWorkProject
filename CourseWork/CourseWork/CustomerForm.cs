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
    public partial class CustomerForm : MainController
    {
        public CustomerForm()
        {
            InitializeComponent();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.customers, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    data[j]["Fname"] += " " + data[j]["Lname"];
                    data[j].Remove("Lname");
                }

            });
        }

        public override void Actions()
        {
          PercentFrom.Value=  PercentFrom.Minimum = PercentTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.customers, "Procent"));
          PercentTo.Value=  PercentFrom.Maximum = PercentTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.customers, "Procent"));
            PercentTo.Value = PercentTo.Maximum;
            MainAction();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Customers);
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Fname", -1);
                    break;
                case 1:
                    Sort("Fname", 1);
                    break;
                case 2:
                    Sort("Procent", -1);
                    break;
                case 3:
                    Sort("Procent", 1);
                    break;
            }
            Print(ref Customers);
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Procent"]) >= Convert.ToInt32(PercentFrom.Value) && Convert.ToInt32(row["Procent"]) <= Convert.ToInt32(PercentTo.Value)); });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Customers);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
                Hiding(Customers,SpecialSqlController.Tables.customers);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenForm(new AddCustomerForm());
            Actions();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Customers))
            {
                string id = GetId(Customers);
                OpenForm(new AddCustomerForm(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customers, Convert.ToInt32(id))));
                Actions();
            }
        }

        private void PercentFrom_ValueChanged(object sender, EventArgs e)
        {
            PercentTo.Minimum = PercentFrom.Value;
            PercentFrom.Maximum = PercentTo.Value;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
