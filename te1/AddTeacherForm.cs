using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using te1.Models;

namespace te1
{
    public partial class AddTeacherForm : Form
    {
        public Teacher Result { get; private set; } = new Teacher();

        public AddTeacherForm()
        {
            InitializeComponent();

            btnOk.Click += btnOk_Click;
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name không được để trống");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

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
