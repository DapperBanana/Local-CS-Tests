
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBlob;
using TextBlob.CSharpClient;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticate with Tweepy
            var auth = Tweepy.OAuthHandler("<consumer_key>", "<consumer_secret>");
            auth.SetAccessToken("<access_token>", "<access_token_secret>");

            var api = Tweepy.API(auth);

            // Get Twitter data
            var tweets = api.Search("#twitter", count: 100);

            // Perform sentiment analysis on each tweet
            foreach (var tweet in tweets)
            {
                var text = tweet.Text;

                // Use TextBlob for sentiment analysis
                var analysis = new TextBlob(text);
                var sentiment = analysis.Sentiment;

                Console.WriteLine("Tweet: " + text);
                Console.WriteLine("Sentiment: " + sentiment);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
