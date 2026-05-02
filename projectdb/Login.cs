namespace projectdb
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            AuthenticationController authController = new AuthenticationController();
            if (authController.Login(email, password))
            {
                MessageBox.Show("Login successful!");
                // Navigate to next screen
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
