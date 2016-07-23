using MovieQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace MovieQuiz.Controller
{
    public class MainController
    {
        private string teamName;
        private Quiz quiz;
        private Views.MainMenu view;
        private Timer timer;
        private int timeleft;
        private bool timerStarted = false;
        private WMPLib.WindowsMediaPlayer player;
        private HighScores highscores = new HighScores(Program.HIGHSCORE_DB);

        internal void setView(Views.MainMenu view)
        {
            this.view = view;
        }

        internal void setTimer(Timer timer)
        {
            this.timer = timer;
            timer.Tick += OnTimerTick;
        }

        public void OnNewGame(string teamName)
        {
            this.teamName = teamName;
            try
            {
                quiz = new Quiz(Program.JSON_FILE);
            }
            catch (Exception e)
            {
                view.ShowError("Quiz Daten konnten nicht aus der " + Program.JSON_FILE + " Datei geladen werden:" + Environment.NewLine + e.Message,
                    "Fehler beim Laden des Quiz");
                return;
            }

            quiz.ShuffleQuestions();
            quiz.LimitQuestionsTo(Program.MAX_QUESTIONS);

            NextQuestionOrFinish();
        }

        private void NextQuestionOrFinish()
        {
            quiz.nextQuestion();
            if (!quiz.IsDone())
            {
                timerStarted = false;
                view.ShowQuestion(quiz.Answers, quiz.QuestionNumber, quiz.QuestionCount, Program.TIMEOUT);
            }
            else
            {
                // finished: save to highscore list and show result
                highscores.AddEntry(teamName, quiz.Score);
                view.ShowResult(quiz.Score);
            }
        }


        public void OnRequestHighScore()
        {
            List<KeyValuePair<string, int>> highscoreList;
            try
            {
                highscoreList = highscores.GetEntries();
            }
            catch (SQLiteException e)
            {
                view.ShowError("Bestenliste konnte nicht geladen werden:" + Environment.NewLine + e.Message, "Fehler beim Laden der Bestenliste");
                return;
            }
            view.ShowHighScore(highscoreList);
        }

        public void OnPlaySoundFile()
        {
            if (player == null)
            {
                player = new WMPLib.WindowsMediaPlayer();
                player.PlayStateChange += OnPlayerStateChange;
            }

            try
            {
                player.URL = Path.Combine(Program.SOUND_DIR, quiz.SoundFile);
                player.controls.play();
            }
            catch (Exception ex)
            {
                view.ShowError("Die Datei " + quiz.SoundFile + " konnte nicht abgespielt werden:" + Environment.NewLine + ex.Message,
                    "Fehler beim Abspielen");
                return;
            }
        }

        public void OnPlayerStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // playback ended
                if (!timerStarted)
                {
                    timeleft = Program.TIMEOUT;
                    timer.Interval = 1000;
                    timer.Start();
                    timerStarted = true;
                }
            }
        }

        public void OnTimerTick(object sender, EventArgs e)
        {
            timeleft--;
            if (timeleft > 0)
            {
                view.ShowRemainingTime(timeleft);
            }
            else
            {
                timer.Stop();
                view.ShowTimeout(quiz.Score);
            }
        }

        public void OnAnswer(string answer)
        {
            timer.Stop();
            if (quiz.IsCorrectAnswer(answer))
            {
                quiz.IncreaseScore();
                view.ShowCorrect(quiz.Score);
            }
            else
            {
                view.ShowIncorrect(quiz.CorrectAnswer, quiz.Score);
            }
        }

        public void OnRequestNextQuestion()
        {
            NextQuestionOrFinish();
        }

        public void OnRequestMainMenu()
        {
            view.ShowMainMenu();
        }

    }
}
