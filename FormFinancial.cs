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
    public partial class FormFinancial : Form
    {
        public FormFinancial()
        {
            InitializeComponent();
        }

        private void FormFinancial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet12.statement' table. You can move, or remove it, as needed.
            this.statementTableAdapter.Fill(this.cmbloginDataSet12.statement);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into statement Values(@Month,@AccTitle,@Debit,@Credit)", con);

            cnn.Parameters.AddWithValue("@Month", textBox1.Text);
            cnn.Parameters.AddWithValue("@AccTitle", textBox2.Text);

            cnn.Parameters.AddWithValue("@Debit", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Credit", int.Parse(textBox4.Text));


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insert Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();



            SqlCommand sq1 = new SqlCommand("select * from statement", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);



            DataTable dt = new DataTable();
            ds.Fill(dt);



            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");
            con.Open();



            SqlCommand cnn = new SqlCommand("delete from Statement where MONTH=@Month", con);
            cnn.Parameters.AddWithValue("@Month", textBox1.Text);

            cnn.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("DELETED");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form5 F1 = new Form5();
            F1.Show();

            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from statement where Month=@Month", con);
            cnn.Parameters.AddWithValue("@Month", textBoxSearch.Text);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}
