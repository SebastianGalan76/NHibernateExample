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
            panel1 = new Panel();
            btnAddClient = new Button();
            dgvClients = new DataGridView();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(btnAddClient);
            panel1.Controls.Add(dgvClients);
            panel1.Location = new Point(12, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 380);
            panel1.TabIndex = 2;
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
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(3, 98);
            dgvClients.Name = "dgvClients";
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(621, 279);
            dgvClients.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnBooks);
            Controls.Add(btnClients);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClients;
        private Button btnBooks;
        private Panel panel1;
        private DataGridView dgvClients;
        private Button btnAddClient;
    }
}