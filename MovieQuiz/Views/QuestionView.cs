using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieQuiz.Views
{
    public partial class QuestionView : UserControl
    {

        public event AnswerEventHandler OnAnswer;
        public delegate void AnswerEventHandler(string answer);

        public event PlaySoundEventHandler OnPlaySoundFile;
        public delegate void PlaySoundEventHandler();

        public QuestionView()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            OnPlaySoundFile();
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
        }

        private void onButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OnAnswer(button.Text);
        }

        internal void ShowRemainingTime(int seconds)
        {
            // TODO
        }
    }
}
