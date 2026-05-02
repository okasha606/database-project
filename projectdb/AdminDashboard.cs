using Microsoft.Data.SqlClient;
using System.Data;




namespace Project
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersForm usersScreen = new UsersForm();
            usersScreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vendors_Click(object sender, EventArgs e)
        {
            VendorsForm vendorsScreen = new VendorsForm();
            vendorsScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }
    }
}
