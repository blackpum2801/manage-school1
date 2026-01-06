namespace te1.Views.Pages
{
    partial class ClassPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtClassName = new TextBox();
            btnCreateClass = new Button();
            btnDeleteClass = new Button();
            cboClass = new ComboBox();
            cboTeacher = new ComboBox();
            btnAssignTeacher = new Button();
            cboStudent = new ComboBox();
            btnAddStudentToClass = new Button();
            dgvStudentsInClass = new DataGridView();
            a = new Label();
            label1 = new Label();
            label2 = new Label();
            lblHomeroom = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentsInClass).BeginInit();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(54, 155);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(125, 27);
            txtClassName.TabIndex = 0;
            // 
            // btnCreateClass
            // 
            btnCreateClass.BackColor = Color.Chartreuse;
            btnCreateClass.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateClass.Location = new Point(232, 153);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Size = new Size(94, 29);
            btnCreateClass.TabIndex = 1;
            btnCreateClass.Text = "Create";
            btnCreateClass.UseVisualStyleBackColor = false;
            // 
            // btnDeleteClass
            // 
            btnDeleteClass.BackColor = Color.Red;
            btnDeleteClass.Location = new Point(342, 154);
            btnDeleteClass.Name = "btnDeleteClass";
            btnDeleteClass.Size = new Size(94, 29);
            btnDeleteClass.TabIndex = 2;
            btnDeleteClass.Text = "Delete";
            btnDeleteClass.UseVisualStyleBackColor = false;
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(58, 296);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(151, 28);
            cboClass.TabIndex = 3;
            // 
            // cboTeacher
            // 
            cboTeacher.FormattingEnabled = true;
            cboTeacher.Location = new Point(58, 426);
            cboTeacher.Name = "cboTeacher";
            cboTeacher.Size = new Size(151, 28);
            cboTeacher.TabIndex = 4;
            // 
            // btnAssignTeacher
            // 
            btnAssignTeacher.Location = new Point(274, 421);
            btnAssignTeacher.Name = "btnAssignTeacher";
            btnAssignTeacher.Size = new Size(151, 35);
            btnAssignTeacher.TabIndex = 5;
            btnAssignTeacher.Text = "Assign Homeroom";
            btnAssignTeacher.UseVisualStyleBackColor = true;
            // 
            // cboStudent
            // 
            cboStudent.FormattingEnabled = true;
            cboStudent.Location = new Point(504, 428);
            cboStudent.Name = "cboStudent";
            cboStudent.Size = new Size(151, 28);
            cboStudent.TabIndex = 6;
            // 
            // btnAddStudentToClass
            // 
            btnAddStudentToClass.Location = new Point(699, 427);
            btnAddStudentToClass.Name = "btnAddStudentToClass";
            btnAddStudentToClass.Size = new Size(158, 37);
            btnAddStudentToClass.TabIndex = 7;
            btnAddStudentToClass.Text = "Add Student";
            btnAddStudentToClass.UseVisualStyleBackColor = true;
            // 
            // dgvStudentsInClass
            // 
            dgvStudentsInClass.BackgroundColor = SystemColors.ActiveCaption;
            dgvStudentsInClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentsInClass.Location = new Point(36, 519);
            dgvStudentsInClass.Name = "dgvStudentsInClass";
            dgvStudentsInClass.RowHeadersWidth = 51;
            dgvStudentsInClass.Size = new Size(914, 293);
            dgvStudentsInClass.TabIndex = 8;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            a.Location = new Point(54, 23);
            a.Name = "a";
            a.Size = new Size(210, 41);
            a.TabIndex = 10;
            a.Text = "Manage Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(54, 99);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 11;
            label1.Text = "Create Class :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(55, 246);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 14;
            label2.Text = "Choose Class";
            // 
            // lblHomeroom
            // 
            lblHomeroom.AutoSize = true;
            lblHomeroom.Font = new Font("Segoe UI", 14F);
            lblHomeroom.Location = new Point(58, 376);
            lblHomeroom.Name = "lblHomeroom";
            lblHomeroom.Size = new Size(158, 32);
            lblHomeroom.TabIndex = 15;
            lblHomeroom.Text = "GVCN: (none)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(495, 379);
            label5.Name = "label5";
            label5.Size = new Size(184, 32);
            label5.TabIndex = 16;
            label5.Text = "Choose Student";
            // 
            // ClassPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(lblHomeroom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(a);
            Controls.Add(dgvStudentsInClass);
            Controls.Add(btnAddStudentToClass);
            Controls.Add(cboStudent);
            Controls.Add(btnAssignTeacher);
            Controls.Add(cboTeacher);
            Controls.Add(cboClass);
            Controls.Add(btnDeleteClass);
            Controls.Add(btnCreateClass);
            Controls.Add(txtClassName);
            Name = "ClassPage";
            Size = new Size(1607, 869);
            ((System.ComponentModel.ISupportInitialize)dgvStudentsInClass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassName;
        private Button btnCreateClass;
        private Button btnDeleteClass;
        private ComboBox cboClass;
        private ComboBox cboTeacher;
        private Button btnAssignTeacher;
        private ComboBox cboStudent;
        private Button btnAddStudentToClass;
        private DataGridView dgvStudentsInClass;
        private Label a;
        private Label label1;
        private Label label2;
        private Label lblHomeroom;
        private Label label5;
    }
}
