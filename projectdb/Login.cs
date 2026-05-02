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
            int? userId = authController.Login(email, password);

            if (userId.HasValue)
            {
                Console.WriteLine($"User ID: {userId.Value}"); // Debugging line to check the retrieved User IID
                // Store the User Id in the global static class
                Session.UserId = userId.Value;

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
