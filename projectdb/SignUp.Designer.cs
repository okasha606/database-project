namespace projectdb
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(350, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(450, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 31);
            txtName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(350, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(450, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(350, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(450, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 5;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(450, 250);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 40);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(550, 250);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(130, 40);
            btnBackToLogin.TabIndex = 7;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 614);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Button btnBackToLogin;
    }
}