using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace CourseWork
{
   public class SpecialSqlController : SqlController
    {
        public SpecialSqlController() : base() { }

        public SpecialSqlController(string connectionString) : base(connectionString) { }

        public enum Tables
        {
            categorydrink=0,
            categoryeat=1,
            checks=2,
            customers,
            drink,
            eat,
            employeers,
            ingredients,
            job,
            orders,
            products,
            tables
        }
 
        public List<string> ColumnsNames(MySqlCommand command)
        {
            command.Connection.Open();
           List<string> result = new List<string>();
            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        result.Add(reader.GetName(i));

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                result.Clear();
            }
            command.Connection.Close();
            return result;
        }

        public List<string> GetColumnsNames(Tables table)
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString()+" limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return ColumnsNames(command);
            }
            else
                return new List<string>();
        }

        public List<List<string>> GetAllFrom(Tables table, string where= "Enable=1")
        {
            if (Connection != null)
            {

                string text = "select * from " + table.ToString() + " where " + where;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDate(command);
            }
            else
                return new List<List<string>>();
        }

        public List<Dictionary<string, string>> GetAllFromWithNames(Tables table,string where= "Enable=1")
        {
            if (Connection != null)
            {
                string text = "select * from " + table.ToString()+" where ("+where+")";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return GetQueryDateWithNames(command);
            }
            else
                return new List<Dictionary<string, string>>();
        }

        public bool InsertIn(Tables table,List<string> values,string startAfter="Id")
        {
            if (Connection != null)
            {
                string columns = "(";
                string value= "(";
                List<string> names=   GetColumnsNames(table);  
                for (int i = 0; i <= names.IndexOf(startAfter); i++)
                {
                    names.RemoveAt(i);
                    i--;
                }
                names.Remove(names.Last());
                if (names.Count <= 1)
                return false;
                for (int i = 0; i < names.Count; i++)
            {
                columns += "`" + names[i]+ "`";
                if (i != names.Count - 1)
                    columns += ",";
                else
                    columns += ")";
            }
                if (values.Count<names.Count-1)
                return false;
                for (int i = 0; i < values.Count; i++)
                {
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                    else
                        value += ")";
                }
                string text = "Insert into " + "`"+table.ToString()+ "`" + " " + columns + " values" + value;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }

        public bool UpdateIn(Tables table, List<string> values,string id)
        {
            if (Connection != null)
            {
                string value = "";
                List<string> names = GetColumnsNames(table);
                names.RemoveAt(0);
                if (names.Count <= 1)
                    return false;
                for (int i = 0; i < values.Count; i++)
                {
                    value += $"`{names[i]}`=";
                    int type = 0;
                    if (values[i] == null) type = 2;
                    if (type == 2)
                        value += "null";
                    else
                        value += "'" + values[i] + "'";

                    if (i != values.Count - 1)
                        value += ",";
                }
                string text = "UPDATE " + "`" + table.ToString() + "` set " +  value+" where Id="+id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;

        }

        public bool DeleteFrom(Tables table, int id)
        {
            if (Connection != null)
            {
                string text = "delete from " + "`" + table.ToString() + "`"+ "where Id=" + id;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteFrom(Tables table, string where)
        {
            if (Connection != null)
            {
                string text = "delete from `pizzeria`.`"+table.ToString()+"` where("+where+")" ;
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public bool DeleteToHistory(Tables table, int id)
        {
            if (Connection != null)
            {
                string text = "Update " + "`"+table.ToString()+"`  SET `Enable` = '0' WHERE(`Id` = '"+id.ToString()+"')";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
            {
                return false;
            }
        }

        public List<string> TakeRow(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count!=0)
                return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }

        public Dictionary<string,string> TakeRowWithNames(Tables table, string where)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where " + where + " limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                   return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }

        public Dictionary<string, string> TakeRowWithNamesById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from " + table + " where Id= '" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<Dictionary<string, string>> result = GetQueryDateWithNames(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new Dictionary<string, string>();
            }
            else
                return new Dictionary<string, string>();
        }

        public List<string> TakeRowById(Tables table, int id)
        {

            if (Connection != null)
            {

                string text = "select * from "+table+" where Id='" + id + "' limit 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count != 0)
                    return result.First();
                else
                    return new List<string>();
            }
            else
                return new List<string>();
        }

        public int AuthorizationUser(string login,  string password,string days)
        {
            string text = "";
            if(login!="admin"||password!="admin")
            text ="password='" + password+"' and lname='"+login+"' and Days='"+days+"' and Enable=1";
            else
                text= "password='" + password + "' and lname='" + login + "'";
            List<string> result = TakeRow(Tables.employeers, text);
            if (result.Count() != 0)
                return Convert.ToInt32( result[0]);
            else
                return 0;
        }

        public Dictionary<string, string> GetUserInfoById(int id)
        {
           Dictionary<string,string> result= TakeRowWithNamesById(Tables.employeers, id);
            result["Job"] = TakeRowById(Tables.job, Convert.ToInt32(result["Job"]))[1];
            return result;
        }

        public int Maximum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select max(" + columnname + ") from " + table.ToString() + " where Enable = 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }

        public int Minimum(Tables table, string columnname)
        {
            if (Connection != null)
            {
                string text = "select min(" + columnname + ") from " + table.ToString() + " where Enable = 1";
                MySqlCommand command = new MySqlCommand(text, Connection);
                List<List<string>> result = GetQueryDate(command);
                if (result.Count > 0 && result[0].Count > 0)
                    try
                    {
                        return Convert.ToInt32(result[0][0]);
                    }
                    catch
                    {
                        return 0;
                    }
                else
                    return 0;
            }
            else
                return 0;
        }

        public bool BackFromHistory(Tables table, string name)
        {
            if (Connection != null)
            {
                if (TakeRow(table, "Enable=0 and `Names`='" + name + "'").Count > 0)
                {
                    string text = "Update " + "`" + table.ToString() + "`  SET `Enable` = '1' WHERE(`Names` = '" + name + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    return RequestCommand(command);
                }
                else
                {

                    string text = "Insert into " + "`" + table.ToString() + "` (`Names`) values ('" + name + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    return RequestCommand(command);

                }
            }
            else
                return false;
        }

        public bool BackFromHistory(Tables table, string id, string name)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET `Names` = '" + name + "' WHERE(`Id` = '" + id.ToString() + "' and `Enable` = '1')";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);



            }
            else
                return false;
        }

        public bool ProductCountZero(string id)
        {
            if (Connection != null)
            {
                string text = $"Update `{Tables.products.ToString()}`  SET `Count` = '0' WHERE(`id` = '{id}')";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);
            }
            else
                return false;
        }

        public bool AddProducts(List<Dictionary<string, string>> products)
        {
            if (Connection != null)
            {
                foreach (var p in products)
                {
                    string text = "";

                    if (TakeRow(Tables.products, $" `Names`='{p["Names"]}'").Count() > 0)
                    {
                        string id = TakeRow(Tables.products, $"`Names`='{p["Names"]}'")[0];
                        text = $"Update `{Tables.products.ToString()}`  SET `Count` = Count+{p["Count"]}, `Ones` = '{p["Ones"]}', `MinCount` = '{p["MinCount"]}'  WHERE(`id` = '{id}')";
                    }
                    else
                    {
                        text = $"insert into `{Tables.products.ToString()}` (`Names`,`Count`,`Ones`,`MinCount`) values ('{p["Names"]}','{p["Count"]}','{p["Ones"]}','{p["MinCount"]}')";

                    }
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    if (!RequestCommand(command)) return false;
                }
                return true;
            }
            else
                return false;

        }

        public bool InsertInMenu(Tables table, List<string> values, List<Dictionary<string, string>> ingredients)
        {
            if (Connection != null)
            {
                    return InsertIn(table, values)&&InsertIngredients(ingredients, table);
            }
            else
                return false;

        }

        public bool UpdateMenu(Tables table,string id, List<string> values, List<Dictionary<string, string>> ingredients)
        {
            if (Connection != null)
            {
                return UpdateIn(table,values,id) && InsertIngredients(ingredients, table, id);
            }
            else
                return false;

        }

        public bool InsertIngredients(List<Dictionary<string, string>> ingredients,Tables table,string id=null)
        {
            if (Connection != null)
            {
                Thread.Sleep(500);
                 id = id?? Maximum(table, "Id").ToString();
                string where = "";
                string tableColumn = "";
                if (table == Tables.drink)
                {
                    where = "Brew is not null and Brew=" + id;
                    tableColumn = "Brew";
                }
                else
                {
                    where = "Dish is not null and Dish=" + id;
                    tableColumn = "Dish";
                }
                DeleteFrom(Tables.ingredients, where);
                    foreach (var i in ingredients)
                {
                    string text = "";
                      text= "Insert into `ingredients`  (`"+tableColumn+"`, `Product`, `Count`) values  " +
              "('" + id + "', '" + i["Id"] + "', '" + i["Count"]+ "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    if (!RequestCommand(command))
                        return false;
                }
                return true;

            
            }
            else
                return false;
        }

        public bool InsertCheck(List<string> values,List<Dictionary<string,string>> dish, List<Dictionary<string, string>> brew)
        {
            if (Connection != null)
            {

                return InsertIn(Tables.checks, values)&&InsertOrder(brew,dish);
            }
            else
                return false;
        }

        public bool InsertOrder(List<Dictionary<string, string>> brews, List<Dictionary<string, string>> dishes, string id=null)
        {
            if (Connection != null)
            {
                
                id = id ?? Maximum(Tables.checks, "Id").ToString();
                string where = "`Check`='" + id+"'";
                DeleteFrom(Tables.orders, where);
                foreach (var b in brews )
                {
                    string text = "";
                    text = "Insert into `orders`  (`Brew`, `Count`,`Check`) values  " +
            "('" + b["Id"] + "', '" + b["Count"] + "', '" + id + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    if (!RequestCommand(command))
                        return false;
                }

                foreach (var d in dishes)
                {
                    string text = "";
                    text = "Insert into `orders`  (`Dish`, `Count`,`Check`) values  " +
            "('" + d["Id"] + "', '" + d["Count"] + "', '" + id + "')";
                    MySqlCommand command = new MySqlCommand(text, Connection);
                    if (!RequestCommand(command))
                        return false;
                }
                return true;


            }
            else
                return false;
        }

        public bool UpdateCell(Tables table, string update, string where)
        {
            if (Connection != null)
            {
                string text = "Update " + "`" + table.ToString() + "`  SET " + update + " WHERE( " + where + " )";
                MySqlCommand command = new MySqlCommand(text, Connection);
                return RequestCommand(command);



            }
            else
                return false;
        }
    }
}

