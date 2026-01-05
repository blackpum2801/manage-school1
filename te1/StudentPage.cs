using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using te1.Models;

namespace te1
{
    public partial class StudentPage : UserControl
    {
        private BindingList<Student> _students = new BindingList<Student>();
        private int _nextId = 1;

        public StudentPage()
        {
            InitializeComponent();
            Load += StudentPage_Load;
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            dgvStudents.CellMouseDown += dgvStudents_CellMouseDown;

            dgvStudents.ContextMenuStrip = cmsStudents;
        }

        private void StudentPage_Load(object? sender, EventArgs e)
        {
            _students = new BindingList<Student>
            {
                new Student { Id = 1, Name="Maria", Email="maria@gmail.com", StudentCode="S001", Major="IT" },
                new Student { Id = 2, Name="Craig", Email="craig@gmail.com", StudentCode="S002", Major="Business" }
            };

            _nextId = _students.Any() ? _students.Max(x => x.Id) + 1 : 1;

            dgvStudents.AutoGenerateColumns = false;
            bindingSourceStudents.DataSource = _students;
            dgvStudents.DataSource = bindingSourceStudents;

            if (dgvStudents.Rows.Count > 0)
                dgvStudents.Rows[0].Selected = true;
        }

        private void addToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using var f = new AddStudentForm();
            if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

            var student = f.Result;
            student.Id = _nextId++;
            _students.Add(student);

            bindingSourceStudents.Position = _students.Count - 1;
        }

        private void editToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (bindingSourceStudents.Current is not Student current) return;

            using var f = new EditStudentForm(current);
            if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

            current.Name = f.Result.Name;
            current.Email = f.Result.Email;
            current.StudentCode = f.Result.StudentCode;
            current.Major = f.Result.Major;

            bindingSourceStudents.ResetCurrentItem();
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (bindingSourceStudents.Current is not Student current)
            {
                MessageBox.Show("Chọn 1 student để Delete");
                return;
            }

            var ok = MessageBox.Show(
                $"Xóa student '{current.Name}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            _students.Remove(current);
        }

        private void dgvStudents_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0) return;

            dgvStudents.ClearSelection();
            dgvStudents.Rows[e.RowIndex].Selected = true;

            dgvStudents.CurrentCell = dgvStudents.Rows[e.RowIndex].Cells[Math.Max(e.ColumnIndex, 0)];
            bindingSourceStudents.Position = e.RowIndex;
        }
    }
}
