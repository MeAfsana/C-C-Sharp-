using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "ID") 
            {
                txtUsername.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password
            }

        }
        
           


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select * from login where username ='" + txtUsername.Text + "'and passwords='" + txtPassword.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = comboBox1.SelectedItem.ToString();
                if(dt.Rows.Count> 0)
                {
                    for(int i =0; i<dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                        {
                           
                            if (comboBox1.SelectedIndex == 0)
                            {
                                Form2 f = new Form2();
                                f.Show();
                                this.Hide();
                            }
                            else if (comboBox1.SelectedIndex == 1)


                            {

                                Form3 ff = new Form3();
                                ff.Show();
                                this.Hide();
                            }
                            else 
                            {

                                Form5 ff = new Form5();
                                ff.Show();
                                this.Hide();
                            }



                        }
                    }
                }
             
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
