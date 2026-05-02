namespace projectdb
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Add sign up logic here
            MessageBox.Show("Account created successfully!");
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}