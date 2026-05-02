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
            // Add login logic here
            MessageBox.Show("Login clicked");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
