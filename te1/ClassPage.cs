using System;
using System.Linq;
using System.Windows.Forms;
using te1.Models;

namespace te1
{
    public partial class ClassPage : UserControl
    {
        public ClassPage()
        {
            InitializeComponent();
            Load += ClassPage_Load;

            btnCreateClass.Click += btnCreateClass_Click;
            btnDeleteClass.Click += btnDeleteClass_Click;
            btnAssignTeacher.Click += btnAssignTeacher_Click;
            btnAddStudentToClass.Click += btnAddStudentToClass_Click;
            cboClass.SelectedIndexChanged += cboClass_SelectedIndexChanged;
        }

        private void ClassPage_Load(object? sender, EventArgs e)
        {
            cboClass.DataSource = DataStore.Classes;
            cboClass.DisplayMember = "Name";
            cboClass.ValueMember = "Id";

            cboTeacher.DataSource = DataStore.Teachers;
            cboTeacher.DisplayMember = "Name";
            cboTeacher.ValueMember = "Id";

            cboStudent.DataSource = DataStore.Students;
            cboStudent.DisplayMember = "Name";
            cboStudent.ValueMember = "Id";

            dgvStudentsInClass.AutoGenerateColumns = true;
            RefreshClassView();
        }

        private void cboClass_SelectedIndexChanged(object? sender, EventArgs e)
        {
            RefreshClassView();
        }

        private void RefreshClassView()
        {
            if (cboClass.SelectedItem is not ClassRoom cls)
            {
                dgvStudentsInClass.DataSource = null;
                lblHomeroom.Text = "GVCN: (none)";
                return;
            }

            var list = DataStore.Students
                .Where(s => s.ClassRoomIds.Contains(cls.Id))
                .ToList();

            dgvStudentsInClass.DataSource = null;
            dgvStudentsInClass.DataSource = list;
            var t = DataStore.Teachers.FirstOrDefault(x => x.Id == cls.HomeroomTeacherId);
            lblHomeroom.Text = $"GVCN: {(t == null ? "(none)" : t.Name)}";
        }

        private void btnCreateClass_Click(object? sender, EventArgs e)
        {
            var name = txtClassName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên lớp không được trống");
                return;
            }

            if (DataStore.Classes.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên lớp đã tồn tại");
                return;
            }

            var cls = new ClassRoom { Id = DataStore.NextClassId++, Name = name };
            DataStore.Classes.Add(cls);
            cboClass.DataSource = null;
            cboClass.DataSource = DataStore.Classes;
            cboClass.SelectedItem = cls;

            txtClassName.Clear();
        }

        private void btnDeleteClass_Click(object? sender, EventArgs e)
        {
            if (cboClass.SelectedItem is not ClassRoom cls) return;

            var ok = MessageBox.Show(
                $"Xóa lớp '{cls.Name}'?\n(Học sinh trong lớp sẽ bị xóa khỏi lớp này)",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            foreach (var s in DataStore.Students)
            {
                if (s.ClassRoomIds.Contains(cls.Id))
                {
                    s.ClassRoomIds.Remove(cls.Id);
                }
            }

            if (cls.HomeroomTeacherId.HasValue)
            {
                var teacher = DataStore.Teachers.FirstOrDefault(t => t.Id == cls.HomeroomTeacherId.Value);
                if (teacher != null) teacher.HomeroomClassId = null;
            }

            DataStore.Classes.Remove(cls);

            cboClass.DataSource = null;
            cboClass.DataSource = DataStore.Classes;

            RefreshClassView();
        }
        private void btnAssignTeacher_Click(object? sender, EventArgs e)
        {
            if (cboClass.SelectedItem is not ClassRoom cls) return;
            if (cboTeacher.SelectedItem is not Teacher teacher) return;

            if (teacher.HomeroomClassId.HasValue && teacher.HomeroomClassId.Value != cls.Id)
            {
                MessageBox.Show($"Teacher '{teacher.Name}' đang chủ nhiệm lớp khác!");
                return;
            }

            if (cls.HomeroomTeacherId.HasValue && cls.HomeroomTeacherId.Value != teacher.Id)
            {
                var old = DataStore.Teachers.FirstOrDefault(t => t.Id == cls.HomeroomTeacherId.Value);
                if (old != null) old.HomeroomClassId = null;
            }

            cls.HomeroomTeacherId = teacher.Id;
            teacher.HomeroomClassId = cls.Id;

            RefreshClassView();
        }

        private void btnAddStudentToClass_Click(object? sender, EventArgs e)
        {
            if (cboClass.SelectedItem is not ClassRoom cls) return;
            if (cboStudent.SelectedItem is not Student student) return;

            if (student.ClassRoomIds.Contains(cls.Id))
            {
                MessageBox.Show($"Học sinh '{student.Name}' đã có trong lớp '{cls.Name}'");
                return;
            }

            student.ClassRoomIds.Add(cls.Id);

            RefreshClassView();
        }
    }
}