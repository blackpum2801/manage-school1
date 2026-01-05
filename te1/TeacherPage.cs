using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using te1.Models;

namespace te1
{
    public partial class TeacherPage : UserControl
    {
        private BindingList<Teacher> _teachers = new BindingList<Teacher>();
        private int _nextId = 1;

        public TeacherPage()
        {
            InitializeComponent();

            Load += TeacherPage_Load;

            dgvTeachers.CellMouseDown += dgvTeachers_CellMouseDown;
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
        }

        private void TeacherPage_Load(object? sender, EventArgs e)
        {
            _teachers = new BindingList<Teacher>
            {
                new Teacher { Id = 1, Name="Mr John", Email="john@gmail.com", TeacherCode="T001", Department="IT", Salary=1000 },
                new Teacher { Id = 2, Name="Ms Anna", Email="anna@gmail.com", TeacherCode="T002", Department="Math", Salary=1200 }
            };

            _nextId = _teachers.Any() ? _teachers.Max(x => x.Id) + 1 : 1;

            dgvTeachers.AutoGenerateColumns = false;
            bindingSourceTeachers.DataSource = _teachers;
            dgvTeachers.DataSource = bindingSourceTeachers;

            if (dgvTeachers.Rows.Count > 0)
                dgvTeachers.Rows[0].Selected = true;
        }

        private void addToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using var f = new AddTeacherForm();
            if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

            var teacher = f.Result;
            teacher.Id = _nextId++;
            _teachers.Add(teacher);

            bindingSourceTeachers.Position = _teachers.Count - 1;
        }

        private void editToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (bindingSourceTeachers.Current is not Teacher current) return;

            using var f = new EditTeacherForm(current);
            if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

            current.Name = f.Result.Name;
            current.Email = f.Result.Email;
            current.TeacherCode = f.Result.TeacherCode;
            current.Department = f.Result.Department;
            current.Salary = f.Result.Salary;

            bindingSourceTeachers.ResetCurrentItem();
        }

        private void deleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (bindingSourceTeachers.Current is not Teacher current)
            {
                MessageBox.Show("Chọn 1 teacher để Delete");
                return;
            }

            var ok = MessageBox.Show(
                $"Xóa teacher '{current.Name}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            bindingSourceTeachers.RemoveCurrent();
        }

        private void dgvTeachers_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0) return;

            dgvTeachers.ClearSelection();
            dgvTeachers.Rows[e.RowIndex].Selected = true;

            dgvTeachers.CurrentCell = dgvTeachers.Rows[e.RowIndex].Cells[Math.Max(e.ColumnIndex, 0)];
            bindingSourceTeachers.Position = e.RowIndex;
        }
    }
}
