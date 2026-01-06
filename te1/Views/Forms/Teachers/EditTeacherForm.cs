using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using te1.Models;

namespace te1.Views.Forms.Teachers
{
    public partial class EditTeacherForm : Form
    {
        public Teacher Result { get; private set; }

        public EditTeacherForm(Teacher teacher)
        {
            InitializeComponent();

            Result = new Teacher
            {
                Id = teacher.Id,
                Name = teacher.Name,
                Email = teacher.Email,
                TeacherCode = teacher.TeacherCode,
                Department = teacher.Department,
                Salary = teacher.Salary
            };

            txtName.Text = Result.Name;
            txtEmail.Text = Result.Email;
            txtTeacherCode.Text = Result.TeacherCode;
            txtDepartment.Text = Result.Department;
            txtSalary.Text = Result.Salary.ToString(CultureInfo.CurrentCulture);

            btnOk.Click += btnOk_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalary.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out var salary))
            {
                MessageBox.Show("Salary không hợp lệ");
                return;
            }

            Result.Name = txtName.Text.Trim();
            Result.Email = txtEmail.Text.Trim();
            Result.TeacherCode = txtTeacherCode.Text.Trim();
            Result.Department = txtDepartment.Text.Trim();
            Result.Salary = salary;

            DialogResult = DialogResult.OK;
        }
    }
}
