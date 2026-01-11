using Microsoft.Extensions.DependencyInjection;
using te1.Controllers;
using te1.Services;
using te1.Services.Interfaces;
using te1.Views.Pages;
using System;
using System.Windows.Forms;

namespace te1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //DI Container
            var services = new ServiceCollection();

            services.AddSingleton<ISchoolService, SchoolService>();
            services.AddSingleton<IStudentService, SchoolService>();
            services.AddSingleton<ITeacherService, SchoolService>();
            services.AddSingleton<IClassService, SchoolService>();

            // Controller
            services.AddTransient<StudentController>();
            services.AddTransient<TeacherController>();
            services.AddTransient<ClassController>();

            // Page
            services.AddTransient<StudentPage>();
            services.AddTransient<TeacherPage>();
            services.AddTransient<ClassPage>();

            // MainForm
            services.AddTransient<MainForm>();
            var serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }
    }
}