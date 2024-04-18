namespace NHibernateExample {
    partial class AddNewBookForm {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            vISBN = new TextBox();
            vTitle = new TextBox();
            vAuthor = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 89);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 167);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 234);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // vISBN
            // 
            vISBN.Location = new Point(338, 107);
            vISBN.Name = "vISBN";
            vISBN.Size = new Size(176, 23);
            vISBN.TabIndex = 3;
            // 
            // vTitle
            // 
            vTitle.Location = new Point(338, 185);
            vTitle.Name = "vTitle";
            vTitle.Size = new Size(176, 23);
            vTitle.TabIndex = 4;
            // 
            // vAuthor
            // 
            vAuthor.Location = new Point(338, 252);
            vAuthor.Name = "vAuthor";
            vAuthor.Size = new Size(176, 23);
            vAuthor.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(338, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(439, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddNewBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(vAuthor);
            Controls.Add(vTitle);
            Controls.Add(vISBN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewBookForm";
            Text = "AddNewClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox vISBN;
        private TextBox vTitle;
        private TextBox vAuthor;
        private Button btnSave;
        private Button btnCancel;
    }
}