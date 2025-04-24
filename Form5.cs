using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            FormPayroll F1 = new FormPayroll();
            F1.Show();
            this.Hide();

        }

        private void btnfinancial_Click(object sender, EventArgs e)
        {
            FormFinancial F2 = new FormFinancial();
            F2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 F3 = new Form1();
            F3.Show();
            this.Hide();
        }
    }
}
