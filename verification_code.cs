
using System;
using System.Linq;
using System.Collections.Generic;
using TextBlobCore;
using Tweepy;
using Tweepy.Models;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string consumerKey = "YOUR_CONSUMER_KEY";
            string consumerSecret = "YOUR_CONSUMER_SECRET";
            string accessToken = "YOUR_ACCESS_TOKEN";
            string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

            Auth.SetCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);

            string query = "C# programming";
            int numberOfTweets = 100;

            List<Tweet> tweets = new List<Tweet>();

            SearchResults searchResults = API.SearchTweets(query, numberOfTweets);

            foreach (var status in searchResults.Statuses)
            {
                Tweet tweet = new Tweet(status.Text);
                tweets.Add(tweet);
            }

            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine($"Tweet: {tweet.Text}");
                Console.WriteLine($"Sentiment: {TextBlob.Sentiment(tweet.Text)}");
                Console.WriteLine();
            }
        }
    }

    public class Tweet
    {
        public string Text { get; }

        public Tweet(string text)
        {
            Text = text;
        }
    }

    public class TextBlob
    {
        public static string Sentiment(string text)
        {
            Blob blob = new Blob(text);
            double polarity = blob.Sentiment.Item1;
            return polarity > 0 ? "Positive" : polarity < 0 ? "Negative" : "Neutral";
        }
    }
}
