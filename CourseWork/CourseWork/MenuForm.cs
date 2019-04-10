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
    public partial class MenuForm : MainController
    {
        private int UserId;

        public MenuForm():base() => InitializeComponent();

        public MenuForm(int id) : base()
        {
            InitializeComponent();
            ButtonLoad();
            UserId = id;
            string job = Controller.TakeRowById(SpecialSqlController.Tables.job, int.Parse(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers, UserId)["Job"]))[1];
            switch (job) {
                case "Официант":
            
                Employeers.Enabled=false;
                Dishes.Enabled=false;
                Brews.Enabled=false;
                Statistica.Enabled=false;
                Raiting.Enabled=false;
                Products.Enabled=false;
                Tables.Enabled=false;
                    break;
               case "Повар":
            
                Statistica.Enabled=false;
                Raiting.Enabled=false;
                Employeers.Enabled=false;
                Orders.Enabled=false;
                CreateCheck.Enabled=false;
                Customers.Enabled=false;
                Tables.Enabled=false;
                    break;

                case "Администратор":
            
                CreateCheck.Enabled=false;
                Orders.Enabled=false;
                Products.Enabled=false;
                Customers.Enabled=false;
                    break;

                case "Admin": break;
                default:
                    
                        Statistica.Enabled=false;
                        Raiting.Enabled=false;
                        Employeers.Enabled=false;
                        Products.Enabled=false;
                        Orders.Enabled=false;
                        CreateCheck.Enabled=false;
                        Customers.Enabled=false;
                        Dishes.Enabled=false;
                        Brews.Enabled=false;
                        Products.Enabled=false;
                        Tables.Enabled=false;
                        break;
                    
        }


        }

        private void Profile_Click(object sender, EventArgs e)
        {
           OpenForm(new ProfileForm(UserId)); 
        }

        private void Employeers_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeersForm(UserId));
        }

        private void Dishes_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderDishForm());
        }

        private void Brews_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderBrewForm());
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm ());
        }

        private void Products_Click(object sender, EventArgs e)
        {
            OpenForm(new ProductsForm());
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.tables));
        }

        private void CreateCheck_Click(object sender, EventArgs e)
        {
            OpenForm(new CheckCreateForm(UserId));
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm());
        }

        private void Statistica_Click(object sender, EventArgs e)
        {
            OpenForm(new DateFrom());
        }

        private void Raiting_Click(object sender, EventArgs e)
        {
            OpenForm(new RaitingForm());
        }
    }
}
