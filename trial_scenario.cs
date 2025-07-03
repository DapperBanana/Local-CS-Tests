
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Simulating user preferences
        Dictionary<string, Dictionary<string, int>> userPreferences = new Dictionary<string, Dictionary<string, int>>()
        {
            { "User1", new Dictionary<string, int> { { "Action", 5 }, { "Comedy", 3 }, { "Drama", 1 } } },
            { "User2", new Dictionary<string, int> { { "Action", 2 }, { "Comedy", 4 }, { "Drama", 3 } } }
        };

        // Simulating item features
        Dictionary<string, Dictionary<string, int>> itemFeatures = new Dictionary<string, Dictionary<string, int>>()
        {
            { "Movie1", new Dictionary<string, int> { { "Action", 4 }, { "Comedy", 2 }, { "Drama", 1 } } },
            { "Movie2", new Dictionary<string, int> { { "Action", 3 }, { "Comedy", 5 }, { "Drama", 2 } } }
        };

        // Find recommendations for each user
        foreach (var user in userPreferences)
        {
            string currentUser = user.Key;
            var currentUserPrefs = user.Value;

            Console.WriteLine("Recommendations for " + currentUser + ":");

            foreach (var item in itemFeatures)
            {
                string currentItem = item.Key;
                var currentItemFeatures = item.Value;

                double score = 0;

                foreach (var feature in currentUserPrefs)
                {
                    string currentFeature = feature.Key;
                    if (currentItemFeatures.ContainsKey(currentFeature))
                    {
                        score += (currentItemFeatures[currentFeature] * feature.Value);
                    }
                }

                Console.WriteLine(currentItem + " - " + score);
            }

            Console.WriteLine();
        }
    }
}
