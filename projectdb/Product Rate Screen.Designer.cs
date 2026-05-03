namespace projectdb
{
    partial class Product_Rate_Screen
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
            submitReview = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblReviewPreview = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // submitReview
            // 
            submitReview.Location = new Point(656, 394);
            submitReview.Name = "submitReview";
            submitReview.Size = new Size(94, 29);
            submitReview.TabIndex = 1;
            submitReview.Text = "submit";
            submitReview.UseVisualStyleBackColor = true;
            submitReview.Click += submitReview_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(2, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 172);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 181);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "Rate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "Review :";
            // 
            // lblReviewPreview
            // 
            lblReviewPreview.AutoSize = true;
            lblReviewPreview.Location = new Point(2, 370);
            lblReviewPreview.Name = "lblReviewPreview";
            lblReviewPreview.Size = new Size(0, 20);
            lblReviewPreview.TabIndex = 6;
            // 
            // Product_Rate_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblReviewPreview);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(submitReview);
            Name = "Product_Rate_Screen";
            Text = "Product Rate";
            Load += Product_Rate_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitReview;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label lblReviewPreview;
    }
}