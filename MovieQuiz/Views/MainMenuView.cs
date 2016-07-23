using System;
using System.Windows.Forms;


namespace MovieQuiz.Views
{
    public partial class MainMenuView : UserControl
    {
        public event StartQuizEventHandler StartGame;
        public delegate void StartQuizEventHandler(string playerName);

        public event ShowHighScoreEventHandler ShowHighScore;
        public delegate void ShowHighScoreEventHandler();

        public MainMenuView()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartGame(nameText.Text);
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            // disable new game button when no player name is given
            bool nameEntered = nameText.Text != string.Empty;
            newGameButton.Enabled = nameEntered;
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            ShowHighScore();
        }
    }
}
