namespace Restaurant_Management_System
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            lblBillingAndPaymentPanel = new Label();
            dgvBillAndPaymentPanel = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchBy = new Label();
            btnGenerateBill = new Button();
            btnBack = new Button();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBillAndPaymentPanel).BeginInit();
            SuspendLayout();
            // 
            // lblBillingAndPaymentPanel
            // 
            lblBillingAndPaymentPanel.AutoSize = true;
            lblBillingAndPaymentPanel.BackColor = Color.Transparent;
            lblBillingAndPaymentPanel.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBillingAndPaymentPanel.Location = new Point(197, 12);
            lblBillingAndPaymentPanel.Margin = new Padding(2, 0, 2, 0);
            lblBillingAndPaymentPanel.Name = "lblBillingAndPaymentPanel";
            lblBillingAndPaymentPanel.Size = new Size(295, 27);
            lblBillingAndPaymentPanel.TabIndex = 2;
            lblBillingAndPaymentPanel.Text = "Billing And Payment Panel";
            // 
            // dgvBillAndPaymentPanel
            // 
            dgvBillAndPaymentPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillAndPaymentPanel.Location = new Point(36, 50);
            dgvBillAndPaymentPanel.Margin = new Padding(2, 2, 2, 2);
            dgvBillAndPaymentPanel.Name = "dgvBillAndPaymentPanel";
            dgvBillAndPaymentPanel.RowHeadersWidth = 62;
            dgvBillAndPaymentPanel.Size = new Size(595, 135);
            dgvBillAndPaymentPanel.TabIndex = 3;
            dgvBillAndPaymentPanel.DoubleClick += dgvBillAndPaymentPanel_DoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 260);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 23);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(87, 244);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(49, 16);
            lblSearch.TabIndex = 19;
            lblSearch.Text = "Search";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(74, 200);
            lblSearchBy.Margin = new Padding(2, 0, 2, 0);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(68, 16);
            lblSearchBy.TabIndex = 18;
            lblSearchBy.Text = "Search By";
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.Brown;
            btnGenerateBill.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateBill.ForeColor = Color.Transparent;
            btnGenerateBill.Location = new Point(490, 206);
            btnGenerateBill.Margin = new Padding(2, 2, 2, 2);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(141, 33);
            btnGenerateBill.TabIndex = 22;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(548, 260);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 33);
            btnBack.TabIndex = 25;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "CustomerID", "CustomerName" });
            cmbSearchBy.Location = new Point(36, 216);
            cmbSearchBy.Margin = new Padding(2, 2, 2, 2);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(150, 23);
            cmbSearchBy.TabIndex = 26;
            cmbSearchBy.SelectedIndexChanged += cmbSearchBy_SelectedIndexChanged;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(675, 296);
            Controls.Add(cmbSearchBy);
            Controls.Add(btnBack);
            Controls.Add(btnGenerateBill);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(dgvBillAndPaymentPanel);
            Controls.Add(lblBillingAndPaymentPanel);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillAndPaymentPanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBillingAndPaymentPanel;
        private DataGridView dgvBillAndPaymentPanel;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchBy;
        private Button btnGenerateBill;
        private Button btnBack;
        private ComboBox cmbSearchBy;
    }
}