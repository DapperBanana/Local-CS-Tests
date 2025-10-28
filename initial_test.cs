
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
            // Enter your Twitter API credentials here
            string consumerKey = "YOUR_CONSUMER_KEY";
            string consumerSecret = "YOUR_CONSUMER_SECRET";
            string accessToken = "YOUR_ACCESS_TOKEN";
            string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

            Auth.SetUserAgent("TwitterSentimentAnalysisApp");
            Auth.SetConsumerKey(consumerKey);
            Auth.SetConsumerSecret(consumerSecret);
            Auth.SetAccessToken(accessToken);
            Auth.SetAccessTokenSecret(accessTokenSecret);

            // Get tweets from Twitter API
            List<Tweet> tweets = API.GetTweets("realDonaldTrump", 10); // Get 10 tweets from @realDonaldTrump
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine("Tweet: " + tweet.Text);
                Console.WriteLine("Sentiment: " + GetSentiment(tweet.Text));
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static string GetSentiment(string text)
        {
            var tb = new TextBlob(text);
            double polarity = tb.Polarity;

            if (polarity > 0)
            {
                return "Positive";
            }
            else if (polarity < 0)
            {
                return "Negative";
            }
            else
            {
                return "Neutral";
            }
        }
    }
}
