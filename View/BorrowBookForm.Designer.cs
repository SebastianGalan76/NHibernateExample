using System.Windows.Forms;

namespace NHibernateExample.View {
    partial class BorrowBookForm {
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
            dgvAvailableBooks = new DataGridView();
            vSearchISBN = new TextBox();
            vSearchTitle = new TextBox();
            vSearchAuthor = new TextBox();
            ISBN = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Borrow = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.AllowUserToAddRows = false;
            dgvAvailableBooks.AllowUserToDeleteRows = false;
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.Columns.AddRange(new DataGridViewColumn[] { ISBN, Title, Author, Borrow });
            dgvAvailableBooks.Location = new Point(12, 169);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.ReadOnly = true;
            dgvAvailableBooks.RowTemplate.Height = 25;
            dgvAvailableBooks.Size = new Size(776, 269);
            dgvAvailableBooks.TabIndex = 0;
            dgvAvailableBooks.CellClick += dgvAvailableBooks_SelectBookClick;
            // 
            // vSearchISBN
            // 
            vSearchISBN.Location = new Point(55, 144);
            vSearchISBN.Name = "vSearchISBN";
            vSearchISBN.Size = new Size(210, 23);
            vSearchISBN.TabIndex = 1;
            vSearchISBN.TextChanged += search_TextChanged;
            // 
            // vSearchTitle
            // 
            vSearchTitle.Location = new Point(271, 144);
            vSearchTitle.Name = "vSearchTitle";
            vSearchTitle.Size = new Size(209, 23);
            vSearchTitle.TabIndex = 2;
            vSearchTitle.TextChanged += search_TextChanged;
            // 
            // vSearchAuthor
            // 
            vSearchAuthor.Location = new Point(486, 144);
            vSearchAuthor.Name = "vSearchAuthor";
            vSearchAuthor.Size = new Size(209, 23);
            vSearchAuthor.TabIndex = 3;
            vSearchAuthor.TextChanged += search_TextChanged;
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
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Borrow
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.ForeColor = Color.Gray;
            Borrow.DefaultCellStyle = dataGridViewCellStyle1;
            Borrow.FillWeight = 40F;
            Borrow.HeaderText = "Borrow";
            Borrow.Name = "Borrow";
            Borrow.ReadOnly = true;
            Borrow.Text = "Borrow";
            Borrow.ToolTipText = "Borrow";
            Borrow.UseColumnTextForButtonValue = true;
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vSearchAuthor);
            Controls.Add(vSearchTitle);
            Controls.Add(vSearchISBN);
            Controls.Add(dgvAvailableBooks);
            Name = "BorrowBookForm";
            Text = "BorrowBookForm";
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAvailableBooks;
        private TextBox vSearchISBN;
        private TextBox vSearchTitle;
        private TextBox vSearchAuthor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewButtonColumn Borrow;
    }
}