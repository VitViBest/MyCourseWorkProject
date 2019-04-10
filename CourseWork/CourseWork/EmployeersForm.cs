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
    public partial class EmployeersForm : MainController
    {
        int UserId;

        public EmployeersForm() : base() => InitializeComponent();

        public EmployeersForm(int id) : base()
        {
            InitializeComponent();
            UserId = id;
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.employeers, delegate (Dictionary<string, string> row)
            {
                Dictionary<string, string> newRow = new Dictionary<string, string>();
                newRow.Add("Id", row["Id"]);
                newRow.Add("FLName", row["Lname"] + " " + row["Fname"]);
                newRow.Add("Job", Controller.TakeRowById(SpecialSqlController.Tables.job, Convert.ToInt32(row["Job"]))[1]);
                newRow.Add("Days", row["Days"]);
                newRow.Add("Number", row["Number"]);
                return newRow;
            });
        }

        public override void Actions()
        {
            MainAction();
            FiltrDays.Items.Clear();
            FiltrDays.Items.AddRange( new string[] { "Четные","Нечетные"});
            Job_Filtr.Items.Clear();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            List<List<string>> jobs = Controller.GetAllFrom(SpecialSqlController.Tables.job);
            foreach (var j in jobs)
            {
                Job_Filtr.Items.Add(j[1]);
            }
            Print(ref Employeers);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenForm (new AddEmployerForm());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 0:Sort("Job", -1);
                    break;
                case 1:
                    Sort("Job", 1);
                    break;
                case 2:
                    Sort("FLName", -1);
                    break;
                case 3:
                    Sort("FLName", 1);
                    break;
            }
            Print(ref Employeers);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !Job_Filtr.CheckedItems.Contains(row["Job"]) && Job_Filtr.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !FiltrDays.CheckedItems.Contains(row["Days"]) && FiltrDays.CheckedItems.Count > 0; });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            Print(ref Employeers);
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (RowTest(Employeers))
            {
                string id =GetId(Employeers);
                OpenForm( new AddEmployerForm(Controller.GetUserInfoById(Convert.ToInt32(id))));
                Actions();
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (RowTest(Employeers))
            {
                string id = GetId(Employeers);
                OpenForm( new ProfileForm(Convert.ToInt32(id)));
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(GetId(Employeers)) != UserId)
                Hiding(Employeers, SpecialSqlController.Tables.employeers);
            else
                MessageBox.Show("Вы не можете удалить себя");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
