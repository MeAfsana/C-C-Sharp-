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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = btnRoom.Height;
            SidePanel.Top = btnRoom.Top;
            ucRoomlist1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRoom.Height;
            SidePanel.Top = btnRoom.Top;
            ucRoomlist1.BringToFront();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();

            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnEmp.Height;
            SidePanel.Top = btnEmp.Top;
            ucEmployee1.BringToFront();

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();

        }

        private void ucEmployee1_Load(object sender, EventArgs e)
        {

        }
    }

    internal class UserControls
    {
        internal class UcAddRoom : Control
        {
        }

        internal class UcEmployeeInfo : Control
        {
        }

        internal class UcEmployee : Control
        {
        }
    }
}
