using MovieQuiz.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace MovieQuiz.Models
{
    public class Quiz
    {
        private List<Question> questions;
        private double maxPoints;
        public double Score { get; set; } = 0;
        public int QuestionNumber { get; set; } = -1;
        public int QuestionCount { get { return questions.Count(); } }
        public string SoundFile { get { return questions[QuestionNumber].SoundFile; } }
        public string CorrectAnswer { get { return questions[QuestionNumber].CorrectAnswer; } }
        public List<string> WrongAnswers { get { return questions[QuestionNumber].WrongAnswers; } }
        public List<string> Answers { get { return WrongAnswers.Concat(new[] { CorrectAnswer }).ToList().Shuffle(); } }
        public string JokerAnswer { get { return questions[QuestionNumber].WrongAnswers.Random(); } }

        public Quiz(List<Question> questions, double maxPoints)
        {
            this.questions = questions;
            this.maxPoints = maxPoints;
        }

        public void ShuffleQuestions()
        {
            questions = questions.Shuffle();
        }

        public void LimitQuestionsTo(int maxQuestions)
        {
            questions = questions.Take(maxQuestions).ToList();
        }

        internal bool IsDone()
        {
            if (QuestionNumber >= QuestionCount)
                return true;
            if (maxPoints > 0 && Score >= maxPoints)
                return true;
            return false;
        }

        internal bool IsCorrectAnswer(string answer)
        {
            return answer == CorrectAnswer;
        }

        internal void IncreaseScore(double answerPoints)
        {
            Score += answerPoints;
        }

        internal void nextQuestion()
        {
            QuestionNumber++;
        }
    }
}
