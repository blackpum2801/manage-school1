using System;
using System.Windows.Forms;
using System.IO;

namespace te1
{

    public partial class MainForm : Form
    {

        private static string GetDownloadsFolder()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );
        }
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            btnStudent.Click += btnStudent_Click;
            btnTeacher.Click += btnTeacher_Click;
        }


        private void MainForm_Load(object? sender, EventArgs e)
        {
            DataStore.Seed();
            LoadPage(new StudentPage());
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoadPage(new StudentPage());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            LoadPage(new TeacherPage());
        }
        private void btrnClass_Click(object sender, EventArgs e)
        {
            LoadPage(new ClassPage());

        }



        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Save school data",
                Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*",
                FileName = "school-data.json",
                InitialDirectory = GetDownloadsFolder(),
                AddExtension = true,
                DefaultExt = "json",
                OverwritePrompt = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog(this) != DialogResult.OK) return;

            JsonStorage.ExportToJson(sfd.FileName);
            MessageBox.Show("Export JSON thành công!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Open school data",
                Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*",
                InitialDirectory = GetDownloadsFolder(),
                Multiselect = false,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog(this) != DialogResult.OK) return;

            JsonStorage.ImportFromJson(ofd.FileName);
            MessageBox.Show("Import JSON thành công!");
            LoadPage(new StudentPage());
        }

    }
}
