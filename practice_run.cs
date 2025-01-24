
using System;
using Tweepy;
using TextBlob;

class Program
{
    static void Main()
    {
        // Authenticate with Twitter API
        var consumerKey = "your_consumer_key";
        var consumerSecret = "your_consumer_secret";
        var accessToken = "your_access_token";
        var accessTokenSecret = "your_access_token_secret";

        var auth = new OAuthHandler(consumerKey, consumerSecret);
        auth.SetAccessToken(accessToken, accessTokenSecret);

        var api = new API(auth);

        // Get Twitter data
        var tweets = api.GetTweets("examplekeyword", 100); // Get 100 tweets for a specific keyword

        // Perform sentiment analysis
        foreach (var tweet in tweets)
        {
            var analysis = new TextBlobAnalysis(tweet.Text);

            Console.WriteLine("Tweet: " + tweet.Text);
            Console.WriteLine("Sentiment: " + analysis.Sentiment);
            Console.WriteLine("Subjectivity: " + analysis.Subjectivity);
            Console.WriteLine();
        }
    }
}

public class TextBlobAnalysis
{
    public string Text { get; }
    public string Sentiment { get; }
    public float Subjectivity { get; }

    public TextBlobAnalysis(string text)
    {
        Text = text;
        var blob = new TextBlob.TextBlob(text);

        Sentiment = blob.Sentiment.Polarity > 0 ? "Positive" :
                    blob.Sentiment.Polarity < 0 ? "Negative" : "Neutral";
        Subjectivity = blob.Sentiment.Subjectivity;
    }
}
