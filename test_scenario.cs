
using System;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using Tweetinvi.Streaming;
using TextBlob;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("consumerKey", "consumerSecret", "accessToken", "accessTokenSecret");

            var stream = Stream.CreateFilteredStream();
            stream.AddTrack("csharp");

            stream.MatchingTweetReceived += (sender, eventArgs) =>
            {
                var tweet = eventArgs.Tweet;
                Console.WriteLine($"Tweet: {tweet.FullText}");

                var textBlob = new TextBlob.TextBlob(tweet.FullText);
                var sentiment = textBlob.Sentiment;
                
                if (sentiment.Polarity > 0)
                {
                    Console.WriteLine("Sentiment: Positive");
                }
                else if (sentiment.Polarity < 0)
                {
                    Console.WriteLine("Sentiment: Negative");
                }
                else
                {
                    Console.WriteLine("Sentiment: Neutral");
                }
            };

            stream.StartStreamMatchingAllConditions();
        }
    }
}
