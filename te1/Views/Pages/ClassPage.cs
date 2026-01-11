using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using te1.Controllers;
using te1.Models;
using te1.Services.Interfaces;
using te1.Views.Pages.Interfaces;

namespace te1.Views.Pages
{
    public partial class ClassPage : UserControl, IClassView
    {
        private ClassController _controller;
        private readonly IClassService _classService;
        private readonly ITeacherService _teacherService;
        private readonly IStudentService _studentService;

        public ClassPage(
            IClassService classService,
            ITeacherService teacherService,
            IStudentService studentService)
        {
            _classService = classService;
            _teacherService = teacherService;
            _studentService = studentService;

            InitializeComponent();

            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += ClassPage_Load;
            btnCreateClass.Click += (_, __) => _controller?.CreateClass();
            btnDeleteClass.Click += (_, __) => _controller?.DeleteClass();
            btnAssignTeacher.Click += (_, __) => _controller?.AssignHomeroomTeacher();
            btnAddStudentToClass.Click += (_, __) => _controller?.AddStudentToClass();

            cboClass.SelectedIndexChanged += (_, __) => _controller?.RefreshView();
        }

        private void ClassPage_Load(object sender, EventArgs e)
        {
            _controller = new ClassController(
                this,
                _classService,
                _teacherService,
                _studentService);

            _controller.Load();
        }

        // IClassView implementation
        public void BindClasses(BindingList<ClassRoom> classes)
        {
            cboClass.DataSource = classes;
            cboClass.DisplayMember = "Name";
            cboClass.ValueMember = "Id";
        }

        public void BindTeachers(BindingList<Teacher> teachers)
        {
            cboTeacher.DataSource = teachers;
            cboTeacher.DisplayMember = "Name";
            cboTeacher.ValueMember = "Id";
        }

        public void BindStudents(BindingList<Student> students)
        {
            cboStudent.DataSource = students;
            cboStudent.DisplayMember = "Name";
            cboStudent.ValueMember = "Id";
        }

        public ClassRoom? GetSelectedClass() => cboClass.SelectedItem as ClassRoom;
        public Teacher? GetSelectedTeacher() => cboTeacher.SelectedItem as Teacher;
        public Student? GetSelectedStudent() => cboStudent.SelectedItem as Student;

        public string GetNewClassName() => txtClassName.Text;
        public void ClearNewClassName() => txtClassName.Clear();

        public void ShowHomeroom(string text) => lblHomeroom.Text = text;

        public void ShowStudentsInClass(List<Student> students)
        {
            dgvStudentsInClass.AutoGenerateColumns = true;
            dgvStudentsInClass.DataSource = null;
            dgvStudentsInClass.DataSource = students;
        }

        public bool Confirm(string message, string title)
            => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;

        public void ShowError(string message)
            => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}