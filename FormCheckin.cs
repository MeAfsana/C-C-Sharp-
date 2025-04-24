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
    public partial class FormCheckin : Form
    {
        public FormCheckin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3();
            f4.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update customer1 set SL_No=@SL_No,NID=@NID,Name=@Name,Address=@Address,CheckinDate=@CheckinDate,Person=@Person,PhnNo=@PhnNo  where SL_No=@SL_No", con);


            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@SL_No", int.Parse(textBox5.Text));

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@CheckinDate", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@PhnNo", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox3.Text);
            cnn.Parameters.AddWithValue("@NumberOfPerson", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FormCheckin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet24.Customer2' table. You can move, or remove it, as needed.
            this.customer2TableAdapter.Fill(this.cmbloginDataSet24.Customer2);




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Customer2 Values(@SLNo,@NID,@Name,@Address,@CheckinDate,@Person,@Mobile)", con);



            cnn.Parameters.AddWithValue("@SLNo", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@NID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@Name", textBox1.Text);
            cnn.Parameters.AddWithValue("@CheckinDate", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@Address", textBox3.Text);
            cnn.Parameters.AddWithValue("@Person", int.Parse(textBox6.Text));


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from customer1", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

            con.Open();


            SqlCommand cnn = new SqlCommand("delete from customer1 where SL_No=@SL_No", con);

            cnn.Parameters.AddWithValue("@SL_No", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("DELETED");
        }
    }
}
