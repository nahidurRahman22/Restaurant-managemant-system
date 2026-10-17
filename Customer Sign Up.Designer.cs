namespace Restaurant_Management_System
{
    partial class Customer_Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Sign_Up));
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            txtCustomerName = new TextBox();
            lblUserID = new Label();
            lblPassword = new Label();
            lblCustomerName = new Label();
            label1 = new Label();
            label2 = new Label();
            btnSignup = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(385, 149);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(204, 23);
            txtUserID.TabIndex = 24;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(385, 184);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 23);
            txtPassword.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(385, 116);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(204, 23);
            txtCustomerName.TabIndex = 21;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.Black;
            lblUserID.Location = new Point(307, 151);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(63, 19);
            lblUserID.TabIndex = 18;
            lblUserID.Text = "User ID";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(289, 185);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 19);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Password";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.Black;
            lblCustomerName.Location = new Point(244, 116);
            lblCustomerName.Margin = new Padding(2, 0, 2, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(121, 19);
            lblCustomerName.TabIndex = 15;
            lblCustomerName.Text = "CustomerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(385, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 27);
            label1.TabIndex = 14;
            label1.Text = " AIUB Restaurant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(439, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 25;
            label2.Text = "Welcome to";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.RoyalBlue;
            btnSignup.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.Transparent;
            btnSignup.Location = new Point(385, 234);
            btnSignup.Margin = new Padding(2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(83, 33);
            btnSignup.TabIndex = 26;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Brown;
            btnBack.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(505, 234);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(83, 33);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Customer_Sign_Up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(628, 344);
            Controls.Add(btnBack);
            Controls.Add(btnSignup);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(txtPassword);
            Controls.Add(txtCustomerName);
            Controls.Add(lblUserID);
            Controls.Add(lblPassword);
            Controls.Add(lblCustomerName);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Customer_Sign_Up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Sign_Up";
            Load += Customer_Sign_Up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserID;
        private TextBox txtPassword;
        private TextBox txtCustomerName;
        private Label lblUserID;
        private Label lblPassword;
        private Label lblCustomerName;
        private Label label1;
        private Label label2;
        private Button btnSignup;
        private Button btnBack;
    }
}