using System.Collections.Generic;

namespace MovieQuiz.Models
{
    public class Question
    {
        public string SoundFile { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> WrongAnswers { get; set; }
    }
}