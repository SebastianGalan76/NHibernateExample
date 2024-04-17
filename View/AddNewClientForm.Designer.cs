namespace NHibernateExample {
    partial class AddNewClientForm {
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
            vFirstName = new TextBox();
            vLastName = new TextBox();
            vEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 89);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 167);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 234);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // vFirstName
            // 
            vFirstName.Location = new Point(338, 107);
            vFirstName.Name = "vFirstName";
            vFirstName.Size = new Size(176, 23);
            vFirstName.TabIndex = 3;
            // 
            // vLastName
            // 
            vLastName.Location = new Point(338, 185);
            vLastName.Name = "vLastName";
            vLastName.Size = new Size(176, 23);
            vLastName.TabIndex = 4;
            // 
            // vEmail
            // 
            vEmail.Location = new Point(338, 252);
            vEmail.Name = "vEmail";
            vEmail.Size = new Size(176, 23);
            vEmail.TabIndex = 5;
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
            // AddNewClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(vEmail);
            Controls.Add(vLastName);
            Controls.Add(vFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewClientForm";
            Text = "AddNewClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox vFirstName;
        private TextBox vLastName;
        private TextBox vEmail;
        private Button btnSave;
        private Button btnCancel;
    }
}