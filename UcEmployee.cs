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

namespace Hotel_Management_System.User_Controls
{
    public partial class UcEmployee : UserControl
    {
        public UcEmployee()
        {
            InitializeComponent();
        }

        private void UcEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //display
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Emp1", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
          
       
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Emp1 Values(@Id,@Name,@Role,@Password,@Gender,@Mobile)", con);


            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", maskedTextBox1.Text);
            cnn.Parameters.AddWithValue("@Role", textBox2.Text);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cnn.Parameters.AddWithValue("@Password", textBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

            con.Open();


            SqlCommand cnn = new SqlCommand("delete from Emp1 where Id=@Id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("USER DELETED");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Emp1 set Id=@Id,Name=@Name,Role=@Role,Password=@Password,Gender=@Gender,Mobile=@Mobile where Id=@Id", con);


            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Name", maskedTextBox1.Text);
            cnn.Parameters.AddWithValue("@Role", textBox2.Text);
            cnn.Parameters.AddWithValue("@Mobile", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cnn.Parameters.AddWithValue("@Password", textBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength == 11)
            {
                textBox5.ForeColor = Color.Black;
            }
            else
                textBox5.ForeColor = Color.Red;
        }
    }
}
