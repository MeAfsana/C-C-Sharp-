using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Customer2 Values(@NID,@SLNo,@Name,@Mobile,@Address,@Person,@CheckinDate)", con);

            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox3.Text);
            cnn.Parameters.AddWithValue("@Person", int.Parse(textBox6.Text));

            cnn.Parameters.AddWithValue("@CheckinDate", dateTimePicker1.Value);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();



            SqlCommand sq1 = new SqlCommand("select * from Customer2", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);



            DataTable dt = new DataTable();
            ds.Fill(dt);



            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void FormCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet25.Customer2' table. You can move, or remove it, as needed.
            this.customer2TableAdapter.Fill(this.cmbloginDataSet25.Customer2);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Customer2 set SLNo=@SLNo,NID=@NID,Name=@Name,Address=@Address,CheckinDate=@CheckinDate,Person=@Person,Mobile=@Mobile  where NID=@NID", con);


            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@CheckinDate", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox3.Text);
            cnn.Parameters.AddWithValue("@Person", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("delete from Customer2 where NID=@NID", con);

            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));

            cnn.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("DELETED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F1 = new Form3();
            F1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 F1 = new Form3();
            F1.Show();
            this.Hide();
        }
    }
}
