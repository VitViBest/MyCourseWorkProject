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
    public partial class ProfileForm : MainController
    {
        private int UserId;
        public ProfileForm():base()=>InitializeComponent();

        public ProfileForm(int id) : base()
        {
            InitializeComponent();
            ButtonLoad();
            UserId = id;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> info = Controller.GetUserInfoById(UserId);
            foreach (var s in info)
            {
                if (s.Key!="Id"&&s.Key!="Born"&& s.Key !="Enable")
                (this.Controls[s.Key] as Label).Text += s.Value;
                if (s.Key == "Born")
                    (this.Controls[s.Key] as Label).Text += s.Value.Split(' ')[0];
            }
        }
    }
}
