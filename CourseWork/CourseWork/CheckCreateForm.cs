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
    public partial class CheckCreateForm : MainController
    {
        List<Dictionary<string, string>> Tables;
        List<Dictionary<string, string>> Employeers;
        List<Dictionary<string, string>> Eat;
        List<Dictionary<string, string>> Drink;
        List<Dictionary<string, string>> BuyEat;
        List<Dictionary<string, string>> BuyDrink;
        Dictionary<string, string> CustomerCard;
        int All = 0;
        int Minus = 0;
        int UserId;
        string RowId;
        bool OnLoad;
        public CheckCreateForm():base() { }
        public CheckCreateForm(int id)
        {
            InitializeComponent();
            UserId = id;
            RowId = null;
            Tables = Controller.GetAllFromWithNames(SpecialSqlController.Tables.tables,"Enable=1 and CanTake=1");
            //string days = "";
            //if (DateTime.Now.Day % 2 == 1)
            //    days = "Нечетные";
            //else
            //    days = "Четные";
            Statys.Items.Clear();
            Statys.Items.AddRange(new string[] { "Принят"/*, "Готовится", "Доставляется", "Выдан","Оплачен"*/});
            CustomerCard = new Dictionary<string, string>();
            Employeers = Controller.GetAllFromWithNames(SpecialSqlController.Tables.employeers," Job=14 or Job=1");
            Tovar.DropDownStyle = Employeer.DropDownStyle = Table.DropDownStyle = Statys.DropDownStyle = ComboBoxStyle.DropDownList;
            Employeer.Enabled = false;
            TimeOrder.MinDate = DateTime.Now;
            TimeOrder.Enabled = false;
            DateGive.MinDate = DateTime.Now.AddMinutes(30);
            Eat = Controller.GetAllFromWithNames(SpecialSqlController.Tables.eat, "Enable=1 and CanShop=1");
            Drink=Controller.GetAllFromWithNames(SpecialSqlController.Tables.drink, "Enable=1 and CanShop=1");
            foreach (var t in Tables)
                Table.Items.Add(t["Names"]);


            foreach (var e in Employeers)
                Employeer.Items.Add(e["Lname"] + " " + e["Fname"][0] + ".");
            Actions();
            BuyDrink = new List<Dictionary<string, string>>();
            BuyEat = new List<Dictionary<string, string>>();
                Employeer.SelectedIndex = Employeers.IndexOf(Employeers.Where(x => x["Id"].CompareTo(UserId.ToString()) == 0).First());
            Statys.SelectedIndex = 0;
            OnLoad = true;
        }
        public CheckCreateForm(string RowId)
        {
            InitializeComponent();
            Tovar.DropDownStyle = Employeer.DropDownStyle = Table.DropDownStyle = Statys.DropDownStyle = ComboBoxStyle.DropDownList;
            Create.Text = "Изменить";
            Dictionary<string, string> r = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.checks, int.Parse(RowId));
            this.RowId = RowId;
            Tables = new List<Dictionary<string, string>>();
            if (r.ContainsKey("Table") && r["Table"].Length > 0)
            {
                //Controller.Request("UPDATE `pizzeria`.`tables` SET `CanTake` = '1' WHERE `Id`=" + r["Table"]);
                Tables = Controller.GetAllFromWithNames(SpecialSqlController.Tables.tables, " Id="+ r["Table"]);
                foreach (var t in Tables)
                    Table.Items.Add(t["Names"]);
                Table.SelectedIndex = 0;
                AdresText.Enabled = false;
            }
            Statys.Items.Clear();
            Statys.Items.AddRange(new string[] { "Принят", "Готовится", "Доставляется", "Выдан", "Оплачен","Отменен" });
            Statys.Text = r["Status"];
            if (Statys.Text.CompareTo("Отменен") != 0)
                Statys.Items.RemoveAt(Statys.Items.Count - 1);
            for (int i = 0; i < Statys.Items.IndexOf(r["Status"]); i++){
                Statys.Items.RemoveAt(i);
                i--;
            }
            Customer.Text = r["Customer"];
            if (r.ContainsKey("Adres")&&r["Adres"].Length>0)
            {
                AdresText.Text = r["Adres"]; 
            }
            Table.Enabled = false;
            Employeers = new List<Dictionary<string, string>>();
            Employeers.Add(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers, int.Parse(r["Employeer"])));
            foreach (var e in Employeers)
                Employeer.Items.Add(e["Lname"] + " " + e["Fname"][0] + ".");
            Employeer.SelectedIndex = 0;
            Employeer.Enabled = false;
             CustomerCard = new Dictionary<string, string>();
            if (r.ContainsKey("CardKey") && r["CardKey"].Length>0)
            {
                Card.Text = r["CardKey"];
                CustomerCard = Controller.TakeRowWithNames(SpecialSqlController.Tables.customers, $"Id={Int32.Parse(Card.Text)} and Enable=1");
                Minus = Int32.Parse(CustomerCard["Procent"]);
            }
            TimeOrder.Text = r["DateOrder"];
            TimeOrder.Enabled = false;
            DateGive.MinDate =Convert.ToDateTime(r["DateGive"]);
            DateGive.Text = r["DateGive"];

          
            Eat = Controller.GetAllFromWithNames(SpecialSqlController.Tables.eat, "Enable=1 and CanShop=1");
            Drink = Controller.GetAllFromWithNames(SpecialSqlController.Tables.drink, "Enable=1 and CanShop=1");
            Actions();
            BuyDrink = new List<Dictionary<string, string>>();
            BuyDrink = Controller.QueryWithNames( $" select `Brew` as Id,`Count` from `pizzeria`.`orders` where( `Check`= '{RowId}' and Brew is not null) ");

            BuyEat = new List<Dictionary<string, string>>();
            BuyEat = Controller.QueryWithNames($" select `Dish` as Id,`Count` from `pizzeria`.`orders` where( `Check`='{RowId}' and Dish is not null) ");

            foreach (var b in BuyEat) {
                int id = Eat.IndexOf(Eat.Where(x=>int.Parse(x["Id"])== int.Parse(b["Id"])).First());
                Dishes.Rows.Add(b["Id"], "Eat", Eat[id]["Names"] + " " + Eat[id]["Portion"], b["Count"], Eat[id]["Cost"]);
                All += Int32.Parse(Dishes[4, Dishes.RowCount - 1].Value.ToString()) * Int32.Parse(Dishes[3, Dishes.RowCount - 1].Value.ToString());
                AllMoney.Text = ((int)(All - All * Minus / 100)).ToString();
            }

            foreach(var b in BuyDrink)
            {
                int id = Drink.IndexOf(Drink.Where(x => int.Parse(x["Id"]) == int.Parse(b["Id"])).First());
                Dishes.Rows.Add(Drink[id]["Id"], "Drink", Drink[id]["Names"] + " " + Drink[id]["Volume"] + "мл.", b["Count"], Drink[id]["Cost"]);
                All += Int32.Parse(Dishes[4, Dishes.RowCount - 1].Value.ToString()) * Int32.Parse(Dishes[3, Dishes.RowCount - 1].Value.ToString());
                AllMoney.Text = ((int)(All - All * Minus / 100)).ToString();
            }
            if (r["Status"] != "Принят")
            {
                Customer.Enabled = false;
                Table.Enabled = false;
                Employeer.Enabled = false;
                TimeOrder.Enabled = false;
                DateGive.Enabled = false;
                Adres.Enabled = false;
                Card.Enabled = false;
                Dishes.Enabled = false;
                Delete.Enabled = false;
                Tovar.Enabled = false;
                CountTov.Enabled = false;
                Add.Enabled = false;
                AllMoney.Enabled = false;
                Dishes.Enabled = false;
                AdresText.Enabled = false;
                if(r["Status"]=="Отменен" || r["Status"]=="Оплачен")
                {
                    Create.Enabled = false;
                    Statys.Enabled = false;
                }
            }
            OnLoad = true;
        }
        public override  void  Actions() {

            foreach (var e in Eat)
            {
                Tovar.Items.Add(e["Names"] + " " + e["Portion"] + " " + e["Cost"] + "грн.");
            }
            foreach (var d in Drink)
            {
                Tovar.Items.Add(d["Names"] + " " + d["Volume"] + "мл. " + d["Cost"] + "грн.");
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Clear();
            (sender as MaskedTextBox).SelectionStart = 0;
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Tovar.SelectedIndex > -1)
            {
                int id = Tovar.SelectedIndex;
                if (id < Eat.Count)
                {
                    Dictionary<string, string> d = new Dictionary<string, string>();
                    if (BuyEat.Where(x => x["Id"].CompareTo(Eat[id]["Id"]) == 0).Count() == 0)
                    {

                    
                        d.Add("Id", Eat[id]["Id"]);
                        d.Add("Count", CountTov.Value.ToString());


                    }
                    else
                    {
                        int coun = int.Parse(BuyEat.Where(x => x["Id"].CompareTo(Eat[id]["Id"]) == 0).First()["Count"]);
                        BuyEat.Remove(BuyEat.Where(x => x["Id"].CompareTo(Eat[id]["Id"]) == 0).First());
                        for (int i = 0; i < Dishes.RowCount; i++)

                            if (Dishes[0, i].Value.ToString().CompareTo(Eat[id]["Id"]) == 0 && Dishes[1, i].Value.ToString().CompareTo("Eat") == 0)
                            {
                                All -= Int32.Parse(Dishes[4, i].Value.ToString()) * Int32.Parse(Dishes[3, i].Value.ToString());
                                Dishes.Rows.RemoveAt(i);
                                List<Dictionary<string, string>> igredss = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, "Dish=" + Eat[id]["Id"]);

                                foreach (var j in igredss)
                                    Controller.Request($"update products set `count`=`count`+{int.Parse(j["Count"]) * coun} where (Id={j["Product"]})");

                                break;
                            }

                        d.Add("Id", Eat[id]["Id"]);
                        d.Add("Count", CountTov.Value.ToString());

                    }

                    List<Dictionary<string, string>> igreds = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, " Dish=" + Eat[id]["Id"]);
                    int c = (int)CountTov.Value;
                    bool test = true;
                    do
                    {
                        if (!test)
                            c--;
                        test = true;
                        foreach (var i in igreds)
                            if (Controller.GetAllFrom(SpecialSqlController.Tables.products, $" Id={i["Product"]} and `Count`<{int.Parse(i["Count"]) * c}").Count() > 0)
                            {
                                test = false;
                            }
                    } while (!test);

                    if (c != (int)CountTov.Value)
                    {
                        MessageBox.Show("Не хватает продуктов максимально возможное количество="+c.ToString());
                        return;
                    }

                    foreach (var i in igreds)
                        Controller.Request($"update products set `count`=`count`-{int.Parse( i["Count"])*CountTov.Value} where (Id={i["Product"]})");

                   
                    Dishes.Rows.Add(Eat[id]["Id"], "Eat", Eat[id]["Names"] + " " + Eat[id]["Portion"], CountTov.Value.ToString(), Eat[id]["Cost"]);
                    BuyEat.Add(d);
                }
                else
                {
                    id -= Eat.Count();
                    Dictionary<string, string> d = new Dictionary<string, string>();
                    if (BuyDrink.Where(x => x["Id"].CompareTo(Drink[id]["Id"]) == 0).Count() == 0)
                    {
                     //   Dishes.Rows.Add(Drink[id]["Id"], "Drink", Drink[id]["Names"] + " " + Drink[id]["Volume"] + "мл.", CountTov.Value.ToString(), Drink[id]["Cost"]);
              
                        d.Add("Id", Drink[id]["Id"]);
                        d.Add("Count", CountTov.Value.ToString());
                      
                    }
                    else
                    {
                        int coun = int.Parse(BuyDrink.Where(x => x["Id"].CompareTo(Drink[id]["Id"]) == 0).First()["Count"]);
                        BuyDrink.Remove(BuyDrink.Where(x => x["Id"].CompareTo(Drink[id]["Id"]) == 0).First());
                        for (int i = 0; i < Dishes.RowCount; i++)

                            if (Dishes[0, i].Value.ToString().CompareTo(Drink[id]["Id"]) == 0 && Dishes[1, i].Value.ToString().CompareTo("Drink") == 0)
                            {
                                All -= Int32.Parse(Dishes[4, i].Value.ToString()) * Int32.Parse(Dishes[3, i].Value.ToString());
                                Dishes.Rows.RemoveAt(i);
                                List<Dictionary<string, string>> igredss = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, " Brew=" + Drink[id]["Id"]);

                                foreach (var j in igredss)
                                    Controller.Request($"update products set `count`=`count`+{int.Parse(j["Count"]) * coun} where (Id={j["Product"]})");

                                break;
                            }
   
                        d.Add("Id", Drink[id]["Id"]);
                        d.Add("Count", CountTov.Value.ToString());
 
                    }


                    List<Dictionary<string, string>> igreds = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, "Brew=" + Drink[id]["Id"]);


                    int c = (int)CountTov.Value;
                    bool test = true;
                    do
                    {
                        if (!test)
                            c--;
                        test = true;
                        foreach (var i in igreds)
                            if (Controller.GetAllFrom(SpecialSqlController.Tables.products, $" Id={i["Product"]} and `Count`<{int.Parse(i["Count"]) * c}").Count() > 0)
                            {
                                test = false;
                            }
                    } while (!test);

                    if (c != (int)CountTov.Value)
                    {
                        MessageBox.Show("Не хватает продуктов максимально возможное количество=" + c.ToString());
                        return;
                    }

                    foreach (var i in igreds)
                        Controller.Request($"update products set `count`=`count`-{int.Parse(i["Count"]) * CountTov.Value} where (Id={i["Product"]})");
                    Dishes.Rows.Add(Drink[id]["Id"], "Drink", Drink[id]["Names"] + " " + Drink[id]["Volume"], CountTov.Value.ToString(), Drink[id]["Cost"]);

                    BuyDrink.Add(d);
                }
                CountTov.Value = 1;
                All += Int32.Parse(Dishes[4,Dishes.RowCount-1].Value.ToString())* Int32.Parse(Dishes[3, Dishes.RowCount - 1].Value.ToString());
                AllMoney.Text = ((int)(All - All * Minus / 100)).ToString();
            }
            else
                Error("Не выбран товар");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (RowTest(Dishes))
            {
                All -= Int32.Parse(Dishes[4, Dishes.SelectedRows[0].Index].Value.ToString()) * Int32.Parse(Dishes[3, Dishes.SelectedRows[0].Index].Value.ToString());
                Dictionary<string, string> d = BuyDrink.Where(x=>x["Id"].CompareTo(Dishes[0,Dishes.SelectedRows[0].Index].Value)==0).FirstOrDefault();
                Dictionary<string, string> ea= BuyEat.Where(x=>x["Id"].CompareTo(Dishes[0,Dishes.SelectedRows[0].Index].Value)==0).FirstOrDefault();
                string param = "",id="";
                int coun = 0;
                if (ea == null)
                {
                    param = "Brew";
                    id = d["Id"];
                    coun = int.Parse(d["Count"]);
                    BuyDrink.Remove(d);
                }
                else
                {
                    if (d == null)
                    {
                        param = "Dish";
                        id = ea["Id"];
                        coun = int.Parse(ea["Count"]);
                        BuyEat.Remove(ea);
                    }
                    else
                    {
                        if (Eat.Where(x => x["Id"].CompareTo(ea["Id"]) == 0).First()["Names"].CompareTo(Dishes[0, Dishes.SelectedRows[0].Index].Value) == 0)
                        {
                            param = "Dish";
                            id = ea["Id"];
                            coun = int.Parse(ea["Count"]);
                            BuyEat.Remove(ea);
                        }
                        else
                        {
                            param = "Brew";
                            id = d["Id"];
                            coun = int.Parse(d["Count"]);
                            BuyDrink.Remove(d);
                        }
                    }
                }
                List<Dictionary< string, string>> ings = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, $"{param}={id}");
                foreach (var i in ings)
                {
                    Controller.Request($"Update products set `Count`=`Count`+{int.Parse(i["Count"])*coun} where(`Id`={i["Product"]})");
                }
                Dishes.Rows.RemoveAt(Dishes.SelectedRows[0].Index);
                AllMoney.Text =((int)( All-All*Minus/100)) .ToString();
            }
        }

        private void Card_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerCard=new Dictionary<string, string>();
                CustomerCard = Controller.TakeRowWithNames(SpecialSqlController.Tables.customers, $"Id={Int32.Parse(Card.Text)} and Enable=1");
                if (CustomerCard.Count != 0)
                {
                    Customer.Text = CustomerCard["Lname"] + " " + CustomerCard["Fname"][0] + ".";
                    if (AdresText.Text.Length == 0&&Table.SelectedIndex==-1)
                    {
                        AdresText.Text = CustomerCard["Adres"];
                    }
                    Minus = Int32.Parse(CustomerCard["Procent"]);
                }
                else
                {
                    CustomerCard = new Dictionary<string, string>();
                    Customer.Text = "";
                    AdresText.Text = "";
                    Minus = 0;
                }
            }
            catch
            {
                CustomerCard = new Dictionary<string, string>();
                Minus = 0;
                Customer.Text = "";
                Adres.Text = "";
            }
            AllMoney.Text = ((int)(All - All * Minus / 100)).ToString();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            CreateCheck();
        }

        private void CreateCheck()
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (Customer.Text.Length < 5) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (Table.SelectedIndex == -1 && AdresText.Text.Length < 5) { Error("Не введено место доставки"); return true; }; return false; });
            tests.Add(delegate () { if (Employeer.SelectedIndex == -1) { Error("Сотрудник не выбран"); return true; }; return false; });
            tests.Add(delegate () { if (Dishes.RowCount == 0) { Error("Нет товаров"); return true; }; return false; });
            tests.Add(delegate () { if (Card.Text.Length > 0 && Controller.TakeRowById(SpecialSqlController.Tables.customers, int.Parse(Card.Text)).Count == 0) { Error("Карта не существует"); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                if (RowId == null)
                {
                    if (Controller.InsertCheck(new List<string> { Customer.Text, Table.SelectedIndex != -1 ? Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"] : null, Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, AdresText.Text.Length != 0 ? AdresText.Text : null, Statys.Text, CustomerCard.Count() != 0 ? CustomerCard["Id"] : null }, BuyEat, BuyDrink))
                    {
                        if (Table.SelectedIndex != -1) Controller.Request("UPDATE `pizzeria`.`tables` SET `CanTake` = '0' WHERE `Id`=" + (Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"]));
                        Dishes.Rows.Clear();
                        this.Close();

                    }
                }
                else
                {
                    Controller.DeleteFrom(SpecialSqlController.Tables.orders, "`Check`=" + RowId);
                    Controller.DeleteFrom(SpecialSqlController.Tables.checks, int.Parse(RowId));
                    if (Controller.InsertCheck(new List<string> { Customer.Text, Table.SelectedIndex != -1 ? Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"] : null, Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, AdresText.Text.Length != 0 ? AdresText.Text : null, Statys.Text, CustomerCard.Count() != 0 ? CustomerCard["Id"] : null }, BuyEat, BuyDrink))
                    {
                        if (Table.SelectedIndex != -1 && Statys.Text == "Оплачен") Controller.Request("UPDATE `pizzeria`.`tables` SET `CanTake` = '1' WHERE `Id`=" + (Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"]));

                        Dishes.Rows.Clear();
                        this.Close();

                    }
                }
            }
        }

        private void AdresText_Click(object sender, EventArgs e)
        {
            AdresText.Text = "";
            Table.SelectedIndex = -1;
        }

        private void CheckCreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < Dishes.RowCount; i++)
            {
                Delete_Click(Dishes, EventArgs.Empty);
                i--;
            }
        }

        private void Statys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Statys.Text == "Оплачен" && OnLoad)
            {
                Calcut c = new Calcut(All);
                DialogResult result = c.ShowDialog();
                if (result != DialogResult.OK)
                    Statys.SelectedIndex = Statys.Items.Count - 2;
                else
                {
                    CreateCheck();
                }

            }
        }
    }
}
