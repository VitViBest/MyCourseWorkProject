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
    public partial class DateFrom : MainController
    {
  
        public DateFrom():base()
        {
            InitializeComponent();
            ButtonLoad();
            Actions();
            
        }
        public override void MainAction() {
            GetData(SpecialSqlController.Tables.checks, delegate (Dictionary<string, string> data)
         {
             Dictionary<string, string> res = new Dictionary<string, string>();
             if (Convert.ToDateTime(data["DateOrder"]).Date >= DateWith.Value.Date && Convert.ToDateTime(data["DateOrder"]).Date <= DateTo.Value.Date)
             {
                 string id = data["Id"];
                 List<Dictionary<string, string>> dishes = Controller.GetAllFromWithNames(SpecialSqlController.Tables.orders, " `Dish` is not null and `Check`='" + id + "'");
                 foreach (var d in dishes)
                 {
                     if (DataList.Count > 0 && DataList.Count(x => x.ContainsKey("Id") && x["Id"] == d["Dish"]) > 0)
                     {
                         Dictionary<string, string> s = DataList.First(x => x.ContainsKey("Id") && x["Id"] == d["Dish"]);
                         DataList[DataList.IndexOf(s)]["Count"] = (int.Parse(s["Count"]) + 1).ToString();
                         s = DataList.First(x => x.ContainsKey("Id") && x["Id"] == d["Dish"]);
                         DataList[DataList.IndexOf(s)]["Summ"] = (Convert.ToInt32(s["Summ"]) / (Convert.ToInt32(s["Count"])-1)* Convert.ToInt32(s["Count"])).ToString();
                     }
                     else
                     {
                         res = new Dictionary<string, string>();
                         var dish = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, int.Parse(d["Dish"]));
                         res.Add("Id", dish["Id"]);
                         res.Add("Names", dish["Names"] + " " + dish["Portion"]);
                         res.Add("Type", "Блюдо");
                         res.Add("Category", Controller.TakeRowById(SpecialSqlController.Tables.categoryeat, int.Parse(dish["Category"]))[1]);
                         res.Add("Count", "1");
                         res.Add("Summ", (Convert.ToInt32(res["Count"] )* Convert.ToInt32(dish["Cost"])).ToString());
                         DataList.Add(res);

                     }
                 }
                 res = new Dictionary<string, string>();
             }
             return res;
         });
            List<Dictionary<string, string>> times = new List<Dictionary<string, string>>();
            times.AddRange(DataList);
            DataList.Clear();
            GetData(SpecialSqlController.Tables.checks, delegate (Dictionary<string, string> data)
            {

                Dictionary<string, string> res = new Dictionary<string, string>();
                if (Convert.ToDateTime(data["DateOrder"]).Date >= DateWith.Value.Date && Convert.ToDateTime(data["DateOrder"]).Date <= DateTo.Value.Date)

                {
                    string id = data["Id"];
                    List<Dictionary<string, string>> brews = Controller.GetAllFromWithNames(SpecialSqlController.Tables.orders, " `Brew` is not null and `Check`='" + id + "'");
                    foreach (var b in brews)
                    {
                        if (DataList.Count > 0 && DataList.Count(x => x.ContainsKey("Id") && x["Id"] == b["Brew"]) > 0)
                        {
                            Dictionary<string, string> s = DataList.First(x => x.ContainsKey("Id") && x["Id"] == b["Brew"]);
                            DataList[DataList.IndexOf(s)]["Count"] = (int.Parse(s["Count"]) + 1).ToString();
                            s = DataList.First(x => x.ContainsKey("Id") && x["Id"] == b["Dish"]);
                            DataList[DataList.IndexOf(s)]["Summ"] = (Convert.ToInt32(s["Summ"]) / (Convert.ToInt32(s["Count"]) - 1) * Convert.ToInt32(s["Count"])).ToString();

                        }
                        else
                        {
                            res = new Dictionary<string, string>();
                            var brew = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, int.Parse(b["Brew"]));
                            res.Add("Id", brew["Id"]);
                            res.Add("Names", brew["Names"] + " " + brew["Volume"]);
                            res.Add("Type", "Напиток");
                            res.Add("Category", Controller.TakeRowById(SpecialSqlController.Tables.categorydrink, int.Parse(brew["Category"]))[1]);
                            res.Add("Count", "1");
                            res.Add("Summ", (Convert.ToInt32(res["Count"]) * Convert.ToInt32(brew["Cost"])).ToString());
                            DataList.Add(res);

                        }
                    }
                    res = new Dictionary<string, string>();
                }
                return res;
            });
            DataList.AddRange(times);


        }

        void AllCheck()
        {
            int m = 0, c = 0;
            for (int i = 0; i < Statist.RowCount; i++)
            {
                c+= Convert.ToInt32(Statist[4,i].Value);
                m+= Convert.ToInt32(Statist[5,i].Value);
            }
            AllMoney.Text = m.ToString();
            AllCount.Text = c.ToString();
        }

        public override void Actions()
        {
            DateWith.Value = DateTo.MinDate = DateWith.MinDate = Convert.ToDateTime(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.checks, Controller.Minimum(SpecialSqlController.Tables.checks, "Id"))["DateOrder"]);
            DateTo.Value = DateWith.MaxDate = DateTo.MaxDate = DateTime.Now;
            MainAction();
            TypeFiltr.Items.Clear();
            TypeFiltr.Items.Add("Напиток");
            TypeFiltr.Items.Add("Блюдо");
            List<List<string>> cat = Controller.GetAllFrom(SpecialSqlController.Tables.categoryeat);
            CategoryList.Items.Clear();
            foreach (var c in cat)
                CategoryList.Items.Add(c[1]);
            cat = Controller.GetAllFrom(SpecialSqlController.Tables.categorydrink);
            foreach (var c in cat)
                CategoryList.Items.Add(c[1]);
            Print(ref Statist);
            AllCheck();
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !CategoryList.CheckedItems.Contains(row["Category"]) && CategoryList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !TypeFiltr.CheckedItems.Contains(row["Type"]) && TypeFiltr.CheckedItems.Count > 0; });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Statist);
            AllCheck();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 2: Sort("Names", -1); break;
                case 3: Sort("Names", 1); break;
                case 0: Sort("Count", -1); break;
                case 1: Sort("Count", 1); break;

            }


            Print(ref Statist);
            AllCheck();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void DateWith_ValueChanged(object sender, EventArgs e)
        {
            DateTo.MinDate = DateWith.Value;
            DateWith.MaxDate = DateTo.Value;
        }
    }
}
