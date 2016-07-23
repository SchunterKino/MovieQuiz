using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MovieQuiz.Views
{
    public partial class LeaderboardView : UserControl
    {
        public event ShowMenuEventHandler ShowMenu;
        public delegate void ShowMenuEventHandler();

        public LeaderboardView()
        {
            InitializeComponent();
        }

        public void SetScores(List<KeyValuePair<string, int>> scores)
        {
            // remove all existing scores entries
            scrollPanel.Controls.Clear();

            // highest score first
            scores.OrderBy(score => score.Value);
            scores.Reverse();

            foreach (var score in scores) {
                var entry = new LeaderboardEntry();
                entry.SetName(score.Key);
                entry.SetScore(score.Value);
                entry.AutoSize = true;
                entry.Dock = DockStyle.Top;
                scrollPanel.Controls.Add(entry);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }
    }
}
