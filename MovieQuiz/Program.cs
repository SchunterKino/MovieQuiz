using MovieQuiz.Controller;
using System;
using System.Windows.Forms;

namespace MovieQuiz
{
    static class Program
    {
        public const string JSON_FILE = @"quiz.json";
        public const string SOUND_DIR = @"Sounds";
        public const string HIGHSCORE_DB = @"highscores.sqlite";
        public const int MAX_QUESTIONS = 10;
        public const int TIMEOUT = 30; // seconds

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainController controller = new MainController();
            Application.Run(new Views.MainMenu(controller));
        }
    }
}
