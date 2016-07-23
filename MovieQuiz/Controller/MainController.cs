using MovieQuiz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            catch (Exception ex)
            {
                view.ShowError("Quiz Daten konnten nicht aus der " + Program.JSON_FILE + " Datei geladen werden:" + Environment.NewLine + ex.Message,
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
                // finished: show result and save to highscore list
                view.ShowResult(quiz.Score);
                SaveHighScore(teamName);
            }
        }

        private void SaveHighScore(string teamName)
        {
            // TODO implement me
        }

        public void OnRequestHighScore()
        {
            view.ShowHighScore(GetHighScore());
        }

        private List<KeyValuePair<String, int>> GetHighScore()
        {
            // TODO implement me
            var list = new List<KeyValuePair<string, int>>() {
                new KeyValuePair<string, int>("A", 1),
                new KeyValuePair<string, int>("B", 2),
                new KeyValuePair<string, int>("C", 3),
                new KeyValuePair<string, int>("D", 4),
                new KeyValuePair<string, int>("E", 5),
                new KeyValuePair<string, int>("F", 6),
            };

            return list;
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
