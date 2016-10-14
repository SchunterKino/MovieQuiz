using MovieQuiz.Controller;
using System;
using System.Windows.Forms;

namespace MovieQuiz
{
    static class Program
    {
        public const string JSON_FILE = @"quiz.json";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainController controller = new MainController(JSON_FILE);
            Application.Run(new Views.MainMenu(controller));
        }
    }
}
