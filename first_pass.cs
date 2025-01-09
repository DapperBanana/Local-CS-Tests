
using System;
using Tweepy;
using TextBlob;

class Program
{
    static void Main(string[] args)
    {
        // Authenticate to Twitter API
        string consumerKey = "your_consumer_key";
        string consumerSecret = "your_consumer_secret";
        string accessToken = "your_access_token";
        string accessTokenSecret = "your_access_token_secret";
        
        var auth = new OAuthHandler(consumerKey, consumerSecret);
        auth.set_access_token(accessToken, accessTokenSecret);
        
        var api = new API(auth);
        
        // Fetch tweets
        var tweets = api.search_tweets("keyword", count: 10, lang: "en");
        
        // Perform sentiment analysis on each tweet
        foreach (var tweet in tweets)
        {
            var textBlob = new TextBlob(tweet.text);
            var sentiment = textBlob.sentiment;
            
            Console.WriteLine("Tweet: " + tweet.text);
            Console.WriteLine("Sentiment: " + sentiment.polarity);
        }
    }
}
