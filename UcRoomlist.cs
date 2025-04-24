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
    public partial class UcRoomlist : UserControl
    {
        public UcRoomlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-4JHKCBSK\SQLEXPRESS01;Initial Catalog=cmblogin;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from AddRoomNEw", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView2.DataSource = table;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
