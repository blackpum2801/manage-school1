namespace te1.Views.Pages
{
    partial class StudentPage
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
            components = new System.ComponentModel.Container();
            bindingSourceStudents = new BindingSource(components);
            cmsStudents = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            dgvStudents = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            majorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSourceStudents).BeginInit();
            cmsStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceStudents
            // 
            bindingSourceStudents.DataSource = typeof(Models.Student);
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
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.BackgroundColor = SystemColors.ButtonFace;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, studentCodeDataGridViewTextBoxColumn, majorDataGridViewTextBoxColumn });
            dgvStudents.ContextMenuStrip = cmsStudents;
            dgvStudents.DataSource = bindingSourceStudents;
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.Location = new Point(0, 0);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1169, 766);
            dgvStudents.TabIndex = 3;
            dgvStudents.UseWaitCursor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentCodeDataGridViewTextBoxColumn
            // 
            studentCodeDataGridViewTextBoxColumn.DataPropertyName = "StudentCode";
            studentCodeDataGridViewTextBoxColumn.HeaderText = "StudentCode";
            studentCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentCodeDataGridViewTextBoxColumn.Name = "studentCodeDataGridViewTextBoxColumn";
            studentCodeDataGridViewTextBoxColumn.ReadOnly = true;
            studentCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            majorDataGridViewTextBoxColumn.HeaderText = "Major";
            majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            majorDataGridViewTextBoxColumn.ReadOnly = true;
            majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // StudentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Name = "StudentPage";
            Size = new Size(1169, 766);
            ((System.ComponentModel.ISupportInitialize)bindingSourceStudents).EndInit();
            cmsStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceStudents;
        private ContextMenuStrip cmsStudents;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
    }
}
