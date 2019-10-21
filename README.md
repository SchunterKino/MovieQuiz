# MovieQuiz
Can you guess which movie a soundclip belongs to?


Requires a bunch of sound clips and a `quiz.json` file in the same directory as the `MovieQuiz.exe` file that looks like this:
```JSON
{
    "SoundDirectory" : "Sounds",
    "HighscoreDatabase" : "highscores.sqlite",
    "EnableJoker": true,
    "MaxQuestions": 10,
    "MaxPoints": 0,
    "PointsPerCorrectAnswer": 1,
    "PointsPerWrongAnswer": 0,
    "TimeoutSeconds": 20,
    "Questions": [
        {
            "SoundFile": "1.mp3",
            "CorrectAnswer": "The Expendables 1",
            "WrongAnswers": [
                "The Expendables 2",
                "The Expendables 3"
            ]
        },
    ]
}
```

Highscores are saved in a SQLite database file, which will automatically be created. To reset scores, just delete or rename the database file.

Have a look at the [releases](https://github.com/SchunterKino/MovieQuiz/releases/latest/) page to download a complete quiz.
