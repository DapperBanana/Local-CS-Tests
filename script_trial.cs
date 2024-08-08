
using System;
using TextBlob;
using Tweepy;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Tweepy API
        Tweepy.API api = new Tweepy.API("YOUR_TWITTER_API_KEY", "YOUR_TWITTER_API_SECRET");

        // Perform sentiment analysis on Twitter data
        string query = "happy";
        List<Tweet> tweets = api.SearchTweets(query);

        foreach (Tweet tweet in tweets)
        {
            string text = tweet.Text;
            double polarity = TextBlob.TextBlob(text).Sentiment.Polarity;

            Console.WriteLine("Tweet: " + text);
            Console.WriteLine("Sentiment Polarity: " + polarity);
            Console.WriteLine();
        }
    }
}
