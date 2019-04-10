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
    public partial class OrderBrewForm : MainController
    {
        public OrderBrewForm() : base()
        {
            InitializeComponent();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.drink, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    data[g]["Category"] = Controller.TakeRowById(SpecialSqlController.Tables.categorydrink, Convert.ToInt32(data[g]["Category"]))[1];
                    data[g]["CanShop"] = int.Parse(data[g]["CanShop"]) == 1 ? "Да" : "Нет";
                    List<Dictionary<string, string>> ing = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, "Brew is not null and Brew=" + data[g]["Id"]);
                    string result = "";
                    foreach (var i in ing)
                    {
                        result += Controller.TakeRow(SpecialSqlController.Tables.products, "Id=" + i["Product"])[1] + " - " + i["Count"] + Controller.TakeRowWithNames(SpecialSqlController.Tables.products, "Id=" + i["Product"])["Ones"] + "   ";
                    }
                    data[g].Add("Ingredients", result);
                }
            });
        }

        public override void Actions()
        {
            OnlyCan.Checked = false;
            CategoryList.Items.Clear();
            List<List<string>> cat = Controller.GetAllFrom(SpecialSqlController.Tables.categorydrink, "Enable=1");
            foreach (var c in cat)
                CategoryList.Items.Add(c[1]);
            IngredientsFiltr.Items.Clear();
            List<List<string>> prod = Controller.GetAllFrom(SpecialSqlController.Tables.products);
            foreach (var p in prod)
                IngredientsFiltr.Items.Add(p[1]);
            MainAction();
      CostFrom.Value=CostFrom.Minimum = CostTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.drink, "Cost"));
         CostTo.Value=   CostFrom.Maximum = CostTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.drink, "Cost"));
            CostTo.Value = CostTo.Maximum;
          VolumeFrom.Value=  VolumeFrom.Minimum = VolumeTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.drink, "Volume"));
         VolumeTo.Value=   VolumeFrom.Maximum = VolumeTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.drink, "Volume"));
            VolumeTo.Value = VolumeTo.Maximum;
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
     
            Print(ref Brews);
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {

                case 0:
                    Sort("Names", -1);
                    break;
                case 1:
                    Sort("Names", 1);
                    break;
                case 2:
                    Sort("Volume", -1);
                    break;
                case 3:
                    Sort("Volume", 1);
                    break;
                case 4:
                    Sort("Cost", -1);
                    break;
                case 5:
                    Sort("Cost", 1);
                    break;
            }
            Print(ref Brews);
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !CategoryList.CheckedItems.Contains(row["Category"]) && CategoryList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Cost"]) >= Convert.ToInt32(CostFrom.Value) && Convert.ToInt32(row["Cost"]) <= Convert.ToInt32(CostTo.Value)); });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Volume"]) >= Convert.ToInt32(VolumeFrom.Value) && Convert.ToInt32(row["Volume"]) <= Convert.ToInt32(VolumeTo.Value)); });
            tags.Add(delegate (Dictionary<string, string> row) { return row["CanShop"].CompareTo("Да") !=0 && OnlyCan.Checked; });
            tags.Add(delegate (Dictionary<string, string> row) {
                for (int i = 0; i < IngredientsFiltr.CheckedItems.Count; i++)
                    if (!row["Ingredients"].ToLower().Contains(IngredientsFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                return false;
            });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Brews);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Brews, SpecialSqlController.Tables.drink);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenForm( new AddBrewForm());
            Actions();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Brews))
            {
                string id = GetId(Brews);
                OpenForm( new AddBrewForm(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, Convert.ToInt32(id))));
                Actions();
            }
        }

        private void VolumeFrom_ValueChanged(object sender, EventArgs e)
        {
            VolumeTo.Minimum = VolumeFrom.Value;
            VolumeFrom.Maximum = VolumeTo.Value;
        }

        private void CostFrom_ValueChanged(object sender, EventArgs e)
        {
            CostTo.Minimum = CostFrom.Value;
            CostFrom.Maximum = CostTo.Value;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
