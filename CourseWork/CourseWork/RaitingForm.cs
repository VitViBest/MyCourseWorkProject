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
    public partial class RaitingForm : MainController
    {
        int Show;
        public RaitingForm()
        {
            InitializeComponent();
            Show = 1;
            Actions();
        }
        public override void MainAction()
        {
            DataList = new List<Dictionary<string, string>>();
            if (Show != 2)
            {
                GetData(SpecialSqlController.Tables.eat, delegate (Dictionary<string, string> data)
                {
                    Dictionary<string, string> res = new Dictionary<string, string>();
                    res.Add("Names", data["Names"] + " " + data["Portion"]);
                    res.Add("Type", "Блюдо");
                   int rat = Controller.GetAllFrom(SpecialSqlController.Tables.orders, " Dish=" + data["Id"]).Count() * 100 / Controller.GetAllFrom(SpecialSqlController.Tables.orders, "Id>0").Count();
                    res.Add("Raiting", rat.ToString());
                    return res;
                });
            }
            List<Dictionary<string, string>> times = new List<Dictionary<string, string>>();
            times.AddRange(DataList);
            if (Show != 3)
            {
                GetData(SpecialSqlController.Tables.drink, delegate (Dictionary<string, string> data)
                {
                    Dictionary<string, string> res = new Dictionary<string, string>();
                    res.Add("Names", data["Names"] + " " + data["Volume"]);
                    res.Add("Type", "Напиток");
                    int rat = Controller.GetAllFrom(SpecialSqlController.Tables.orders, " Brew=" + data["Id"]).Count()*100 / Controller.GetAllFrom(SpecialSqlController.Tables.orders, "Id>0").Count();
                    res.Add("Raiting", rat.ToString());
                    return res;
                });
                DataList.AddRange(times);
            }
        }
        public override void Actions()
        {
            MainAction();
            Sort("Raiting", -1);
            Print(ref Ratings);
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name[0] == 'A')
                Show = 1;
            else
                if ((sender as RadioButton).Name[0] == 'B')
                Show = 2;

            else
                Show = 3;
            Actions();
                    }
    }
}
