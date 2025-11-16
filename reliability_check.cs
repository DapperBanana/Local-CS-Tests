
using System;
using Tweepy;
using TextBlob;

class Program
{
    static void Main()
    {
        // Set up Tweepy API credentials
        string consumerKey = "YOUR_CONSUMER_KEY";
        string consumerSecret = "YOUR_CONSUMER_SECRET";
        string accessToken = "YOUR_ACCESS_TOKEN";
        string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

        // Set up Tweepy API object
        var api = new TweepyAPI(consumerKey, consumerSecret, accessToken, accessTokenSecret);

        // Get tweets from Twitter
        var tweets = api.GetTweets("realDonaldTrump", 10); // Get 10 tweets from @realDonaldTrump

        foreach (var tweet in tweets)
        {
            string text = tweet.Text;

            // Perform sentiment analysis using TextBlob
            var analysis = new TextBlobAnalysis(text);
            double polarity = analysis.Sentiment.Polarity;
            string sentiment = polarity > 0 ? "positive" : (polarity < 0 ? "negative" : "neutral");

            Console.WriteLine($"Tweet: {text}");
            Console.WriteLine($"Sentiment: {sentiment}");
            Console.WriteLine($"Polarity: {polarity}");
            Console.WriteLine();
        }
    }
}
