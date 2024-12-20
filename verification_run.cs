
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweepy;
using TextBlob;

class Program
{
    static void Main()
    {
        // Authenticate with Twitter API
        string consumerKey = "YOUR_CONSUMER_KEY";
        string consumerSecret = "YOUR_CONSUMER_SECRET";
        string accessToken = "YOUR_ACCESS_TOKEN";
        string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

        OAuthHandler auth = new OAuthHandler(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        Tweepy.API api = new Tweepy.API(auth);

        // Search for tweets
        string query = "Microsoft";
        SearchResult result = api.SearchTweets(query);

        foreach (Status status in result.Statuses)
        {
            // Perform sentiment analysis on each tweet
            string tweetText = status.Text;
            TextBlob.TextBlob blob = new TextBlob.TextBlob(tweetText);
            double sentimentScore = blob.Sentiment.Polarity;

            Console.WriteLine("Tweet: {0}", tweetText);
            Console.WriteLine("Sentiment score: {0}", sentimentScore);
            Console.WriteLine();
        }
    }
}
