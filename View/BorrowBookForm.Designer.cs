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
            dgvAvailableBooks = new DataGridView();
            ISBN = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.AllowUserToAddRows = false;
            dgvAvailableBooks.AllowUserToDeleteRows = false;
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.Columns.AddRange(new DataGridViewColumn[] { ISBN, Title, Author });
            dgvAvailableBooks.Location = new Point(12, 169);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.ReadOnly = true;
            dgvAvailableBooks.RowTemplate.Height = 25;
            dgvAvailableBooks.Size = new Size(776, 269);
            dgvAvailableBooks.TabIndex = 0;
            dgvAvailableBooks.CellClick += dgvAvailableBooks_SelectBookClick;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAvailableBooks);
            Name = "BorrowBookForm";
            Text = "BorrowBookForm";
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAvailableBooks;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
    }
}