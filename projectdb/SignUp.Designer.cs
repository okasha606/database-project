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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddressName = new Label();
            txtAddressName = new TextBox();
            lblLat = new Label();
            txtLat = new TextBox();
            lblLong = new Label();
            txtLong = new TextBox();
            btnSignUp = new Button();
            btnBackToLogin = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(350, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(480, 47);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 31);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(350, 100);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(480, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(350, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(480, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 31);
            txtEmail.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(350, 200);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(480, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 31);
            txtPassword.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(350, 250);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(480, 247);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 9;
            // 
            // lblAddressName
            // 
            lblAddressName.AutoSize = true;
            lblAddressName.Location = new Point(350, 300);
            lblAddressName.Name = "lblAddressName";
            lblAddressName.Size = new Size(131, 25);
            lblAddressName.TabIndex = 10;
            lblAddressName.Text = "Address Name:";
            // 
            // txtAddressName
            // 
            txtAddressName.Location = new Point(480, 297);
            txtAddressName.Name = "txtAddressName";
            txtAddressName.Size = new Size(200, 31);
            txtAddressName.TabIndex = 11;
            // 
            // lblLat
            // 
            lblLat.AutoSize = true;
            lblLat.Location = new Point(350, 350);
            lblLat.Name = "lblLat";
            lblLat.Size = new Size(79, 25);
            lblLat.TabIndex = 12;
            lblLat.Text = "Latitude:";
            // 
            // txtLat
            // 
            txtLat.Location = new Point(480, 347);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(200, 31);
            txtLat.TabIndex = 13;
            // 
            // lblLong
            // 
            lblLong.AutoSize = true;
            lblLong.Location = new Point(350, 400);
            lblLong.Name = "lblLong";
            lblLong.Size = new Size(96, 25);
            lblLong.TabIndex = 14;
            lblLong.Text = "Longitude:";
            // 
            // txtLong
            // 
            txtLong.Location = new Point(480, 397);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(200, 31);
            txtLong.TabIndex = 15;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(480, 460);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 40);
            btnSignUp.TabIndex = 16;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(580, 460);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(130, 40);
            btnBackToLogin.TabIndex = 17;
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
            Controls.Add(txtLong);
            Controls.Add(lblLong);
            Controls.Add(txtLat);
            Controls.Add(lblLat);
            Controls.Add(txtAddressName);
            Controls.Add(lblAddressName);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddressName;
        private TextBox txtAddressName;
        private Label lblLat;
        private TextBox txtLat;
        private Label lblLong;
        private TextBox txtLong;
        private Button btnSignUp;
        private Button btnBackToLogin;
    }
}