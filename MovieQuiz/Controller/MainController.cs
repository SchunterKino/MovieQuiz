using MovieQuiz.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace MovieQuiz.Controller
{
    public class MainController
    {
        private string jsonFile;
        private Highscores highscores;
        private Config config;
        private Views.MainMenu view;
        private Timer timer;
        private int timeleft;
        private bool timerStarted = false;
        private string teamName;
        private Quiz quiz;
        private WMPLib.WindowsMediaPlayer player;

        public MainController(string jsonFile)
        {
            this.jsonFile = jsonFile;
            player = new WMPLib.WindowsMediaPlayer();
            player.PlayStateChange += OnPlayerStateChange;
        }

        internal void setView(Views.MainMenu view)
        {
            this.view = view;
            loadJsonFile(this.jsonFile);
            if (config != null)
                highscores = new Highscores(config.HighscoreDatabase);
        }

        private void loadJsonFile(string jsonFile)
        {
            try
            {
                var jsonText = File.ReadAllText(jsonFile);
                config = JsonConvert.DeserializeObject<Config>(jsonText);
            }
            catch (Exception e)
            {
                view.ShowError("Quiz Daten konnten nicht aus der " + jsonFile + " Datei geladen werden:" + Environment.NewLine + e.Message,
                    "Fehler beim Laden des Quiz");
            }
        }

        internal void setTimer(Timer timer)
        {
            this.timer = timer;
            timer.Tick += OnTimerTick;
        }

        public void OnNewGame(string teamName)
        {
            this.teamName = teamName;
            quiz = new Quiz(config.Questions);
            quiz.ShuffleQuestions();
            quiz.LimitQuestionsTo(config.MaxQuestions);
            NextQuestionOrFinish();
        }

        private void NextQuestionOrFinish()
        {
            quiz.nextQuestion();
            if (!quiz.IsDone())
            {
                timerStarted = false;
                view.ShowQuestion(quiz.Answers, quiz.QuestionNumber, quiz.QuestionCount, config.TimeoutSeconds);
                view.ShowJoker(true);
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
            List<KeyValuePair<string, double>> highscoreList;
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
            try
            {
                player.URL = Path.Combine(config.SoundDirectory, quiz.SoundFile);
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
                    timeleft = config.TimeoutSeconds;
                    timer.Interval = 1000;
                    timer.Start();
                    timerStarted = true;
                }
            }
        }

        public void OnTimerTick(object sender, EventArgs e)
        {
            timeleft--;
            view.ShowRemainingTime(timeleft);
            if (timeleft <= 0)
            {
                timer.Stop();
                view.ShowTimeout();
            }
        }

        public void OnUseJoker()
        {
            view.ShowJoker(false);
            view.StrikeAnswer(quiz.JokerAnswer);
        }

        public void OnAnswer(string answer)
        {
            player.controls.stop();
            timer.Stop();

            if (quiz.IsCorrectAnswer(answer))
            {
                quiz.IncreaseScore(config.PointsPerCorrectAnswer);
                view.ShowCorrect(quiz.Score);
            }
            else
            {
                view.ShowIncorrect(quiz.CorrectAnswer);
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
