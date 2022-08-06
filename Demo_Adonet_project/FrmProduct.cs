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

namespace Demo_Adonet_project
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-O6Q5UAT;Initial Catalog=DbistanbulAkademi; User Id=sa;Password=1234;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable DataTable = new DataTable();
            adapter.Fill(DataTable);
            dataGridView1.DataSource = DataTable;


            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
