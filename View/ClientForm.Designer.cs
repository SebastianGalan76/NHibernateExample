using System.Windows.Forms;
using System;

namespace NHibernateExample.View {
    partial class ClientForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCancelChanges = new Button();
            btnSaveChanges = new Button();
            vEmail = new TextBox();
            label3 = new Label();
            vLastName = new TextBox();
            label2 = new Label();
            vFirstName = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            dgvBorrowedBooks = new DataGridView();
            ISBN = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            BorrowDate = new DataGridViewTextBoxColumn();
            Return = new DataGridViewButtonColumn();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnCancelChanges);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Controls.Add(vEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(vLastName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(vFirstName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 188);
            panel1.TabIndex = 0;
            // 
            // btnCancelChanges
            // 
            btnCancelChanges.Location = new Point(146, 144);
            btnCancelChanges.Name = "btnCancelChanges";
            btnCancelChanges.Size = new Size(135, 23);
            btnCancelChanges.TabIndex = 7;
            btnCancelChanges.Text = "Cancel";
            btnCancelChanges.UseVisualStyleBackColor = true;
            btnCancelChanges.Visible = false;
            btnCancelChanges.Click += btnCancelChanges_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(12, 144);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(128, 23);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Visible = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // vEmail
            // 
            vEmail.Location = new Point(12, 115);
            vEmail.Name = "vEmail";
            vEmail.Size = new Size(269, 23);
            vEmail.TabIndex = 5;
            vEmail.TextChanged += vData_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // vLastName
            // 
            vLastName.Location = new Point(12, 71);
            vLastName.Name = "vLastName";
            vLastName.Size = new Size(269, 23);
            vLastName.TabIndex = 3;
            vLastName.TextChanged += vData_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // vFirstName
            // 
            vFirstName.Location = new Point(12, 27);
            vFirstName.Name = "vFirstName";
            vFirstName.Size = new Size(269, 23);
            vFirstName.TabIndex = 1;
            vFirstName.TextChanged += vData_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(700, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Client";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Columns.AddRange(new DataGridViewColumn[] { ISBN, Title, Author, BorrowDate, Return });
            dgvBorrowedBooks.Location = new Point(17, 269);
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowTemplate.Height = 25;
            dgvBorrowedBooks.Size = new Size(758, 150);
            dgvBorrowedBooks.TabIndex = 2;
            dgvBorrowedBooks.CellContentClick += dgvBorrowedBooks_ManageClientClick;
            dgvBorrowedBooks.CellFormatting += dgvBorrowedBooks_CellFormatting;
            // 
            // ISBN
            // 
            ISBN.DataPropertyName = "ISBN";
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.DataPropertyName = "Book.Author";
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // BorrowDate
            // 
            BorrowDate.DataPropertyName = "BorrowDate";
            BorrowDate.HeaderText = "Borrow Date";
            BorrowDate.Name = "BorrowDate";
            BorrowDate.ReadOnly = true;
            // 
            // Return
            // 
            Return.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            Return.DefaultCellStyle = dataGridViewCellStyle1;
            Return.FillWeight = 50F;
            Return.HeaderText = "Return";
            Return.Name = "Return";
            Return.ReadOnly = true;
            Return.Text = "Return";
            Return.ToolTipText = "Return book";
            Return.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 242);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Borrowed books";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dgvBorrowedBooks);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Name = "ClientForm";
            Text = "ClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox vEmail;
        private Label label3;
        private TextBox vLastName;
        private Label label2;
        private TextBox vFirstName;
        private Label label1;
        private Button btnDelete;
        private DataGridView dgvBorrowedBooks;
        private Label label4;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn BorrowDate;
        private DataGridViewButtonColumn Return;
        private Button btnCancelChanges;
        private Button btnSaveChanges;
    }
}