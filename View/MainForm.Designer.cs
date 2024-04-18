using NHibernateExample.Models;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnClients = new Button();
            btnBooks = new Button();
            pClients = new Panel();
            vSearchEmail = new TextBox();
            vSearchLastName = new TextBox();
            vSearchFirstName = new TextBox();
            btnAddClient = new Button();
            dgvClients = new DataGridView();
            Client_Manage = new DataGridViewButtonColumn();
            pBooks = new Panel();
            btnAddBook = new Button();
            dgvBooks = new DataGridView();
            Book_ID = new DataGridViewTextBoxColumn();
            Book_ISBN = new DataGridViewTextBoxColumn();
            Book_Title = new DataGridViewTextBoxColumn();
            Book_Author = new DataGridViewTextBoxColumn();
            Book_Available = new DataGridViewCheckBoxColumn();
            Book_Manage = new DataGridViewButtonColumn();
            pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            pBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
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
            btnBooks.Click += btnBooks_Click;
            // 
            // pClients
            // 
            pClients.BackColor = SystemColors.Control;
            pClients.Controls.Add(vSearchEmail);
            pClients.Controls.Add(vSearchLastName);
            pClients.Controls.Add(vSearchFirstName);
            pClients.Controls.Add(btnAddClient);
            pClients.Controls.Add(dgvClients);
            pClients.Location = new Point(12, 58);
            pClients.Name = "pClients";
            pClients.Size = new Size(776, 380);
            pClients.TabIndex = 2;
            pClients.Visible = false;
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
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { Client_Manage });
            dgvClients.Location = new Point(3, 98);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(770, 279);
            dgvClients.TabIndex = 0;
            dgvClients.CellContentClick += dgvClients_ManageClientClick;
            // 
            // Client_Manage
            // 
            Client_Manage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            Client_Manage.DefaultCellStyle = dataGridViewCellStyle1;
            Client_Manage.FillWeight = 50F;
            Client_Manage.HeaderText = "Manage";
            Client_Manage.Name = "Client_Manage";
            Client_Manage.ReadOnly = true;
            Client_Manage.Text = "Manage";
            Client_Manage.ToolTipText = "Manage";
            Client_Manage.UseColumnTextForButtonValue = true;
            // 
            // pBooks
            // 
            pBooks.BackColor = SystemColors.Control;
            pBooks.Controls.Add(btnAddBook);
            pBooks.Controls.Add(dgvBooks);
            pBooks.Location = new Point(12, 58);
            pBooks.Name = "pBooks";
            pBooks.Size = new Size(776, 380);
            pBooks.TabIndex = 5;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(3, 69);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Book_ID, Book_ISBN, Book_Title, Book_Author, Book_Available, Book_Manage });
            dgvBooks.Location = new Point(3, 98);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new Size(770, 279);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellContentClick += dgvBooks_ManageBookClick;
            dgvBooks.CellFormatting += dgvBooks_CellFormatting;
            // 
            // Book_ID
            // 
            Book_ID.DataPropertyName = "ID";
            Book_ID.FillWeight = 40F;
            Book_ID.HeaderText = "ID";
            Book_ID.Name = "Book_ID";
            Book_ID.ReadOnly = true;
            // 
            // Book_ISBN
            // 
            Book_ISBN.DataPropertyName = "ISBN";
            Book_ISBN.FillWeight = 70F;
            Book_ISBN.HeaderText = "ISBN";
            Book_ISBN.Name = "Book_ISBN";
            Book_ISBN.ReadOnly = true;
            // 
            // Book_Title
            // 
            Book_Title.DataPropertyName = "Title";
            Book_Title.FillWeight = 120F;
            Book_Title.HeaderText = "Title";
            Book_Title.Name = "Book_Title";
            Book_Title.ReadOnly = true;
            // 
            // Book_Author
            // 
            Book_Author.DataPropertyName = "Author";
            Book_Author.HeaderText = "Author";
            Book_Author.Name = "Book_Author";
            Book_Author.ReadOnly = true;
            // 
            // Book_Available
            // 
            Book_Available.FillWeight = 50F;
            Book_Available.HeaderText = "Available";
            Book_Available.Name = "Book_Available";
            Book_Available.ReadOnly = true;
            // 
            // Book_Manage
            // 
            Book_Manage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            Book_Manage.DefaultCellStyle = dataGridViewCellStyle2;
            Book_Manage.FillWeight = 50F;
            Book_Manage.HeaderText = "Manage";
            Book_Manage.Name = "Book_Manage";
            Book_Manage.ReadOnly = true;
            Book_Manage.Text = "Manage";
            Book_Manage.ToolTipText = "Manage";
            Book_Manage.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pBooks);
            Controls.Add(pClients);
            Controls.Add(btnBooks);
            Controls.Add(btnClients);
            Name = "MainForm";
            Text = "Form1";
            pClients.ResumeLayout(false);
            pClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            pBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
        private DataGridViewTextBoxColumn Client_ID;
        private DataGridViewTextBoxColumn Client_FirstName;
        private DataGridViewTextBoxColumn Client_LastName;
        private DataGridViewTextBoxColumn Client_Email;
        private DataGridViewButtonColumn Client_Manage;
        private Panel pBooks;
        private DataGridView dgvBooks;
        private Button btnAddBook;
        private DataGridViewTextBoxColumn Book_ID;
        private DataGridViewTextBoxColumn Book_ISBN;
        private DataGridViewTextBoxColumn Book_Title;
        private DataGridViewTextBoxColumn Book_Author;
        private DataGridViewCheckBoxColumn Book_Available;
        private DataGridViewButtonColumn Book_Manage;
    }
}