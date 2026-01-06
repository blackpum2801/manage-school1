using System;
using System.Windows.Forms;
using System.Xml.Linq;
using te1.Models;

namespace te1.Views.Forms.Students
{
    public partial class AddStudentForm : Form
    {
        public Student Result { get; private set; } = new Student();

        public AddStudentForm()
        {
            InitializeComponent();

            btnOk.Click += btnOk_Click;
            btnCancel.Click += (_, __) => DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name không được để trống");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            Result.Name = txtName.Text.Trim();
            Result.Email = txtEmail.Text.Trim();
            Result.StudentCode = txtStudentCode.Text.Trim();
            Result.Major = txtMajor.Text.Trim();

            DialogResult = DialogResult.OK;
        }
    }
}
