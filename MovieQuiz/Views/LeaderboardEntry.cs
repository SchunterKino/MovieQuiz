using System.Globalization;
using System.Windows.Forms;

namespace MovieQuiz.Views
{
    public partial class LeaderboardEntry : UserControl
    {
        public LeaderboardEntry()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            nameLabel.Text = name;
        }

        public void SetScore(double score)
        {
            scoreLabel.Text = score.ToString("F", CultureInfo.InvariantCulture);
        }
    }
}
