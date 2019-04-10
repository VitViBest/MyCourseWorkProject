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

    public class MainController : Form
    {
        protected SpecialSqlController Controller;

        protected List<Dictionary<string, string>> DataList;

        public MainController()
        {
            Controller = new SpecialSqlController();
            DataList = new List<Dictionary<string, string>>();
        }

        protected void OpenForm(Form form, bool show = true)
        {
            this.Hide();
            form.ShowDialog();
            if (show) this.Show();
        }

        protected void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        protected delegate void Additional(ref List<Dictionary<string, string>> data);

        protected delegate bool FiltrTag(Dictionary<string, string> row);

        protected delegate bool TestValid();

        protected delegate bool AdditionalDelete(string[] s);

        protected delegate Dictionary<string, string> CreateRow(Dictionary<string, string> row);

        public virtual void MainAction()
        {

        }

        public virtual void Actions() { }

        protected virtual void Print(ref DataGridView view)
        {
            view.Rows.Clear();
            for (int j = 0; j < DataList.Count; j++)
            {
                view.Rows.Add();
                foreach (var l in DataList[j])
                {
                    if (l.Key != "Enable"&&l.Key!="CanTake")
                        view.Rows[view.RowCount - 1].Cells[l.Key].Value = l.Value;
                }
            }
        }

        protected virtual void Sort(string parametr, int flag)
        {
            if (DataList == null || DataList.Count == 0)
                return;
            bool again = false;
            int n;
            bool isNumber = Int32.TryParse(DataList.First()[parametr], out n);
            {
                try
                {
                    for (int i = 0; i < DataList.Count; i++)
                        for (int j = 0; j < DataList.Count - 1; j++)
                        {
                            bool test;
                            if (isNumber)
                                test = ((Convert.ToInt32(DataList[j][parametr]) > Convert.ToInt32(DataList[j + 1][parametr]) && flag == 1) || (Convert.ToInt32(DataList[j][parametr]) < Convert.ToInt32(DataList[j + 1][parametr]) && flag == -1));
                            else
                                test = (DataList[j][parametr].CompareTo(DataList[j + 1][parametr]) == flag);
                            if (test)
                            {
                                Dictionary<string, string> t = DataList[j];
                                DataList[j] = DataList[j + 1];
                                DataList[j + 1] = t;
                            }
                        }
                }
                catch
                {
                    if (isNumber)
                        isNumber = false;
                    else
                        return;
                    again = true;
                }
            } while (again) ;

        }

        protected virtual void CancelClick(object sender, EventArgs e)
        {
            Actions();
        }

        protected virtual void Filtres(FiltrTag[] filtrs)
        {
            MainAction();
            for (int i = 0; i < DataList.Count; i++)
            {
                bool test = false;
                for (int j = 0; j < filtrs.Count(); j++)
                    test = test || filtrs[j](DataList[i]);
                if (test)
                {
                    DataList.RemoveAt(i);
                    i--;
                }

            }
            if (DataList.Count == 0)
                Error("Данных с такими критериями нет");
        }

        protected virtual bool CheckTest(TestValid[] tests)
        {
            bool result = false;
            foreach (var t in tests) {
                result = result || t();
                if (result) break;
            }
            return !result;
        }

        protected virtual void Error (string text){
            MessageBox.Show(text);
        }

        protected virtual void GetData(SpecialSqlController.Tables table,Additional additional=null)
        {
            DataList = Controller.GetAllFromWithNames(table, "Enable=1");
            if (additional != null)
            {
                 additional(ref DataList);
            }
        }

        protected void GetData(SpecialSqlController.Tables table,CreateRow create)
        {
            DataList.Clear();
            List<Dictionary<string, string>> dataList = Controller.GetAllFromWithNames(table, "Enable=1");
            foreach (var d in dataList)
            {
                Dictionary<string, string> r = create(d);
                if (r.Count>0)
                DataList.Add(r);
            }
        }

        protected virtual bool RowTest(DataGridView view,bool withMessage=true)
        {
            if (view.SelectedRows.Count > 0)
                return true;
            else
            {
                if (withMessage)
               Error("Строка не выбрана");
                return false;
            }
        }

        protected virtual void Hiding(DataGridView view, SpecialSqlController.Tables table,AdditionalDelete additional=null,bool delete=true,string show="")
        {
            if (RowTest(view))
            {
                string id =GetId(view);
                DialogResult result = MessageBox.Show((show.Length==0? "Поддтвердите действие удаления " + (view[1, view.SelectedRows[0].Index] as DataGridViewCell).Value.ToString():show), "Удалить?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    bool done = false;
                    if (delete)
                        done = (additional != null ? additional(new[] { id }) : true) && Controller.DeleteToHistory(table, Convert.ToInt32(id));
                    else
                        done = (additional != null ? additional(new[] { id }) : false);
                    if (done)
                        Actions();
                    else
                       Error("Ошибка удаления");
                }
            }
        }

        protected virtual string GetId(DataGridView view)
        {
            return (view[0, view.SelectedRows[0].Index] as DataGridViewCell).Value.ToString();
        }
    }
}
