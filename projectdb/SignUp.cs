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
            AuthenticationController authController = new AuthenticationController();
            
            bool success = authController.CreateAccount(
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPassword.Text,
                txtPhone.Text,
                txtAddressName.Text,
                txtLat.Text,
                txtLong.Text
            );

            if (success)
            {
                MessageBox.Show("Account created successfully!");
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account. Please check your connection or database.");
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}