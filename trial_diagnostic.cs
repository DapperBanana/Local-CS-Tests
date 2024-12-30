
using System;
using Tweepy;
using TextBlob;

class Program
{
    static void Main(string[] args)
    {
        // Set up Tweepy
        TweepyClient client = new TweepyClient();
        client.SetCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");

        // Fetch tweets from a user
        string username = "tweepy";
        List<string> tweets = client.GetTweets(username);

        // Perform sentiment analysis on each tweet
        foreach (string tweet in tweets)
        {
            TextBlobAnalyzer analyzer = new TextBlobAnalyzer();
            double sentiment = analyzer.AnalyzeSentiment(tweet);

            // Print the tweet and its sentiment score
            Console.WriteLine($"Tweet: {tweet}");
            Console.WriteLine($"Sentiment Score: {sentiment}");
            Console.WriteLine();
        }
    }
}
