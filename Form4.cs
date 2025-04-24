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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet2.AddRoomNEw' table. You can move, or remove it, as needed.
            this.addRoomNEwTableAdapter1.Fill(this.cmbloginDataSet2.AddRoomNEw);
            // TODO: This line of code loads data into the 'cmbloginDataSet1.AddRoomNEw' table. You can move, or remove it, as needed.
            this.addRoomNEwTableAdapter.Fill(this.cmbloginDataSet1.AddRoomNEw);
            // TODO: This line of code loads data into the 'cmbloginDataSet.AddRoom' table. You can move, or remove it, as needed.
            //this.addRoomTableAdapter1.Fill(this.cmbloginDataSet.AddRoomNEw);
           
            // TODO: This line of code loads data into the 'addroomDataSet1.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.addroomDataSet1.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) //delete
        {
           {

             

                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");

                    con.Open();


                    SqlCommand cnn = new SqlCommand("delete from AddRoomNEw where RoomNo=@RoomNo", con);

                    cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox1.Text));

                    cnn.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("USER DELETED");

                }

            }

        private void btnAdd_Click(object sender, EventArgs e) //add button
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into AddRoomNEw Values(@RoomNo,@Type,@Bed,@Price,@Available)", con);

            
            cnn.Parameters.AddWithValue("@RoomNo",int.Parse (textBox1.Text));

            cnn.Parameters.AddWithValue("@Type", comboBox1.Text);
            cnn.Parameters.AddWithValue("@Bed", comboBox2.Text);
            cnn.Parameters.AddWithValue("@Price", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@Available", comboBox3.Text);

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from AddRoomNEw", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            con.Open();


            SqlCommand cnn = new SqlCommand("update AddRoomNEw set RoomNo=@RoomNo,Type=@Type,Bed=@Bed,Price=@Price,Available=@Available where RoomNo=@RoomNo", con);

            cnn.Parameters.AddWithValue("@RoomNo", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Type", comboBox1.Text);
            cnn.Parameters.AddWithValue("@Bed", comboBox2.Text);
            cnn.Parameters.AddWithValue("@Available", comboBox3.Text);

            cnn.Parameters.AddWithValue("@Price", int.Parse(textBox2.Text));



            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3();
            f4.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //clear
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
           comboBox3.Text = string.Empty;
        }
    }
    }

