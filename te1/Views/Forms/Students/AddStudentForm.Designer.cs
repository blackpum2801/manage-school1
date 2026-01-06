namespace te1.Views.Forms.Students
{
    partial class AddStudentForm
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
            btnCancel = new Button();
            btnOk = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Name = new Label();
            txtMajor = new TextBox();
            txtStudentCode = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(393, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(293, 309);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 27;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 249);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 26;
            label5.Text = "Major";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 205);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 25;
            label4.Text = "StudentCode";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 154);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 24;
            label3.Text = "Email";
            label3.UseWaitCursor = true;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(38, 105);
            Name.Name = "Name";
            Name.Size = new Size(49, 20);
            Name.TabIndex = 23;
            Name.Text = "Name";
            Name.UseWaitCursor = true;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(167, 246);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(320, 27);
            txtMajor.TabIndex = 22;
            txtMajor.UseWaitCursor = true;
            // 
            // txtStudentCode
            // 
            txtStudentCode.Location = new Point(167, 198);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(320, 27);
            txtStudentCode.TabIndex = 21;
            txtStudentCode.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(166, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 27);
            txtEmail.TabIndex = 20;
            txtEmail.UseWaitCursor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 27);
            txtName.TabIndex = 19;
            txtName.UseWaitCursor = true;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
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
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label Name;
        private TextBox txtMajor;
        private TextBox txtStudentCode;
        private TextBox txtEmail;
        private TextBox txtName;
    }
}