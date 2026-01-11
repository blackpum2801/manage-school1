using System;
using System.ComponentModel;
using System.Windows.Forms;
using te1.Controllers;
using te1.Models;
using te1.Services.Interfaces;
using te1.Views.Pages.Interfaces;
using te1.Views.Forms.Students;
namespace te1.Views.Pages
{
    public partial class StudentPage : UserControl, IStudentView
    {
        private StudentController _controller;
        private readonly IStudentService _studentService;
        public StudentPage(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();

            SetupEventHandlers();
        }
        // khi cac user control duoc load 
        private void SetupEventHandlers()
        {
            Load += StudentPage_Load;
            addToolStripMenuItem.Click += (_, __) => _controller?.Add();
            editToolStripMenuItem.Click += (_, __) => _controller?.Edit();
            deleteToolStripMenuItem.Click += (_, __) => _controller?.Delete();

            dgvStudents.CellMouseDown += dgvStudents_CellMouseDown;
            dgvStudents.ContextMenuStrip = cmsStudents;
            dgvStudents.AutoGenerateColumns = false;
        }
        private void StudentPage_Load(object? sender, EventArgs e)
        {
            _controller = new StudentController(this, _studentService);
            _controller.Load();

            if (dgvStudents.Rows.Count > 0)
                dgvStudents.Rows[0].Selected = true;
        }
        // IStudentView implementation
        public void BindStudents(BindingList<Student> students)
        {
            bindingSourceStudents.DataSource = students;
            dgvStudents.DataSource = bindingSourceStudents;
        }
        public Student? GetSelectedStudent()
            => bindingSourceStudents.Current as Student;
        public void RefreshCurrent()
            => bindingSourceStudents.ResetCurrentItem();

        public bool TryGetNewStudent(out Student student)
        {
            using var f = new AddStudentForm();
            if (f.ShowDialog(FindForm()) != DialogResult.OK)
            {
                student = default!;
                return false;
            }

            student = f.Result;
            return true;
        }
        public bool TryEditStudent(Student current, out Student updated)
        {
            using var f = new EditStudentForm(current);
            if (f.ShowDialog(FindForm()) != DialogResult.OK)
            {
                updated = default!;
                return false;
            }

            updated = f.Result;
            return true;
        }
        public bool ConfirmDelete(Student current)
        {
            var ok = MessageBox.Show(
                $"Xóa student '{current.Name}'?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return ok == DialogResult.Yes;
        }
        public void ShowError(string message)
            => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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