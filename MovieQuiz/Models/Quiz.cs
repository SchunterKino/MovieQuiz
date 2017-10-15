using MovieQuiz.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace MovieQuiz.Models
{
    public class Quiz
    {
        private List<Question> questions;
        public int Score { get; set; } = 0;
        public int QuestionNumber { get; set; } = 0;
        public int QuestionCount { get { return questions.Count(); } }
        public string SoundFile { get { return questions[QuestionNumber].SoundFile; } }
        public string CorrectAnswer { get { return questions[QuestionNumber].CorrectAnswer; } }
        public List<string> WrongAnswers { get { return questions[QuestionNumber].WrongAnswers; } }
        public List<string> Answers { get { return WrongAnswers.Concat(new[] { CorrectAnswer }).ToList().Shuffle(); } }
        public string JokerAnswer { get { return questions[QuestionNumber].WrongAnswers.Random(); } }

        public Quiz(List<Question> questions)
        {
            this.questions = questions;
        }

        public void ShuffleQuestions()
        {
            questions = questions.Shuffle();
        }

        public void LimitQuestionsTo(int maxQuestions)
        {
            questions = questions.Take(maxQuestions + 1).ToList();
        }

        internal bool IsDone()
        {
            return QuestionNumber >= QuestionCount;
        }

        internal bool IsCorrectAnswer(string answer)
        {
            return answer == CorrectAnswer;
        }

        internal void IncreaseScore()
        {
            Score++;
        }

        internal void nextQuestion()
        {
            QuestionNumber++;
        }
    }
}
