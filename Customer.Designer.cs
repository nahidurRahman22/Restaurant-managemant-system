namespace Restaurant_Management_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblSearchBy = new Label();
            txtFoodPrice = new TextBox();
            txtQuantity = new TextBox();
            txtFoodName = new TextBox();
            txtFoodID = new TextBox();
            lblFoodPrice = new Label();
            lblQuantity = new Label();
            lblFoodName = new Label();
            lblFoodID = new Label();
            txtCustomerName = new TextBox();
            txtCustomerID = new TextBox();
            lblCustomerName = new Label();
            lblCustomerID = new Label();
            label1 = new Label();
            dgvMenuCategories = new DataGridView();
            txtTotalPrice = new TextBox();
            lblTotalPrice = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvOrderSummary = new DataGridView();
            lblMenuCategories = new Label();
            lblOrderSummary = new Label();
            cmbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMenuCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(318, 197);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(132, 23);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(253, 202);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(49, 16);
            lblSearch.TabIndex = 27;
            lblSearch.Text = "Search";
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.BackColor = Color.Transparent;
            lblSearchBy.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.ForeColor = Color.Black;
            lblSearchBy.Location = new Point(13, 202);
            lblSearchBy.Margin = new Padding(2, 0, 2, 0);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(68, 16);
            lblSearchBy.TabIndex = 26;
            lblSearchBy.Text = "Search By";
            // 
            // txtFoodPrice
            // 
            txtFoodPrice.Location = new Point(561, 57);
            txtFoodPrice.Margin = new Padding(2, 2, 2, 2);
            txtFoodPrice.Name = "txtFoodPrice";
            txtFoodPrice.Size = new Size(132, 23);
            txtFoodPrice.TabIndex = 25;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(561, 91);
            txtQuantity.Margin = new Padding(2, 2, 2, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(132, 23);
            txtQuantity.TabIndex = 24;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(178, 159);
            txtFoodName.Margin = new Padding(2, 2, 2, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(248, 23);
            txtFoodName.TabIndex = 23;
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new Point(178, 123);
            txtFoodID.Margin = new Padding(2, 2, 2, 2);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new Size(248, 23);
            txtFoodID.TabIndex = 22;
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.BackColor = Color.Transparent;
            lblFoodPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodPrice.ForeColor = Color.Black;
            lblFoodPrice.Location = new Point(447, 57);
            lblFoodPrice.Margin = new Padding(2, 0, 2, 0);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(83, 19);
            lblFoodPrice.TabIndex = 21;
            lblFoodPrice.Text = "FoodPrice";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(447, 91);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(74, 19);
            lblQuantity.TabIndex = 20;
            lblQuantity.Text = "Quantity";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Location = new Point(28, 159);
            lblFoodName.Margin = new Padding(2, 0, 2, 0);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(87, 19);
            lblFoodName.TabIndex = 19;
            lblFoodName.Text = "FoodName";
            // 
            // lblFoodID
            // 
            lblFoodID.AutoSize = true;
            lblFoodID.BackColor = Color.Transparent;
            lblFoodID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodID.ForeColor = Color.Black;
            lblFoodID.Location = new Point(28, 123);
            lblFoodID.Margin = new Padding(2, 0, 2, 0);
            lblFoodID.Name = "lblFoodID";
            lblFoodID.Size = new Size(62, 19);
            lblFoodID.TabIndex = 18;
            lblFoodID.Text = "FoodID";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(178, 93);
            txtCustomerName.Margin = new Padding(2, 2, 2, 2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(248, 23);
            txtCustomerName.TabIndex = 33;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(178, 57);
            txtCustomerID.Margin = new Padding(2, 2, 2, 2);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(248, 23);
            txtCustomerID.TabIndex = 32;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(28, 93);
            lblCustomerName.Margin = new Padding(2, 0, 2, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(121, 19);
            lblCustomerName.TabIndex = 31;
            lblCustomerName.Text = "CustomerName";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.ForeColor = Color.Black;
            lblCustomerID.Location = new Point(28, 57);
            lblCustomerID.Margin = new Padding(2, 0, 2, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(96, 19);
            lblCustomerID.TabIndex = 30;
            lblCustomerID.Text = "CustomerID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 27);
            label1.TabIndex = 34;
            label1.Text = "Customer Order Panel";
            // 
            // dgvMenuCategories
            // 
            dgvMenuCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuCategories.Location = new Point(22, 255);
            dgvMenuCategories.Margin = new Padding(2, 2, 2, 2);
            dgvMenuCategories.Name = "dgvMenuCategories";
            dgvMenuCategories.RowHeadersWidth = 62;
            dgvMenuCategories.Size = new Size(410, 130);
            dgvMenuCategories.TabIndex = 35;
            dgvMenuCategories.DoubleClick += dgvMenuCategories_DoubleClick;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(561, 123);
            txtTotalPrice.Margin = new Padding(2, 2, 2, 2);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(132, 23);
            txtTotalPrice.TabIndex = 37;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(447, 123);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(85, 19);
            lblTotalPrice.TabIndex = 36;
            lblTotalPrice.Text = "TotalPrice";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.ForestGreen;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(747, 100);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 33);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateGray;
            btnClear.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(747, 64);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 33);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(654, 172);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 33);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(530, 172);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 33);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvOrderSummary
            // 
            dgvOrderSummary.BackgroundColor = SystemColors.ButtonFace;
            dgvOrderSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderSummary.Location = new Point(461, 255);
            dgvOrderSummary.Margin = new Padding(2, 2, 2, 2);
            dgvOrderSummary.Name = "dgvOrderSummary";
            dgvOrderSummary.RowHeadersWidth = 62;
            dgvOrderSummary.Size = new Size(386, 130);
            dgvOrderSummary.TabIndex = 43;
            dgvOrderSummary.DoubleClick += dgvOrderSummary_DoubleClick;
            // 
            // lblMenuCategories
            // 
            lblMenuCategories.AutoSize = true;
            lblMenuCategories.BackColor = Color.Transparent;
            lblMenuCategories.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuCategories.ForeColor = Color.Black;
            lblMenuCategories.Location = new Point(160, 235);
            lblMenuCategories.Margin = new Padding(2, 0, 2, 0);
            lblMenuCategories.Name = "lblMenuCategories";
            lblMenuCategories.Size = new Size(131, 19);
            lblMenuCategories.TabIndex = 44;
            lblMenuCategories.Text = "Menu Categories";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.BackColor = Color.Transparent;
            lblOrderSummary.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderSummary.ForeColor = Color.Black;
            lblOrderSummary.Location = new Point(584, 235);
            lblOrderSummary.Margin = new Padding(2, 0, 2, 0);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(126, 19);
            lblOrderSummary.TabIndex = 45;
            lblOrderSummary.Text = "Order Summary";
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "FoodID", "FoodName" });
            cmbSearchBy.Location = new Point(104, 200);
            cmbSearchBy.Margin = new Padding(2, 2, 2, 2);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(129, 23);
            cmbSearchBy.TabIndex = 46;
            cmbSearchBy.SelectedIndexChanged += cmbSearchBy_SelectedIndexChanged;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(865, 386);
            Controls.Add(cmbSearchBy);
            Controls.Add(lblOrderSummary);
            Controls.Add(lblMenuCategories);
            Controls.Add(dgvOrderSummary);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalPrice);
            Controls.Add(lblTotalPrice);
            Controls.Add(dgvMenuCategories);
            Controls.Add(label1);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerID);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerID);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblSearchBy);
            Controls.Add(txtFoodPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(lblFoodPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblFoodName);
            Controls.Add(lblFoodID);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dgvMenuCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblSearchBy;
        private TextBox txtFoodPrice;
        private TextBox txtQuantity;
        private TextBox txtFoodName;
        private TextBox txtFoodID;
        private Label lblFoodPrice;
        private Label lblQuantity;
        private Label lblFoodName;
        private Label lblFoodID;
        private TextBox txtCustomerName;
        private TextBox txtCustomerID;
        private Label lblCustomerName;
        private Label lblCustomerID;
        private Label label1;
        private DataGridView dgvMenuCategories;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private Button btnBack;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvOrderSummary;
        private Label lblMenuCategories;
        private Label lblOrderSummary;
        private ComboBox cmbSearchBy;
    }
}