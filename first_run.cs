
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweepy;
using TextBlob;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticate to Twitter API
            string consumerKey = "YOUR_CONSUMER_KEY";
            string consumerSecret = "YOUR_CONSUMER_SECRET";
            string accessToken = "YOUR_ACCESS_TOKEN";
            string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

            Tweepy.API api = new Tweepy.API(consumerKey, consumerSecret, accessToken, accessTokenSecret);

            // Get Twitter data
            List<string> tweets = new List<string>();
            foreach (Status tweet in api.search_tweets("keyword", 100))
            {
                tweets.Add(tweet.Text);
            }

            // Perform sentiment analysis on each tweet
            foreach (string tweet in tweets)
            {
                TextBlob.TextBlob blob = new TextBlob.TextBlob(tweet);
                double polarity = blob.sentiment.polarity;

                Console.WriteLine("Tweet: " + tweet);
                Console.WriteLine("Sentiment: " + (polarity > 0 ? "Positive" : (polarity < 0 ? "Negative" : "Neutral")));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
