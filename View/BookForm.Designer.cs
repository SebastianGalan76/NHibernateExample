namespace NHibernateExample.View {
    partial class BookForm {
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
            cbAvailable = new CheckBox();
            label4 = new Label();
            tvAuthor = new Label();
            tvTitle = new Label();
            tvISBN = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cbAvailable);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tvAuthor);
            panel1.Controls.Add(tvTitle);
            panel1.Controls.Add(tvISBN);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 193);
            panel1.TabIndex = 0;
            // 
            // cbAvailable
            // 
            cbAvailable.AutoSize = true;
            cbAvailable.Enabled = false;
            cbAvailable.Location = new Point(81, 157);
            cbAvailable.Name = "cbAvailable";
            cbAvailable.Size = new Size(15, 14);
            cbAvailable.TabIndex = 7;
            cbAvailable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 156);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Available";
            // 
            // tvAuthor
            // 
            tvAuthor.AutoSize = true;
            tvAuthor.Location = new Point(20, 124);
            tvAuthor.Name = "tvAuthor";
            tvAuthor.Size = new Size(38, 15);
            tvAuthor.TabIndex = 5;
            tvAuthor.Text = "label4";
            // 
            // tvTitle
            // 
            tvTitle.AutoSize = true;
            tvTitle.Location = new Point(20, 76);
            tvTitle.Name = "tvTitle";
            tvTitle.Size = new Size(38, 15);
            tvTitle.TabIndex = 4;
            tvTitle.Text = "label4";
            // 
            // tvISBN
            // 
            tvISBN.AutoSize = true;
            tvISBN.Location = new Point(20, 25);
            tvISBN.Name = "tvISBN";
            tvISBN.Size = new Size(38, 15);
            tvISBN.TabIndex = 3;
            tvISBN.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(702, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(panel1);
            Name = "BookForm";
            Text = "BookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label tvISBN;
        private CheckBox cbAvailable;
        private Label label4;
        private Label tvAuthor;
        private Label tvTitle;
        private Button btnDelete;
    }
}