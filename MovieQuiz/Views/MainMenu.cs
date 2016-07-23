using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MovieQuiz.Controller;

namespace MovieQuiz.Views
{
    public partial class MainMenu : Form
    {
        MainController controller;
        public MainMenu(MainController controller)
        {
            InitializeComponent();
            Icon = FilmQuiz.Properties.Resources.quiz;

            this.controller = controller;
            controller.setView(this);
            controller.setTimer(timer);
            
            // send events from controls directly to controller
            newQuizView.StartGame += controller.OnNewGame;
            newQuizView.ShowHighScore += controller.OnRequestHighScore;
            questionView.GiveAnswer += controller.OnAnswer;
            questionView.PlaySoundFile += controller.OnPlaySoundFile;
            highScoresView.ShowMenu += controller.OnRequestMainMenu;
        }

        internal void ShowQuestion(List<string> answers, int questionNumber, int questionCount, int timeout)
        {
            controller.OnPlaySoundFile();
            newQuizView.Hide();
            highScoresView.Hide();
            questionView.Show();
            questionView.SetQuestion(answers, questionNumber, questionCount, timeout);
        }

        internal void ShowMainMenu()
        {
            questionView.Hide();
            highScoresView.Hide();
            newQuizView.Show();
        }

        internal void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void ShowRemainingTime(int seconds)
        {
            questionView.ShowRemainingTime(seconds);
        }

        internal void ShowTimeout(int score)
        {
            MessageBox.Show("Zu spät, die Zeit ist um!", "Zu spät!");
            controller.OnRequestNextQuestion();
        }

        internal void ShowCorrect(int score)
        {
            MessageBox.Show("Richtig! Damit habt ihr " + score + " Punkte.", "Richtig!");
            controller.OnRequestNextQuestion();
        }

        internal void ShowIncorrect(string correctAnswer, int score)
        {
            MessageBox.Show("Leider falsch. Die richtige Antwort ist: " + correctAnswer, "Leider falsch");
            controller.OnRequestNextQuestion();
        }

        internal void ShowResult(int score)
        {
            MessageBox.Show("Yay! Ihr habt euch " + score + " Punkte erspielt!", "Ergebnis");
            controller.OnRequestHighScore();
        }

        internal void ShowHighScore(List<KeyValuePair<string, int>> list)
        {
            newQuizView.Hide();
            questionView.Hide();
            highScoresView.Show();
            highScoresView.SetHighScores(list);
        }
    }
}
