using System.Windows.Forms;

namespace FilmQuiz.Views
{
    public partial class HighScoresEntry : UserControl
    {
        public HighScoresEntry()
        {
            InitializeComponent();
        }

        public void SetScores(string name, int score)
        {
            nameLabel.Text = name;
            scoreLabel.Text = score.ToString();
        }
    }
}
