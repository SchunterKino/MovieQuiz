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
            Icon = Properties.Resources.quiz;

            this.controller = controller;
            controller.setView(this);
            controller.setTimer(timer);
            
            // send events from controls directly to controller
            newQuizView.StartGame += controller.OnNewGame;
            newQuizView.ShowHighScore += controller.OnRequestHighScore;
            questionView.GiveAnswer += controller.OnAnswer;
            questionView.UseJoker += controller.OnUseJoker;
            questionView.PlaySoundFile += controller.OnPlaySoundFile;
            leaderboardView.ShowMenu += controller.OnRequestMainMenu;
        }

        internal void ShowQuestion(List<string> answers, int questionNumber, int questionCount, int timeout)
        {
            controller.OnPlaySoundFile();
            newQuizView.Hide();
            leaderboardView.Hide();
            questionView.Show();
            questionView.SetQuestion(answers, questionNumber, questionCount, timeout);
        }

        internal void ShowMainMenu()
        {
            questionView.Hide();
            leaderboardView.Hide();
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

        internal void ShowTimeout(double score)
        {
            MessageBox.Show(string.Format("Zu spät, die Zeit ist um!\nAktuell habt ihr {0:F} Punkte.", score), "Zu spät!");
            controller.OnRequestNextQuestion();
        }

        internal void ShowCorrect(double score)
        {
            MessageBox.Show(string.Format("Richtig! Damit habt ihr {0:F} Punkte.", score), "Richtig!");
            controller.OnRequestNextQuestion();
        }

        internal void ShowIncorrect(string correctAnswer, double score)
        {
            MessageBox.Show(string.Format("Leider falsch. Die richtige Antwort ist: {0}\nAktuell habt ihr {1:F} Punkte.", correctAnswer, score), "Leider falsch");
            controller.OnRequestNextQuestion();
        }

        internal void ShowResult(double score)
        {
            MessageBox.Show(string.Format("Yay! Ihr habt euch {0:F} Punkte erspielt!", score), "Ergebnis");
            controller.OnRequestHighScore();
        }

        internal void ShowHighScore(List<KeyValuePair<string, double>> list)
        {
            newQuizView.Hide();
            questionView.Hide();
            leaderboardView.Show();
            leaderboardView.SetScores(list);
        }

        internal void ShowJoker(bool show)
        {
            questionView.ShowJoker(show);
        }

        internal void StrikeAnswer(string jokerAnswer)
        {
            questionView.StrikeAnswer(jokerAnswer);
        }
    }
}
