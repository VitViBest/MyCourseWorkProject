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
    public partial class AddBrewForm : MainController
    {
        List<List<string>> Categories;
        List<string> ProductList;
        List<Dictionary<string,string>> ProductSelectedList;
        int Id;

        public AddBrewForm():base()
            {
         
                InitializeComponent();
            ButtonLoad();
                Id = 0;
                CanShop.Checked = true;
                ProductList = new List<string>();
                Product.DropDownStyle = ComboBoxStyle.DropDownList;
                ProductSelectedList = new List<Dictionary<string, string>> ();
                Category.DropDownStyle = ComboBoxStyle.DropDownList;
                Delete.Enabled = false;
                List<List<string>> pr = Controller.GetAllFrom(SpecialSqlController.Tables.products, "Enable=1");
                foreach(var p in pr)
            {
                ProductList.Add(p[1]);
            }
                Product.Items.AddRange(ProductList.ToArray());
                AddIng.Enabled = false;
                Actions();

            }

            public AddBrewForm(Dictionary<string, string> info) : base()
        {
                InitializeComponent();
            ButtonLoad();
            this.Text = Add.Text = "Изменить";
                Actions();
                Id = Convert.ToInt32(info["Id"]);
                BrewName.Text = info["Names"];
                Cost.Text = info["Cost"];
                Volume.Text = info["Volume"];
                Category.Text = Categories.Where(c => c[0].CompareTo(info["Category"]) == 0).First()[1];
                CanShop.Checked = Convert.ToInt32(info["CanShop"]) == 1;
                 ProductList = new List<string>();
            Product.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductSelectedList = new  List<Dictionary<string, string>>();
            Category.DropDownStyle = ComboBoxStyle.DropDownList;
            List<List<string>> pr = Controller.GetAllFrom(SpecialSqlController.Tables.products, "Enable=1");
            Delete.Enabled = false;
            string where = "";
            if (info.Keys.Contains("Volume"))
                where = "Brew is not null and Brew=" + info["Id"];
            else
                where = "Dish is not null and Dish=" + info["Id"];

            List<List<string>> ing = Controller.GetAllFrom(SpecialSqlController.Tables.ingredients, where);
            foreach (var p in pr)
            {
                if (ing.Where(x => Int32.Parse(x[3]) == Int32.Parse(p[0])).Count() == 0)
                    ProductList.Add(p[1]);
                else
                {
                    Dictionary<string, string> line = new Dictionary<string, string>();
                    line.Add("Id", p[0]);
                    line.Add("Names", p[1]);
                    line.Add("Count", ing.Where(x => Int32.Parse(x[3])== Int32.Parse(p[0])).First()[4]);
                ProductSelectedList.Add( line);
                }
            }
            PrintSeleceted();
            Product.Items.AddRange(ProductList.ToArray());
            AddIng.Enabled = false;
        }

            public override void  Actions()
            {
                Category.Items.Clear();
                Categories = Controller.GetAllFrom(SpecialSqlController.Tables.categorydrink, "Enable=1");
                foreach (var c in Categories)
                {
                    Category.Items.Add(c[1]);
                }
            }

        void PrintSeleceted()
        {
            Ingredients.Items.Clear();
            foreach (var s in ProductSelectedList)
            {
                Ingredients.Items.Add(s["Names"] + " - " + s["Count"]);
            }
        }

        private void Categoryes_Click(object sender, EventArgs e)
        {
           OpenForm( new Edit(SpecialSqlController.Tables.categorydrink));
            Actions();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (ProductSelectedList.Count == 0) { Error("Ингредиенты не добавлены"); return true; }; return false; });
            tests.Add(delegate () { if (BrewName.Text.Length < 3) { Error("Не правильно введено название"); return true; }; return false; });
            tests.Add(delegate () { if (Category.SelectedIndex < 0) { Error("Категория не выбрана "); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                if (Id == 0)
                {
                 if (   Controller.InsertInMenu(SpecialSqlController.Tables.drink, new List<string>{ BrewName.Text, Volume.Text, Cost.Value.ToString(), Categories.Where(x => x[1].CompareTo(Category.Text) == 0).First()[0], CanShop.Checked ? "1" : "0"}, ProductSelectedList))
                        this.Close();
                }
                else
                {
                 if (   Controller.UpdateMenu(SpecialSqlController.Tables.drink,Id.ToString(),new List<string> { BrewName.Text, Volume.Text, Cost.Value.ToString(), Categories.Where(x => x[1].CompareTo(Category.Text) == 0).First()[0], (CanShop.Checked ? "1" : "0") }, ProductSelectedList))
                        this.Close();
                }
              
            }
          
        }

        private void AddIng_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> line = new Dictionary<string, string>();
            List<string> p = Controller.TakeRow(SpecialSqlController.Tables.products, "`Names`='" + Product.Text+"'");
            line.Add("Id", p[0]);
            line.Add("Names", p[1]);
            line.Add("Count",Count.Value.ToString());
            ProductSelectedList.Add(line);
            Product.Items.RemoveAt(Product.SelectedIndex);
            Product.Text = "";
            AddIng.Enabled = false;
            PrintSeleceted();
            Count.Value = 1;
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Product.SelectedIndex>=0)
            AddIng.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            Product.Items.Add(ProductSelectedList[Ingredients.SelectedIndex]["Names"]);
            ProductSelectedList.RemoveAt(Ingredients.SelectedIndex);
            PrintSeleceted();
        }

        private void Ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ingredients.SelectedIndex>-1)
            Delete.Enabled = true;
        }
    }
}
