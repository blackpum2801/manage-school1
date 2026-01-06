namespace te1.Views.Pages

{
    partial class TeacherPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSourceTeachers = new BindingSource(components);
            cmsTeachers = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dgvTeachers = new DataGridView();

            idCol = new DataGridViewTextBoxColumn();
            nameCol = new DataGridViewTextBoxColumn();
            emailCol = new DataGridViewTextBoxColumn();
            teacherCodeCol = new DataGridViewTextBoxColumn();
            departmentCol = new DataGridViewTextBoxColumn();
            salaryCol = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).BeginInit();
            cmsTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();

            // bindingSourceTeachers
            bindingSourceTeachers.DataSource = typeof(Models.Teacher);

            // cmsTeachers
            cmsTeachers.ImageScalingSize = new Size(20, 20);
            cmsTeachers.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsTeachers.Name = "cmsTeachers";
            cmsTeachers.Size = new Size(123, 76);

            // addToolStripMenuItem
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(122, 24);
            addToolStripMenuItem.Text = "Add";

            // editToolStripMenuItem
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";

            // deleteToolStripMenuItem
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";

            // dgvTeachers
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AutoGenerateColumns = false;
            dgvTeachers.BackgroundColor = SystemColors.ButtonFace;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { idCol, nameCol, emailCol, teacherCodeCol, departmentCol, salaryCol });
            dgvTeachers.ContextMenuStrip = cmsTeachers;
            dgvTeachers.DataSource = bindingSourceTeachers;
            dgvTeachers.Dock = DockStyle.Fill;
            dgvTeachers.Location = new Point(0, 0);
            dgvTeachers.MultiSelect = false;
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTeachers.Size = new Size(1169, 766);
            dgvTeachers.TabIndex = 0;
            dgvTeachers.UseWaitCursor = false; 

            // idCol
            idCol.DataPropertyName = "Id";
            idCol.HeaderText = "Id";
            idCol.MinimumWidth = 6;
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            idCol.Width = 125;

            // nameCol
            nameCol.DataPropertyName = "Name";
            nameCol.HeaderText = "Name";
            nameCol.MinimumWidth = 6;
            nameCol.Name = "nameCol";
            nameCol.ReadOnly = true;
            nameCol.Width = 125;

            // emailCol
            emailCol.DataPropertyName = "Email";
            emailCol.HeaderText = "Email";
            emailCol.MinimumWidth = 6;
            emailCol.Name = "emailCol";
            emailCol.ReadOnly = true;
            emailCol.Width = 125;

            // teacherCodeCol
            teacherCodeCol.DataPropertyName = "TeacherCode";
            teacherCodeCol.HeaderText = "TeacherCode";
            teacherCodeCol.MinimumWidth = 6;
            teacherCodeCol.Name = "teacherCodeCol";
            teacherCodeCol.ReadOnly = true;
            teacherCodeCol.Width = 125;

            // departmentCol
            departmentCol.DataPropertyName = "Department";
            departmentCol.HeaderText = "Department";
            departmentCol.MinimumWidth = 6;
            departmentCol.Name = "departmentCol";
            departmentCol.ReadOnly = true;
            departmentCol.Width = 125;

            // salaryCol
            salaryCol.DataPropertyName = "Salary"; 
            salaryCol.HeaderText = "Salary";
            salaryCol.MinimumWidth = 6;
            salaryCol.Name = "salaryCol";
            salaryCol.ReadOnly = true;
            salaryCol.Width = 125;

            // TeacherPage
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTeachers);
            Name = "TeacherPage";
            Size = new Size(1169, 766);

            ((System.ComponentModel.ISupportInitialize)bindingSourceTeachers).EndInit();
            cmsTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceTeachers;
        private ContextMenuStrip cmsTeachers;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;

        private DataGridView dgvTeachers;

        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn emailCol;
        private DataGridViewTextBoxColumn teacherCodeCol;
        private DataGridViewTextBoxColumn departmentCol;
        private DataGridViewTextBoxColumn salaryCol;
    }
}
