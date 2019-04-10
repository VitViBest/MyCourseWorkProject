using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class OrdersForm : MainController
    {
        public OrdersForm() : base()
        {
            InitializeComponent();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.checks, delegate (Dictionary<string, string> data)
            {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("Id", data["Id"]);
            result.Add("Names", data["Customer"]);
                if (!data.ContainsKey("Adres")||data["Adres"].Length==0)
            result.Add("Place", Controller.TakeRowById(SpecialSqlController.Tables.tables, int.Parse(data["Table"]))[1]);
                else
                    result.Add("Place", data["Adres"]);
                result.Add("Employeer", Controller.TakeRowById(SpecialSqlController.Tables.employeers, int.Parse(data["Employeer"]))[1]);
            result.Add("Status", data["Status"]);
            List<Dictionary<string, string>> order = Controller.GetAllFromWithNames(SpecialSqlController.Tables.orders, " `Check`='" + data["Id"]+"'");
            int sum = 0;
                foreach (var o in order)
                    if (o.ContainsKey("Dish")&&o["Dish"].Length>0)
                        sum += Convert.ToInt32(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, int.Parse(o["Dish"]))["Cost"]);
                    else
                        sum += Convert.ToInt32(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, int.Parse(o["Brew"]))["Cost"]);

                    if (data.ContainsKey("CardKey") && data["CardKey"].Length > 0)
                        sum = (int)(sum - sum * int.Parse(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customers, int.Parse(data["CardKey"]))["Procent"]) / 100);
                result.Add("All", sum.ToString());

           
                return result;
            });
            DataList.Reverse();
        }


        public override void Actions()
        {
            MainAction();
            Print(ref Orders);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders) && Orders[4, Orders.SelectedRows[0].Index].Value.ToString().CompareTo("Принят") == 0)
            {
                Hiding(Orders, SpecialSqlController.Tables.checks, delegate (string[] s)
                {
                    if (Controller.TakeRowWithNamesById(SpecialSqlController.Tables.checks, int.Parse(s[0])).ContainsKey("Table") && Controller.TakeRowWithNamesById(SpecialSqlController.Tables.checks, int.Parse(s[0]))["Table"].Length > 0)
                    Controller.Request("UPDATE `pizzeria`.`tables` SET `CanTake` = '1' WHERE `Id`=" + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.checks, int.Parse(s[0]))["Table"]);
                    var tovars = Controller.GetAllFromWithNames(SpecialSqlController.Tables.orders, $"`Check`='{s[0]}'");
                    foreach(var t in tovars)
                    {
                        string par = "Dish";
                        if (t.ContainsKey("Brew") && t["Brew"].Length > 0)
                            par = "Brew";
                        var good = Controller.TakeRowWithNamesById(par=="Dish"?SpecialSqlController.Tables.eat:SpecialSqlController.Tables.drink,int.Parse(t[par]));
                        var ings = Controller.GetAllFromWithNames(SpecialSqlController.Tables.ingredients, $"{par}='{good["Id"]}'");
                        foreach(var i in ings)
                        {
                    Controller.Request($"update products set `count`=`count`+{int.Parse(i["Count"]) * int.Parse(t["Count"])} where (Id={i["Product"]})");

                        }
                    }
                    return Controller.Request($"UPDATE `pizzeria`.`checks` SET `Status` = 'Отменен' WHERE (`Id` = '{s[0]}')");
                }, false,show:"Поддтвердите действие");
                Actions();
            }
            else
            {
                Error("Статус заказа не позволяет его отменить");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders))
            {
                OpenForm(new CheckCreateForm(GetId(Orders)));
                Actions();
            }
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders))
            {
                string writePath = @"Check.doc";
                using(StreamWriter sw=new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Заказ №" + GetId(Orders));
                  Dictionary<string,string> line=  Controller.TakeRowWithNamesById (SpecialSqlController.Tables.checks,int.Parse(GetId(Orders)));
                    sw.WriteLine("Клиент: " + line["Customer"]);
                    sw.WriteLine("Официант: " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers, int.Parse(line["Employeer"]))["Lname"]);
                    if (line.ContainsKey("Table")&&line["Table"].Length>0)
                        sw.WriteLine("Стол: " + Controller.TakeRowById(SpecialSqlController.Tables.tables, int.Parse(line["Table"]))[1]);
                    sw.WriteLine("Принят: " + line["DateOrder"]);
                    sw.WriteLine("Выдан: " + line["DateGive"]);
                    if (line.ContainsKey("Adres")&&line["Adres"].Length>0)
                        sw.WriteLine("Адрес: " + line["Adres"]);
                    if (line.ContainsKey("CardKey")&&line["CardKey"].Length>0)
                        sw.WriteLine("Скидка: " + Controller.TakeRowById(SpecialSqlController.Tables.customers, int.Parse(line["CardKey"]))[3]);
                    sw.WriteLine("Заказ:");
                    List<Dictionary<string, string>> rows = Controller.GetAllFromWithNames(SpecialSqlController.Tables.orders, "`Check`=" + line["Id"]);
                    int all = 0;
                    foreach(var r in rows)
                    {

                        string text = "";
                        if (r.ContainsKey("Dish")&&r["Dish"].Length>0)
                            text += Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, int.Parse(r["Dish"]))["Names"] + " " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, int.Parse(r["Dish"]))["Portion"] + "-" + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.eat, int.Parse(r["Dish"]))["Cost"] + "-";
                        else
                            text += Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, int.Parse(r["Brew"]))["Names"] + " " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, int.Parse(r["Brew"]))["Volume"] + "-" + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.drink, int.Parse(r["Brew"]))["Cost"]+"-";
                        all += int.Parse(text.Split('-')[1]);
                        text += r["Count"];
                        sw.WriteLine(text);
                    }
                    if (line.ContainsKey("CardKey") && line["CardKey"].Length > 0)
                       all-=(int)( int.Parse( Controller.TakeRowById(SpecialSqlController.Tables.customers, int.Parse(line["CardKey"]))[4])/100*all);
                    sw.WriteLine("Всего: "+all.ToString());
                    Error("Чек успешно создан");
                
                }
            }
        }
    }
}
