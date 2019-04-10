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
    public partial class OrderDishForm : MainController
    {
        public OrderDishForm() : base()
        {
            InitializeComponent();
            ButtonLoad();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.eat, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    data[g]["Category"] = Controller.TakeRowById(SpecialSqlController.Tables.categoryeat, Convert.ToInt32(data[g]["Category"]))[1];
                    data[g]["CanShop"] = int.Parse(data[g]["CanShop"]) == 1 ? "Да" : "Нет";
                    List<Dictionary<string, string>> ing = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, "Dish is not null and Dish=" + data[g]["Id"]);
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
            PortionList.Items.Clear();
            PortionList.Items.AddRange(new string[] { "Маленькая", "Стандарт", "Большая" });
            CategoryList.Items.Clear();
            List<List<string>> cat = Controller.GetAllFrom(SpecialSqlController.Tables.categoryeat, "Enable=1");
            foreach (var c in cat)
                CategoryList.Items.Add(c[1]);
            IngredientsFiltr.Items.Clear();
            List <List<string>> prod = Controller.GetAllFrom(SpecialSqlController.Tables.products);
            foreach (var p in prod)
                IngredientsFiltr.Items.Add(p[1]);
          
           CostFrom.Value= CostFrom.Minimum = CostTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.eat,"Cost"));
            CostFrom.Maximum = CostTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.eat,"Cost"));
            CostTo.Value = CostTo.Maximum;
          MassFrom.Value=  MassFrom.Minimum =MassTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.eat, "Mass"));
            MassFrom.Maximum = MassTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.eat, "Mass"));
            MassTo.Value = MassTo.Maximum;
            MainAction();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 5;
            Print(ref Dishes);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenForm( new AddDishes());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Kaloryes", -1);
                    break;
                case 1:
                    Sort("Kaloryes", 1);
                    break;
                case 2:
                    Sort("Mass", -1);
                    break;
                case 3:
                    Sort("Mass", 1);
                    break;
                case 4:
                    Sort("Names", -1);
                    break;
                case 5:
                    Sort("Names", 1);
                    break;
                case 6:
                    Sort("Cost", -1);
                    break;
                case 7:
                    Sort("Cost", 1);
                    break;
            }
            Print(ref Dishes);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Dishes, SpecialSqlController.Tables.eat);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Dishes))
            {
                string id = GetId(Dishes);
                OpenForm(new AddDishes(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, Convert.ToInt32(id))));
                Actions();
            }
        }

        private void MassFrom_ValueChanged(object sender, EventArgs e)
        {
           MassTo.Minimum = MassFrom.Value;
           MassFrom.Maximum = MassTo.Value;

        }

        private void CostFrom_ValueChanged(object sender, EventArgs e)
        {
            CostTo.Minimum = CostFrom.Value;
            CostFrom.Maximum = CostTo.Value;
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !PortionList.CheckedItems.Contains(row["Portion"]) && PortionList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !CategoryList.CheckedItems.Contains(row["Category"]) && CategoryList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Cost"]) >= Convert.ToInt32(CostFrom.Value) && Convert.ToInt32(row["Cost"]) <= Convert.ToInt32(CostTo.Value)); });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Mass"]) >= Convert.ToInt32(MassFrom.Value) && Convert.ToInt32(row["Mass"]) <= Convert.ToInt32(MassTo.Value)); });
            tags.Add(delegate (Dictionary<string, string> row) { return row["CanShop"].CompareTo("Да") != 0 && OnlyCan.Checked; });
            tags.Add(delegate (Dictionary<string, string> row) {

                for (int i = 0; i < IngredientsFiltr.CheckedItems.Count; i++)
                    if (!row["Ingredients"].ToLower().Contains(IngredientsFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                    return false;
            });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 5;
            Print(ref Dishes);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
