using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmQuiz.Views
{
    public partial class HighScoresView : UserControl
    {
        public event ShowMenuEventHandler ShowMenu;
        public delegate void ShowMenuEventHandler();

        public HighScoresView()
        {
            InitializeComponent();
        }

        public void SetHighScores(List<KeyValuePair<string, int>> scores)
        {
            // remove all existing scores entries
            scorePanel.Controls.Clear();

            // highest score first
            scores.OrderBy(score => score.Value);
            scores.Reverse();

            foreach (var score in scores) {
                var entry = new HighScoresEntry();
                entry.SetScores(score.Key, score.Value);
                entry.AutoSize = true;
                entry.Dock = System.Windows.Forms.DockStyle.Top;
                scorePanel.Controls.Add(entry);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }
    }
}
