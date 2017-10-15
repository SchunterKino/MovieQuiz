using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieQuiz.Extensions
{
    static class ShuffleExtension
    {
        private static Random rnd = new Random();
        public static List<T> Shuffle<T>(this List<T> list)
        {
            return list.OrderBy(item => rnd.Next()).ToList();
        }
        public static T Random<T>(this List<T> list)
        {
            return list.Shuffle().Take(1).Single();
        }
    }
}
