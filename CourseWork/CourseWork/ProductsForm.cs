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
  
    public partial class ProductsForm : MainController
    {
        public ProductsForm() : base()
        {
            InitializeComponent();
            ButtonLoad();
            OnesList.Items.Clear();
            OnesList.Items.AddRange(new string[] { "шт", "кг", "л" });
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.products);
        }

        public override void Actions()
        {
            MainAction();
            CountFrom.Value=   CountFrom.Minimum = CountTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.products, "Count"));
            CountFrom.Maximum = CountTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.products, "Count"));
            CountTo.Value = CountTo.Maximum;
            OnesList.Items.Clear();
            OnesList.Items.AddRange( new List<string> { "шт", "кг", "л" }.ToArray());
                
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 3;
            Print(ref Products);
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {

                case 2:
                    Sort("Names", -1);
                    break;
                case 3:
                    Sort("Names", 1);
                    break;
                case 0:
                    Sort("Count", -1);
                    break;
                case 1:
                    Sort("Count", 1);
                    break;
            }
            Print(ref Products);
        }

        private void CountFrom_ValueChanged(object sender, EventArgs e)
        {
            CountTo.Minimum = CountFrom.Value;
            CountFrom.Maximum = CountTo.Value;
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !OnesList.CheckedItems.Contains(row["Ones"]) && OnesList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Count"]) >= Convert.ToInt32(CountFrom.Value) && Convert.ToInt32(row["Count"]) <= Convert.ToInt32(CountTo.Value)); });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 3;
            Print(ref Products);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Products, SpecialSqlController.Tables.products, delegate(string[] s)
            {
                return Controller.DeleteFrom(SpecialSqlController.Tables.ingredients, " Product=" + s[0]) && Controller.DeleteFrom(SpecialSqlController.Tables.products,int.Parse(s[0])) ;

            },false);
        }

        private void CountZero_Click(object sender, EventArgs e)
        {
            Hiding(Products, SpecialSqlController.Tables.products, delete: false, additional: delegate (string[] s) {return Controller.ProductCountZero(s[0]); }); ;  
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OpenForm( new AddProductsForm());
            Actions();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
