namespace Project
{
    partial class CategoryProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pnlHeader = new Panel();
            btnBack = new Button();
            lblHeader = new Label();
            pnlProducts = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(64, 64, 96);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 55);
            pnlHeader.TabIndex = 0;
            //
            // btnBack
            //
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(10, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 36);
            btnBack.TabIndex = 0;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // lblHeader
            //
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(120, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(120, 26);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Category";
            //
            // pnlProducts
            //
            pnlProducts.AutoScroll = true;
            pnlProducts.Dock = DockStyle.Fill;
            pnlProducts.Location = new Point(0, 55);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Padding = new Padding(10);
            pnlProducts.Size = new Size(1000, 665);
            pnlProducts.TabIndex = 1;
            //
            // CategoryProductsForm
            //
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 720);
            MinimumSize = new Size(940, 700);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(pnlProducts);
            Controls.Add(pnlHeader);
            Name = "CategoryProductsForm";
            Text = "Category";
            Load += CategoryProductsForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnBack;
        private Label lblHeader;
        private FlowLayoutPanel pnlProducts;
    }
}
