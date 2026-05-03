namespace projectdb
{
    partial class search
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
            comboFilterType = new ComboBox();
            txtSearchInput = new TextBox();
            lblFilterBy = new Label();
            dataGridViewResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // comboFilterType
            // 
            comboFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilterType.FormattingEnabled = true;
            comboFilterType.Items.AddRange(new object[] { "Product", "Vendor", "Category" });
            comboFilterType.Location = new Point(116, 12);
            comboFilterType.Name = "comboFilterType";
            comboFilterType.Size = new Size(151, 28);
            comboFilterType.TabIndex = 0;
            comboFilterType.SelectedIndexChanged += comboFilterType_SelectedIndexChanged;
            // 
            // txtSearchInput
            // 
            txtSearchInput.Location = new Point(283, 13);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.Size = new Size(250, 27);
            txtSearchInput.TabIndex = 1;
            txtSearchInput.TextChanged += txtSearchInput_TextChanged;
            // 
            // lblFilterBy
            // 
            lblFilterBy.AutoSize = true;
            lblFilterBy.Location = new Point(12, 16);
            lblFilterBy.Name = "lblFilterBy";
            lblFilterBy.Size = new Size(65, 20);
            lblFilterBy.TabIndex = 2;
            lblFilterBy.Text = "Filter By:";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(12, 60);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewResults.Size = new Size(776, 378);
            dataGridViewResults.TabIndex = 3;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewResults);
            Controls.Add(lblFilterBy);
            Controls.Add(txtSearchInput);
            Controls.Add(comboFilterType);
            Name = "search";
            Text = "Smart Inventory Search";
            Load += search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboFilterType;
        private TextBox txtSearchInput;
        private Label lblFilterBy;
        private DataGridView dataGridViewResults;
    }
}
