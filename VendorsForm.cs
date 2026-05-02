using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class VendorsForm : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True";

        public VendorsForm()
        {
            InitializeComponent();
        }

        private void VendorsForm_Load(object sender, EventArgs e)
        {
            // Fetching from the Vendor table
            string query = "SELECT * FROM Vendor";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Vendors: " + ex.Message);
                }
            }
        }
    }
}
