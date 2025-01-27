
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>
        {
            { "User1", new Dictionary<string, int> { { "Action", 5 }, { "Adventure", 3 }, { "Comedy", 4 }, { "Romance", 2 } } },
            { "User2", new Dictionary<string, int> { { "Action", 3 }, { "Adventure", 4 }, { "Comedy", 2 }, { "Romance", 5 } } },
            { "User3", new Dictionary<string, int> { { "Action", 4 }, { "Adventure", 5 }, { "Comedy", 3 }, { "Romance", 2 } } }
        };

        string currentUser = "User1";

        Dictionary<string, int> currentUserPreferences = users[currentUser];

        Dictionary<string, double> scores = new Dictionary<string, double>();

        foreach (var user in users)
        {
            if (user.Key != currentUser)
            {
                foreach (var genre in user.Value)
                {
                    if (!currentUserPreferences.ContainsKey(genre.Key))
                    {
                        if (!scores.ContainsKey(genre.Key))
                        {
                            scores.Add(genre.Key, 0);
                        }
                        scores[genre.Key] += genre.Value;
                    }
                }
            }
        }

        Console.WriteLine("Recommendations for " + currentUser + ":");
        foreach (var score in scores)
        {
            Console.WriteLine(score.Key + " - " + score.Value);
        }
    }
}
