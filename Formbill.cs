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
    public partial class Formbill : Form
    {
        public Formbill()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Formbill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet20.Bill1' table. You can move, or remove it, as needed.
            this.bill1TableAdapter.Fill(this.cmbloginDataSet20.Bill1);

           



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Bill1 Values(@SLNo,@Name,@Mobile,@StayDays,@TotalBill,@CheckOutDate)", con);

            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@StayDays", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@TotalBill", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@CheckOutDate", dateTimePicker1.Value);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();



            SqlCommand sq1 = new SqlCommand("select * from Bill1", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);



            DataTable dt = new DataTable();
            ds.Fill(dt);



            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

        
            SqlCommand cnn = new SqlCommand("update Bill1 set SLNo=@SLNo,Name=@Name,Mobile=@Mobile,StayDays=@StayDays,TotalBill=@TotalBill,CheckOutDate=@CheckOutDate where SLNo=@SLNo", con);

            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@StayDays", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@TotalBill", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@CheckOutDate", dateTimePicker1.Value);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("delete from Bill1 where SLNo=@SLNo", con);

            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("DELETED");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 F1 = new Form3();
            F1.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
