using System.Windows.Forms;

namespace MovieQuiz.Views
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
