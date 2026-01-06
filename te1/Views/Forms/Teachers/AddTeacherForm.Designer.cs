namespace te1.Views.Forms.Teachers

{
    partial class AddTeacherForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnOk = new Button();
            btnCancel = new Button();

            lblName = new Label();
            lblEmail = new Label();
            lblTeacherCode = new Label();
            lblDepartment = new Label();
            lblSalary = new Label();

            txtName = new TextBox();
            txtEmail = new TextBox();
            txtTeacherCode = new TextBox();
            txtDepartment = new TextBox();
            txtSalary = new TextBox();

            SuspendLayout();

            lblName.Text = "Name";
            lblName.Location = new Point(20, 25);

            txtName.Location = new Point(140, 22);
            txtName.Width = 250;

            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20, 65);

            txtEmail.Location = new Point(140, 62);
            txtEmail.Width = 250;

            lblTeacherCode.Text = "Teacher Code";
            lblTeacherCode.Location = new Point(20, 105);

            txtTeacherCode.Location = new Point(140, 102);
            txtTeacherCode.Width = 250;

            lblDepartment.Text = "Department";
            lblDepartment.Location = new Point(20, 145);

            txtDepartment.Location = new Point(140, 142);
            txtDepartment.Width = 250;

            lblSalary.Text = "Salary";
            lblSalary.Location = new Point(20, 185);

            txtSalary.Location = new Point(140, 182);
            txtSalary.Width = 250;

            btnOk.Text = "OK";
            btnOk.Location = new Point(200, 230);

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(300, 230);

            Controls.AddRange(new Control[]
            {
                lblName, txtName,
                lblEmail, txtEmail,
                lblTeacherCode, txtTeacherCode,
                lblDepartment, txtDepartment,
                lblSalary, txtSalary,
                btnOk, btnCancel
            });

            ClientSize = new Size(420, 290);
            Text = "Add Teacher";
            ResumeLayout(false);
        }

        private Button btnOk;
        private Button btnCancel;

        private Label lblName;
        private Label lblEmail;
        private Label lblTeacherCode;
        private Label lblDepartment;
        private Label lblSalary;

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtTeacherCode;
        private TextBox txtDepartment;
        private TextBox txtSalary;
    }
}
