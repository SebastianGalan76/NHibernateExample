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
            btnClients = new Button();
            btnBooks = new Button();
            pClients = new Panel();
            vSearchLastName = new TextBox();
            vSearchFirstName = new TextBox();
            btnAddClient = new Button();
            dgvClients = new DataGridView();
            vSearchEmail = new TextBox();
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
            // vSearchLastName
            // 
            vSearchLastName.Location = new Point(336, 73);
            vSearchLastName.Name = "vSearchLastName";
            vSearchLastName.Size = new Size(138, 23);
            vSearchLastName.TabIndex = 3;
            vSearchLastName.TextChanged += vSearch_TextChanged;
            // 
            // vSearchFirstName
            // 
            vSearchFirstName.Location = new Point(187, 73);
            vSearchFirstName.Name = "vSearchFirstName";
            vSearchFirstName.Size = new Size(143, 23);
            vSearchFirstName.TabIndex = 2;
            vSearchFirstName.TextChanged += vSearch_TextChanged;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(630, 98);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(135, 23);
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
            dgvClients.Location = new Point(3, 98);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(621, 279);
            dgvClients.TabIndex = 0;
            // 
            // vSearchEmail
            // 
            vSearchEmail.Location = new Point(480, 74);
            vSearchEmail.Name = "vSearchEmail";
            vSearchEmail.Size = new Size(144, 23);
            vSearchEmail.TabIndex = 4;
            vSearchEmail.TextChanged += vSearch_TextChanged;
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
    }
}