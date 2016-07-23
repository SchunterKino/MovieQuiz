using System.Collections.Generic;
using System.Data.SQLite;

namespace MovieQuiz.Models
{
    public class HighScores
    {
        private string connectionString;

        public HighScores(string highscoreDB)
        {
            connectionString = "Data Source=" + highscoreDB;
        }

        public void AddEntry(string teamName, int score)
        {
            // connect to database (creates file if not exists)
            using (var dbConnection = new SQLiteConnection(connectionString))
            {
                dbConnection.Open();
                createHighScoresTableIfNotExists(dbConnection);

                // insert score
                using (var insertScoreCommand = dbConnection.CreateCommand())
                {
                    insertScoreCommand.CommandText = "INSERT INTO highscores(name, score) VALUES(@Name, @Score)";
                    insertScoreCommand.Prepare();
                    insertScoreCommand.Parameters.AddWithValue("@Name", teamName);
                    insertScoreCommand.Parameters.AddWithValue("@Score", score);
                    insertScoreCommand.ExecuteNonQuery();
                }
            }
        }

        public List<KeyValuePair<string, int>> GetEntries()
        {
            var highscores = new List<KeyValuePair<string, int>>();

            // connect to database (creates file if not exists)
            using (var dbConnection = new SQLiteConnection(connectionString))
            {
                dbConnection.Open();
                createHighScoresTableIfNotExists(dbConnection);

                // get scores
                using (var selectScoreCommand = dbConnection.CreateCommand())
                {
                    selectScoreCommand.CommandText = "SELECT name, score FROM highscores ORDER BY score DESC";
                    SQLiteDataReader reader = selectScoreCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        int score = reader.GetInt32(1);
                        highscores.Add(new KeyValuePair<string, int>(name, score));
                    }
                }
            }

            return highscores;
        }

        private void createHighScoresTableIfNotExists(SQLiteConnection dbConnection)
        {
            using (var createTableCommand = dbConnection.CreateCommand())
            {
                createTableCommand.CommandText = "CREATE TABLE IF NOT EXISTS highscores (name VARCHAR(128), score INT)";
                createTableCommand.ExecuteNonQuery();
            }
        }
    }
}
