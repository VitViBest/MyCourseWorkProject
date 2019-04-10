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
    public partial class AddProductsForm : MainController
    {
        private List<Dictionary<string, string>> ListProducts;
        private List<Dictionary<string, string>> BuyList;
        public AddProductsForm():base()
        {
            InitializeComponent();
            ButtonLoad();
            BuyList = new List<Dictionary<string, string>>();
            OnesText.Items.Clear();
            OnesText.Items.AddRange(new string[] { "шт", "кг", "л" });
            OnesText.SelectedIndex = 1;
            OnesText.DropDownStyle = ComboBoxStyle.DropDownList;
            Actions();
            DeleteRow.Enabled = false;
        }

       public override void Actions()
        {
            MainAction();
            PrintNames();
        }

        public override void MainAction()
        {
            ListProducts = Controller.GetAllFromWithNames(SpecialSqlController.Tables.products, "Enable=1");
        }

        private void PrintNames()
        {
            NamesText.Items.Clear();
            NamesText.Text="";
            foreach( var p in ListProducts)
            {
                NamesText.Items.Add(p["Names"]);
            }
        }

        private void PrintRows()
        {
            Products.Rows.Clear();
            for (int j = 0; j < BuyList.Count; j++)
            {
                Products.Rows.Add();
                foreach (var l in BuyList[j])
                {
                        Products.Rows[Products.RowCount - 1].Cells[l.Key].Value = l.Value;
                }
            }
        }

        private void NamesText_SelectedIndexChanged(object sender, EventArgs e)
        {
                  if (NamesText.SelectedIndex >= 0)
            {
                Dictionary<string, string> line = ListProducts.Where(x => x["Names"].CompareTo(NamesText.Text) == 0).First();
                CountText.Value =  Convert.ToInt32(line["Count"])+1;
                OnesText.Text = line["Ones"];
            
            }
            else
            {
                CountText.Value = 1;
                OnesText.SelectedIndex = 1;
             
            }
        }


        private void AddRow_Click(object sender, EventArgs e)
        {
            if (NamesText.Text.Length < 3)
            {
                Error("Не правильное название");
                return;
            }
            Dictionary<string,string> line= new Dictionary<string, string>();
            line.Add("Names", NamesText.Text);
            line.Add("Count", CountText.Text);
            line.Add("Ones", OnesText.Text);
            line.Add("MinCount", "1");
            BuyList.Add(line);
            if(NamesText.SelectedIndex>-1)
            NamesText.Items.RemoveAt(NamesText.SelectedIndex);
            NamesText.Text = "";
            CountText.Value = 1;
            OnesText.SelectedIndex = 1;
      
            DeleteRow.Enabled = true;
            PrintRows();

        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
                NamesText.Items.Add(BuyList[Products.SelectedRows[0].Index]["Names"]);
                BuyList.RemoveAt(Products.SelectedRows[0].Index);
                PrintRows();
            DeleteRow.Enabled = false;
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (Controller.AddProducts(BuyList))
            {
                this.Close();
            }
        }

        private void Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Products.SelectedRows.Count > 0)
                DeleteRow.Enabled = true;
        }
    }
}
