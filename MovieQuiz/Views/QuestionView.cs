using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieQuiz.Views
{
    public partial class QuestionView : UserControl
    {

        public event AnswerEventHandler GiveAnswer;
        public delegate void AnswerEventHandler(string answer);

        public event PlaySoundEventHandler PlaySoundFile;
        public delegate void PlaySoundEventHandler();

        public event UseJokerEventHandler UseJoker;
        public delegate void UseJokerEventHandler();

        public QuestionView()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlaySoundFile();
        }

        private void jokerButton_Click(object sender, EventArgs e)
        {
            UseJoker();
        }

        internal void SetQuestion(List<string> answers, int questionNumber, int questionCount, int timeout)
        {
            // remove all buttons from previous question
            answerPanel.Controls.Clear();

            foreach (string answer in answers)
            {
                Button button = new Button();
                button.Text = answer;
                button.AutoSize = true;
                button.Dock = System.Windows.Forms.DockStyle.Top;
                button.UseVisualStyleBackColor = true;
                button.Click += onButtonClicked;
                answerPanel.Controls.Add(button);
            }

            this.timeoutLabel.Text = String.Empty;
            questionCountLabel.Text = string.Format("Frage {0}/{1}", questionNumber, questionCount);
        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GiveAnswer(button.Text);
        }

        internal void ShowRemainingTime(int seconds)
        {
            this.timeoutLabel.Text = seconds.ToString();
        }

        internal void ShowJoker(bool show)
        {
            this.jokerButton.Visible = show;
        }

        internal void StrikeAnswer(string jokerAnswer)
        {
            foreach (Button button in answerPanel.Controls)
            {
                if (button.Text == jokerAnswer)
                {
                    button.Enabled = false;
                    break;
                }
            }
        }
    }
}
