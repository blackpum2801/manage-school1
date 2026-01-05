using System;
using System.Windows.Forms;
using te1.Models;

namespace te1
{
    public partial class EditStudentForm : Form
    {
        public Models.Student Result { get; private set; }

        public EditStudentForm(Models.Student student)
        {
            InitializeComponent();
            Result = new Models.Student
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                StudentCode = student.StudentCode,
                Major = student.Major
            };

            txtName.Text = Result.Name;
            txtEmail.Text = Result.Email;
            txtStudentCode.Text = Result.StudentCode;
            txtMajor.Text = Result.Major;

            btnOk.Click += btnOk_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }
        private void btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name không được trống");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            Result.Name = txtName.Text.Trim();
            Result.Email = txtEmail.Text.Trim();
            Result.StudentCode = txtStudentCode.Text.Trim();
            Result.Major = txtMajor.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
