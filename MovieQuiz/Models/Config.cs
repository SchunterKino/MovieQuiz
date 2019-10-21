using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MovieQuiz.Models
{
    class Config
    {
        public string SoundDirectory { get; set; }
        public string HighscoreDatabase { get; set; }
        public int MaxQuestions { get; set; }
        public double PointsPerCorrectAnswer { get; set; }
        public double PointsPerWrongAnswer { get; set; }
        public int TimeoutSeconds { get; set; }
        public List<Question> Questions { get; set; }
    }
}
