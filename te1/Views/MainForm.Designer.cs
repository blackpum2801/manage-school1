namespace te1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            contentPanel = new Panel();
            btrnClass = new Button();
            btnTeacher = new Button();
            btnStudent = new Button();
            label4 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            classBtn = new Button();
            teacherBtn = new Button();
            studentBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            pnlHeader = new Panel();
            label5 = new Label();
            pnlContent = new Panel();
            cmsStudents = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            pnlSidebar.SuspendLayout();
            contentPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlHeader.SuspendLayout();
            cmsStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ActiveCaption;
            pnlSidebar.Controls.Add(contentPanel);
            pnlSidebar.Controls.Add(classBtn);
            pnlSidebar.Controls.Add(teacherBtn);
            pnlSidebar.Controls.Add(studentBtn);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 719);
            pnlSidebar.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(btrnClass);
            contentPanel.Controls.Add(btnTeacher);
            contentPanel.Controls.Add(btnStudent);
            contentPanel.Controls.Add(label4);
            contentPanel.Controls.Add(label3);
            contentPanel.Controls.Add(menuStrip1);
            contentPanel.Dock = DockStyle.Left;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(220, 719);
            contentPanel.TabIndex = 0;
            // 
            // btrnClass
            // 
            btrnClass.BackColor = SystemColors.ActiveCaption;
            btrnClass.FlatAppearance.BorderSize = 0;
            btrnClass.FlatStyle = FlatStyle.Flat;
            btrnClass.Font = new Font("Segoe UI", 12F);
            btrnClass.Location = new Point(3, 328);
            btrnClass.Name = "btrnClass";
            btrnClass.Size = new Size(214, 77);
            btrnClass.TabIndex = 4;
            btrnClass.Text = "CLASS";
            btrnClass.UseVisualStyleBackColor = false;
            btrnClass.Click += btrnClass_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = SystemColors.ActiveCaption;
            btnTeacher.FlatAppearance.BorderSize = 0;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Font = new Font("Segoe UI", 12F);
            btnTeacher.Location = new Point(3, 245);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(212, 77);
            btnTeacher.TabIndex = 3;
            btnTeacher.Text = "TEACHER";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.ActiveCaption;
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 12F);
            btnStudent.Location = new Point(3, 152);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(214, 77);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "STUDENT";
            btnStudent.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 22F, FontStyle.Bold);
            label4.Location = new Point(11, 77);
            label4.Name = "label4";
            label4.Size = new Size(194, 44);
            label4.TabIndex = 1;
            label4.Text = "WELCOME";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label3.Location = new Point(40, 43);
            label3.Name = "label3";
            label3.Size = new Size(134, 37);
            label3.TabIndex = 0;
            label3.Text = "SCHOOL";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripComboBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(220, 32);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sToolStripMenuItem, openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 28);
            fileToolStripMenuItem.Text = "File";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(224, 26);
            sToolStripMenuItem.Text = "Save As";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // classBtn
            // 
            classBtn.BackColor = Color.Transparent;
            classBtn.FlatAppearance.BorderSize = 0;
            classBtn.FlatStyle = FlatStyle.Flat;
            classBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classBtn.Location = new Point(29, 314);
            classBtn.Name = "classBtn";
            classBtn.Size = new Size(125, 55);
            classBtn.TabIndex = 4;
            classBtn.Text = "Class";
            classBtn.UseMnemonic = false;
            classBtn.UseVisualStyleBackColor = false;
            // 
            // teacherBtn
            // 
            teacherBtn.BackColor = Color.Transparent;
            teacherBtn.FlatAppearance.BorderSize = 0;
            teacherBtn.FlatStyle = FlatStyle.Flat;
            teacherBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teacherBtn.Location = new Point(29, 235);
            teacherBtn.Name = "teacherBtn";
            teacherBtn.Size = new Size(125, 55);
            teacherBtn.TabIndex = 3;
            teacherBtn.Text = "Teacher";
            teacherBtn.UseMnemonic = false;
            teacherBtn.UseVisualStyleBackColor = false;
            // 
            // studentBtn
            // 
            studentBtn.BackColor = SystemColors.ActiveCaption;
            studentBtn.FlatAppearance.BorderSize = 0;
            studentBtn.FlatStyle = FlatStyle.Flat;
            studentBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentBtn.Location = new Point(29, 152);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new Size(125, 55);
            studentBtn.TabIndex = 2;
            studentBtn.Text = "Student";
            studentBtn.UseMnemonic = false;
            studentBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(212, 37);
            label2.TabIndex = 1;
            label2.Text = "Welcome back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 46);
            label1.TabIndex = 0;
            label1.Text = "SCHOOL";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ControlDark;
            pnlHeader.Controls.Add(label5);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(220, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1613, 70);
            pnlHeader.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 16F, FontStyle.Bold);
            label5.Location = new Point(22, 21);
            label5.Name = "label5";
            label5.Size = new Size(315, 33);
            label5.TabIndex = 5;
            label5.Text = "MANAGEMENT SCHOOL";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1613, 649);
            pnlContent.TabIndex = 2;
            pnlContent.UseWaitCursor = true;
            // 
            // cmsStudents
            // 
            cmsStudents.ImageScalingSize = new Size(20, 20);
            cmsStudents.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsStudents.Name = "cmsStudents";
            cmsStudents.Size = new Size(123, 76);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(122, 24);
            addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Student);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1833, 719);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "MainForm";
            Text = "Form1";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            cmsStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Button studentBtn;
        private Label label2;
        private Label label1;
        private Button classBtn;
        private Button teacherBtn;
        private BindingSource bindingSource1;
        private ContextMenuStrip cmsStudents;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel contentPanel;
        private Label label4;
        private Label label3;
        private Button btrnClass;
        private Button btnTeacher;
        private Button btnStudent;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}
