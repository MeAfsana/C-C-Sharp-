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
    public partial class FormPayroll : Form
    {
        public FormPayroll()
        {
            InitializeComponent();
        }

        private void FormPayroll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet16.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter1.Fill(this.cmbloginDataSet16.Salary);
            // TODO: This line of code loads data into the 'cmbloginDataSet6.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.cmbloginDataSet6.Salary);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //insert
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Salary Values(@ID,@Name,@Role,@Salary,@Bonus,@SalaryStatus)", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox5.Text);
            cnn.Parameters.AddWithValue("@Role", textBox2.Text);

            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Bonus", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@SalaryStatus", comboBox1.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form5 F1 = new Form5();
            F1.Show();

            this.Hide();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();
            SqlCommand sq1 = new SqlCommand("select * from Salary", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);

            DataTable dt = new DataTable();
            ds.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e) //update
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Salary set ID=@ID,Name=@Name,Role=@Role,Salary=@Salary,Bonus=@Bonus,SalaryStatus=@SalaryStatus where ID=@ID", con);

            cnn.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox5.Text);
            cnn.Parameters.AddWithValue("@Role", textBox2.Text);

            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Bonus", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@SalaryStatus", comboBox1.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
