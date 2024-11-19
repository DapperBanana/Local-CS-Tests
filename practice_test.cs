
using System;
using Numpy;
using NumSharp;
using Python.Runtime;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic sys = Py.Import("sys");
                sys.path.append("path_to_tweepy_and_textblob_folders");

                dynamic tweepy = Py.Import("tweepy");
                dynamic textblob = Py.Import("textblob");

                dynamic consumer_key = "your_consumer_key";
                dynamic consumer_secret = "your_consumer_secret";
                dynamic access_token = "your_access_token";
                dynamic access_token_secret = "your_access_token_secret";

                dynamic auth = tweepy.OAuthHandler(consumer_key, consumer_secret);
                auth.set_access_token(access_token, access_token_secret);
                dynamic api = tweepy.API(auth);

                dynamic public_tweets = api.search("#example_hashtag");

                foreach (dynamic tweet in public_tweets)
                {
                    dynamic analysis = textblob.TextBlob(tweet.text);
                    dynamic polarity = analysis.sentiment.polarity;
                    
                    if (polarity > 0)
                    {
                        Console.WriteLine(tweet.text);
                        Console.WriteLine("Sentiment: Positive");
                    }
                    else if (polarity < 0)
                    {
                        Console.WriteLine(tweet.text);
                        Console.WriteLine("Sentiment: Negative");
                    }
                    else
                    {
                        Console.WriteLine(tweet.text);
                        Console.WriteLine("Sentiment: Neutral");
                    }
                }
            }
        }
    }
}
