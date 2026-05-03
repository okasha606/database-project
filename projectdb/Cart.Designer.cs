namespace projectdb
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnconfirmorder = new Button();
            dataGridView1 = new DataGridView();
            btnRemove = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnconfirmorder
            // 
            btnconfirmorder.BackColor = Color.LightGreen;
            btnconfirmorder.Location = new Point(607, 130);
            btnconfirmorder.Name = "btnconfirmorder";
            btnconfirmorder.Size = new Size(142, 29);
            btnconfirmorder.TabIndex = 0;
            btnconfirmorder.Text = "Confirm Order";
            btnconfirmorder.UseVisualStyleBackColor = false;
            btnconfirmorder.Click += btnconfirmorder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(546, 367);
            dataGridView1.TabIndex = 1;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(607, 328);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(142, 30);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(607, 97);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: $0.00";
            lblTotal.Click += label1_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(btnconfirmorder);
            Name = "Cart";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirmorder;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private Label lblTotal;
    }
}