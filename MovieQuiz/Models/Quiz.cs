﻿using MovieQuiz.Extensions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
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
        public List<string> Answers { get { return questions[QuestionNumber].Answers; } }

        public Quiz(string file)
        {
            var jsonText = File.ReadAllText(file);
            questions = JsonConvert.DeserializeObject<List<Question>>(jsonText);
        }

        public void ShuffleQuestions()
        {
            questions = questions.Shuffle();
        }

        public void LimitQuestionsTo(int maxQuestions)
        {
            questions = questions.Take(maxQuestions+1).ToList();
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
