
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBlob;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Tweepy API
            Tweepy.API.Init("<Your Twitter API Key>");

            // Get tweets from Twitter
            var tweets = Tweepy.API.GetTweets("<Twitter Handle>");

            foreach (var tweet in tweets)
            {
                // Perform sentiment analysis using TextBlob
                var analysis = new TextBlob(tweet.Text).Sentiment;

                Console.WriteLine($"Tweet: {tweet.Text}");
                Console.WriteLine($"Sentiment: {analysis.Polarity}");

                if (analysis.Polarity > 0)
                {
                    Console.WriteLine("Sentiment: Positive");
                }
                else if (analysis.Polarity < 0)
                {
                    Console.WriteLine("Sentiment: Negative");
                }
                else
                {
                    Console.WriteLine("Sentiment: Neutral");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
