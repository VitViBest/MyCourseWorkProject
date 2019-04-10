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
    public partial class Calcut : Form
    {
        int Summa;
        public Calcut()
        {
            InitializeComponent();
        }
        public Calcut(int summa)
        {
            InitializeComponent();
            Done.Enabled = false;
            Summa = summa;
            Summ.Text += Summa.ToString();
            Give.Minimum = Summa;
          
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Back.Text += (Give.Value - Summa).ToString();
            MessageBox.Show(Back.Text);
        }

        private void Give_ValueChanged(object sender, EventArgs e)
        {
            if (Give.Value >= Summa)
                Done.Enabled = true;
            else
                Done.Enabled = false;
        }
    }
}
