
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> ratings = new Dictionary<string, Dictionary<string, int>>{
            {"User1", new Dictionary<string, int>{
                {"Movie1", 5},
                {"Movie2", 4},
                {"Movie3", 3},
                {"Movie4", 2},
                {"Movie5", 1}
            }},
            {"User2", new Dictionary<string, int>{
                {"Movie1", 1},
                {"Movie2", 2},
                {"Movie3", 3},
                {"Movie4", 4},
                {"Movie5", 5}
            }},
            {"User3", new Dictionary<string, int>{
                {"Movie1", 3},
                {"Movie2", 3},
                {"Movie3", 3},
                {"Movie4", 3},
                {"Movie5", 3}
            }}
        };

        Console.Write("Enter user: ");
        string user = Console.ReadLine();

        Console.WriteLine("Recommended movies for user " + user + ":");

        Dictionary<string, double> scores = new Dictionary<string, double>();

        foreach(var key in ratings[user].Keys)
        {
            foreach(var userRating in ratings)
            {
                if(userRating.Key != user)
                {
                    if(userRating.Value.ContainsKey(key))
                    {
                        if(scores.ContainsKey(key))
                            scores[key] += userRating.Value[key];
                        else
                            scores[key] = userRating.Value[key];
                    }
                }
            }
        }

        foreach(var movie in scores.Keys)
        {
            scores[movie] = scores[movie] / (ratings[user].Count * 1.0);
        }

        foreach(var movie in scores)
        {
            Console.WriteLine(movie.Key + ": " + movie.Value);
        }
    }
}
