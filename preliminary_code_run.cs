
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBlob;
using Tweepy;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter your Twitter API credentials
            string consumerKey = "YOUR_CONSUMER_KEY";
            string consumerSecret = "YOUR_CONSUMER_SECRET";
            string accessToken = "YOUR_ACCESS_TOKEN";
            string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

            // Authenticate with Twitter API
            OAuthHandler auth = new OAuthHandler(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            API api = new API(auth);

            // Search for tweets containing a specific keyword
            string keyword = "basketball";
            dynamic tweets = api.Search(keyword);

            // Perform sentiment analysis on the tweets
            foreach (dynamic tweet in tweets["statuses"])
            {
                string text = tweet["text"];
                Console.WriteLine($"Tweet: {text}");

                // Perform sentiment analysis using TextBlob
                dynamic analysis = new TextBlob(text).sentiment;
                double polarity = analysis["polarity"];
                string sentiment = polarity > 0 ? "positive" : (polarity < 0 ? "negative" : "neutral");

                Console.WriteLine($"Sentiment: {sentiment}");
                Console.WriteLine();
            }
        }
    }
}
