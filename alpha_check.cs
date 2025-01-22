
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> userPreferences = new Dictionary<string, Dictionary<string, int>>()
        {
            { "Alice", new Dictionary<string, int> { {"Action", 5}, {"Drama", 3}, {"Comedy", 2} } },
            { "Bob", new Dictionary<string, int> { {"Action", 4}, {"Drama", 3}, {"Comedy", 1} } },
            { "Carol", new Dictionary<string, int> { {"Action", 2}, {"Drama", 4}, {"Comedy", 5} } }
        };

        Dictionary<string, int> userQuery = new Dictionary<string, int>
        {
            { "Action", 5 },
            { "Drama", 3 },
            { "Comedy", 1 }
        };

        List<string> recommendedUsers = Recommend(userPreferences, userQuery);

        Console.WriteLine("Recommended users: ");

        foreach (string user in recommendedUsers)
        {
            Console.WriteLine(user);
        }
    }

    static List<string> Recommend(Dictionary<string, Dictionary<string, int>> userPreferences, Dictionary<string, int> userQuery)
    {
        List<string> recommendedUsers = new List<string>();
        double maxSimilarity = 0;

        foreach (var user in userPreferences)
        {
            double similarity = CalculateSimilarity(user.Value, userQuery);

            if (similarity > maxSimilarity)
            {
                maxSimilarity = similarity;
                recommendedUsers.Clear();
                recommendedUsers.Add(user.Key);
            }
            else if (similarity == maxSimilarity)
            {
                recommendedUsers.Add(user.Key);
            }
        }

        return recommendedUsers;
    }

    static double CalculateSimilarity(Dictionary<string, int> user1, Dictionary<string, int> user2)
    {
        double dotProduct = 0;
        double magnitudeUser1 = 0;
        double magnitudeUser2 = 0;

        foreach (var genre in user1.Keys)
        {
            int ratingUser1 = user1[genre];
            int ratingUser2 = user2.GetValueOrDefault(genre, 0);

            dotProduct += ratingUser1 * ratingUser2;
            magnitudeUser1 += Math.Pow(ratingUser1, 2);
            magnitudeUser2 += Math.Pow(ratingUser2, 2);
        }

        magnitudeUser1 = Math.Sqrt(magnitudeUser1);
        magnitudeUser2 = Math.Sqrt(magnitudeUser2);

        if (magnitudeUser1 == 0 || magnitudeUser2 == 0)
        {
            return 0;
        }

        return dotProduct / (magnitudeUser1 * magnitudeUser2);
    }
}
