namespace te1
{
    partial class EditStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Name = new Label();
            txtMajor = new TextBox();
            txtStudentCode = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 278);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 16;
            label5.Text = "Major";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 234);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 15;
            label4.Text = "StudentCode";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 183);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Email";
            label3.UseWaitCursor = true;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(6, 134);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 13;
            Name.Text = "Name";
            Name.UseWaitCursor = true;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(135, 275);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(320, 27);
            txtMajor.TabIndex = 12;
            txtMajor.UseWaitCursor = true;
            // 
            // txtStudentCode
            // 
            txtStudentCode.Location = new Point(135, 227);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(320, 27);
            txtStudentCode.TabIndex = 11;
            txtStudentCode.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 10;
            txtEmail.UseWaitCursor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 27);
            txtName.TabIndex = 9;
            txtName.UseWaitCursor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(261, 338);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 17;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(361, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Name);
            Controls.Add(txtMajor);
            Controls.Add(txtStudentCode);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Text = "EditStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label Name;
        private TextBox txtMajor;
        private TextBox txtStudentCode;
        private TextBox txtEmail;
        private TextBox txtName;
        private Button btnOk;
        private Button btnCancel;
    }
}