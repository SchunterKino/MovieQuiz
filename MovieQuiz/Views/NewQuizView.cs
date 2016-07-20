using System;
using System.Windows.Forms;


namespace MovieQuiz.Views
{
    public partial class NewQuizView : UserControl
    {
        public event StartQuizEventHandler OnGameStarted;
        public delegate void StartQuizEventHandler(string playerName);

        public NewQuizView()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            OnGameStarted(nameText.Text);
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            // disable new game button when no player name is given
            bool nameEntered = nameText.Text != String.Empty;
            newGameButton.Enabled = nameEntered;
        }
    }
}
