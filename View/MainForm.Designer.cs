namespace NHibernateExample {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClients = new Button();
            btnBooks = new Button();
            pClients = new Panel();
            vSearchEmail = new TextBox();
            vSearchLastName = new TextBox();
            vSearchFirstName = new TextBox();
            btnAddClient = new Button();
            dgvClients = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Manage = new DataGridViewButtonColumn();
            Borrows = new DataGridViewTextBoxColumn();
            pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Location = new Point(38, 29);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(121, 23);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clients";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(626, 29);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(121, 23);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // pClients
            // 
            pClients.Controls.Add(vSearchEmail);
            pClients.Controls.Add(vSearchLastName);
            pClients.Controls.Add(vSearchFirstName);
            pClients.Controls.Add(btnAddClient);
            pClients.Controls.Add(dgvClients);
            pClients.Location = new Point(12, 58);
            pClients.Name = "pClients";
            pClients.Size = new Size(776, 380);
            pClients.TabIndex = 2;
            // 
            // vSearchEmail
            // 
            vSearchEmail.Location = new Point(490, 73);
            vSearchEmail.Name = "vSearchEmail";
            vSearchEmail.Size = new Size(188, 23);
            vSearchEmail.TabIndex = 4;
            vSearchEmail.TextChanged += vSearch_TextChanged;
            // 
            // vSearchLastName
            // 
            vSearchLastName.Location = new Point(306, 73);
            vSearchLastName.Name = "vSearchLastName";
            vSearchLastName.Size = new Size(178, 23);
            vSearchLastName.TabIndex = 3;
            vSearchLastName.TextChanged += vSearch_TextChanged;
            // 
            // vSearchFirstName
            // 
            vSearchFirstName.Location = new Point(120, 73);
            vSearchFirstName.Name = "vSearchFirstName";
            vSearchFirstName.Size = new Size(180, 23);
            vSearchFirstName.TabIndex = 2;
            vSearchFirstName.TextChanged += vSearch_TextChanged;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(3, 73);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(111, 23);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { ID, FirstName, LastName, Email, Manage, Borrows });
            dgvClients.Location = new Point(3, 98);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(770, 279);
            dgvClients.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 40F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Manage
            // 
            Manage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            Manage.DefaultCellStyle = dataGridViewCellStyle2;
            Manage.FillWeight = 50F;
            Manage.HeaderText = "Manage";
            Manage.Name = "Manage";
            Manage.ReadOnly = true;
            Manage.Text = "Manage";
            Manage.ToolTipText = "Manage";
            Manage.UseColumnTextForButtonValue = true;
            // 
            // Borrows
            // 
            Borrows.DataPropertyName = "Borrows";
            Borrows.HeaderText = "Borrows";
            Borrows.Name = "Borrows";
            Borrows.ReadOnly = true;
            Borrows.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pClients);
            Controls.Add(btnBooks);
            Controls.Add(btnClients);
            Name = "MainForm";
            Text = "Form1";
            pClients.ResumeLayout(false);
            pClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClients;
        private Button btnBooks;
        private Panel pClients;
        private DataGridView dgvClients;
        private Button btnAddClient;
        private TextBox vSearchFirstName;
        private TextBox vSearchLastName;
        private TextBox vSearchEmail;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Manage;
        private DataGridViewTextBoxColumn Borrows;
    }
}