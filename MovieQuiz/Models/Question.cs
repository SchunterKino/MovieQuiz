using System.Collections.Generic;

namespace MovieQuiz.Models
{
    public class Question
    {
        public string SoundFile;
        public List<string> Answers { get; set;  }
        public string CorrectAnswer;
    }
}