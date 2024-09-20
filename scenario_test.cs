
using System;
using System.Collections.Generic;
using System.Linq;
using Tweepy;
using TextBlob;

class Program
{
    static void Main(string[] args)
    {
        // Set up Tweepy API
        var consumerKey = "YOUR_CONSUMER_KEY";
        var consumerSecret = "YOUR_CONSUMER_SECRET";
        var accessToken = "YOUR_ACCESS_TOKEN";
        var accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

        var tweepy = new Tweepy.Tweepy(consumerKey, consumerSecret, accessToken, accessTokenSecret);

        // Search for tweets
        string query = "sentiment analysis";
        var tweets = tweepy.SearchTweets(query, 10);

        // Perform sentiment analysis on each tweet
        foreach (var tweet in tweets)
        {
            var textBlob = new TextBlob.TextBlob(tweet.Text);

            Console.WriteLine($"Tweet: {tweet.Text}");
            Console.WriteLine($"Sentiment: {textBlob.Sentiment}");
            Console.WriteLine();
        }
    }
}
