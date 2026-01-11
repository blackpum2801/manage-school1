using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using te1.Controllers;
using te1.Data;
using te1.Services;
using te1.Views.Pages;

namespace te1
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private static string GetDownloadsFolder()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );
        }

        public MainForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            Load += MainForm_Load;
            btnStudent.Click += btnStudent_Click;
            btnTeacher.Click += btnTeacher_Click;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            LoadStudentPage();
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoadStudentPage();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            LoadTeacherPage();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            LoadClassPage();
        }

        private void LoadStudentPage()
        {
            try
            {
                var studentPage = _serviceProvider.GetRequiredService<StudentPage>();
                LoadPage(studentPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải trang Student: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherPage()
        {
            try
            {
                var teacherPage = _serviceProvider.GetRequiredService<TeacherPage>();
                LoadPage(teacherPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải trang Teacher: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClassPage()
        {
            try
            {
                var classPage = _serviceProvider.GetRequiredService<ClassPage>();
                LoadPage(classPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải trang Class: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

            JsonStorageService.ExportToJson(sfd.FileName);
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

            JsonStorageService.ImportFromJson(ofd.FileName);
            MessageBox.Show("Import JSON thành công!");

            // Reload current page
            ReloadCurrentPage();
        }

        private void ReloadCurrentPage()
        {
            if (pnlContent.Controls.Count > 0)
            {
                var currentPage = pnlContent.Controls[0];
                if (currentPage is StudentPage)
                    LoadStudentPage();
                else if (currentPage is TeacherPage)
                    LoadTeacherPage();
                else if (currentPage is ClassPage)
                    LoadClassPage();
            }
        }

        // Menu items click handlers
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }
    }
}