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
            panel1 = new Panel();
            vEmail = new TextBox();
            label3 = new Label();
            vLastName = new TextBox();
            label2 = new Label();
            vFirstName = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            dgvBorrowedBooks = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(vEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(vLastName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(vFirstName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(17, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 150);
            panel1.TabIndex = 0;
            // 
            // vEmail
            // 
            vEmail.Location = new Point(12, 115);
            vEmail.Name = "vEmail";
            vEmail.Size = new Size(269, 23);
            vEmail.TabIndex = 5;
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
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(17, 269);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowTemplate.Height = 25;
            dgvBorrowedBooks.Size = new Size(758, 150);
            dgvBorrowedBooks.TabIndex = 2;
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
    }
}