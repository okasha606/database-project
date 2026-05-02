namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vendors = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Vendors
            // 
            Vendors.Location = new Point(154, 171);
            Vendors.Name = "Vendors";
            Vendors.Size = new Size(165, 68);
            Vendors.TabIndex = 0;
            Vendors.Text = "Vendors";
            Vendors.UseVisualStyleBackColor = true;
            Vendors.Click += Vendors_Click;
            // 
            // button1
            // 
            button1.Location = new Point(433, 175);
            button1.Name = "button1";
            button1.Size = new Size(162, 64);
            button1.TabIndex = 1;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(157, 310);
            button2.Name = "button2";
            button2.Size = new Size(162, 64);
            button2.TabIndex = 2;
            button2.Text = "Products ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 310);
            button3.Name = "button3";
            button3.Size = new Size(162, 64);
            button3.TabIndex = 3;
            button3.Text = "Categories ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(36, 32);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 79);
            textBox1.TabIndex = 4;
            textBox1.Text = "Hello sir ,";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Vendors);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Vendors;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
    }
}
