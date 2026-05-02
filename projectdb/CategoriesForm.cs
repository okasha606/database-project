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
    public partial class CategoriesForm : Form
    {
        private projectdb.DatabaseService _dbService = new projectdb.DatabaseService();

        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // Fetching from the Category table
            string query = "SELECT * FROM Category";

            using (SqlConnection con = _dbService.GetConnection())
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
                    MessageBox.Show("Error loading Categories: " + ex.Message);
                }
            }
        }
    }
}
