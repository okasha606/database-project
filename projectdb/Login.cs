using Project;

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
            var userInfo = authController.Login(email, password);

            if (userInfo.HasValue)
            {
                Console.WriteLine($"User ID: {userInfo.Value.UserId}, Role: {userInfo.Value.Role}"); // Debugging line to check
                // Store the User Id and Role in the global static class
                Session.UserId = userInfo.Value.UserId;
                Session.Role = userInfo.Value.Role;

                //MessageBox.Show($"Login successful! Welcome, {Session.Role}.");
                // Navigate to next screen
                if (userInfo.Value.Role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Hide();
                }
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
