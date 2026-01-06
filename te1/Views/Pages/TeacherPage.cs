using System;
using System.ComponentModel;
using System.Windows.Forms;
using te1.Controllers;
using te1.Models;
using te1.Services;
using te1.Views.Forms.Teachers;
namespace te1.Views.Pages
{
    public partial class TeacherPage : UserControl, ITeacherView
    {
        private readonly TeacherController _controller;

        public TeacherPage()
        {
            InitializeComponent();

            dgvTeachers.AutoGenerateColumns = false;
            dgvTeachers.ContextMenuStrip = cmsTeachers;

            _controller = new TeacherController(this, new SchoolService());

            Load += TeacherPage_Load;

            dgvTeachers.CellMouseDown += dgvTeachers_CellMouseDown;
            addToolStripMenuItem.Click += (_, __) => _controller.Add();
            editToolStripMenuItem.Click += (_, __) => _controller.Edit();
            deleteToolStripMenuItem.Click += (_, __) => _controller.Delete();
        }

        private void TeacherPage_Load(object? sender, EventArgs e)
        {
            _controller.Load();

            if (dgvTeachers.Rows.Count > 0)
                dgvTeachers.Rows[0].Selected = true;
        }

        public void BindTeachers(BindingList<Teacher> teachers)
        {
            bindingSourceTeachers.DataSource = teachers;
            dgvTeachers.DataSource = bindingSourceTeachers;
        }

        public Teacher? GetSelectedTeacher()
            => bindingSourceTeachers.Current as Teacher;

        public void RefreshCurrent()
            => bindingSourceTeachers.ResetCurrentItem();

        public bool TryGetNewTeacher(out Teacher teacher)
        {
            using var f = new AddTeacherForm();
            if (f.ShowDialog(FindForm()) != DialogResult.OK)
            {
                teacher = default!;
                return false;
            }

            teacher = f.Result;
            return true;
        }

        public bool TryEditTeacher(Teacher current, out Teacher updated)
        {
            using var f = new EditTeacherForm(current);
            if (f.ShowDialog(FindForm()) != DialogResult.OK)
            {
                updated = default!;
                return false;
            }

            updated = f.Result;
            return true;
        }

        public bool ConfirmDelete(Teacher t)
        {
            var ok = MessageBox.Show(
                $"Xóa teacher '{t.Name}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return ok == DialogResult.Yes;
        }

        public void ShowError(string message)
            => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
