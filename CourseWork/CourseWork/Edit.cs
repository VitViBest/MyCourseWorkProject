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
    public partial class Edit : MainController
    {
        SpecialSqlController.Tables Table;
        List<string> NonDelete = new List<string> { "Официант", "Повар", "Администратор" };

        public Edit() : base() => InitializeComponent();
        

        public Edit(SpecialSqlController.Tables table) : base()
        {
            InitializeComponent();
            Table = table;
            Actions();
        }

        public override void MainAction()
        {
            GetData(Table);
        }

        public override void Actions()
        {
            MainAction();
            ChangeText.Text = "";
            Print(ref Rows);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Table == SpecialSqlController.Tables.job)
            {
                if (RowTest(Rows) && NonDelete.Contains(Rows[1, Rows.SelectedRows[0].Index].Value.ToString()))
                {
                    Error("Невозможно удалить фундаментальные должности");
                    return;
                }
            }
            Hiding(Rows, Table);       
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Table == SpecialSqlController.Tables.job)
            {
                if (RowTest(Rows) && AddText.Text.ToLower().Replace(" ","").CompareTo("admin")==0)
                {
                    Error("Невозможно добавить такую должность");
                    return;
                }
            }
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate(){ if (AddText.Text.Length < 5) { Error("Не правильное название"); return true; } return false; });
            if (CheckTest(tests.ToArray()))
            if (Controller.BackFromHistory(Table, AddText.Text))
            {
                Actions();
                AddText.Clear();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Rows))
            {
                if (Table == SpecialSqlController.Tables.job)
                {
                    if ( RowTest(Rows)&&NonDelete.Contains( Rows[1,Rows.SelectedRows[0].Index].Value.ToString()))
                    {
                        Error("Невозможно изменить фундаментальные должности");
                        return;
                    }
                }
                string id = GetId(Rows);
                List<TestValid> tests = new List<TestValid>();
                tests.Add(delegate () { if (ChangeText.Text.Length < 5) { Error("Не правильное название"); return true; } return false; });
                if (CheckTest(tests.ToArray()))
                    if (Controller.BackFromHistory(Table, id, ChangeText.Text))
                {
                    Actions();
                    ChangeText.Clear();
                }
            }

        }

        private void Rows_Click(object sender, EventArgs e)
        {
            if (RowTest(Rows,false))
            {
                ChangeText.Text = Rows[1, Rows.SelectedRows[0].Index].Value.ToString();
            }
            else
            {
                ChangeText.Text = "";
            }
        }
    }
}
