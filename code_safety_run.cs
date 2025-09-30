
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace TwitterSentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string consumerKey = "YOUR_CONSUMER_KEY";
            string consumerSecret = "YOUR_CONSUMER_SECRET";
            string accessToken = "YOUR_ACCESS_TOKEN";
            string accessTokenSecret = "YOUR_ACCESS_TOKEN_SECRET";

            string hashtag = "datascience";
            int count = 100;

            ProcessStartInfo start = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"-c \"import sys; sys.path.append('C:\\\\Python27\\\\Lib\\\\site-packages'); import tweepy; "
                            + "from textblob import TextBlob;"
                            + $"consumer_key = '{consumerKey}'; consumer_secret = '{consumerSecret}'; "
                            + $"access_token = '{accessToken}'; access_token_secret = '{accessTokenSecret}'; "
                            + "auth = tweepy.OAuthHandler(consumer_key, consumer_secret); "
                            + "auth.set_access_token(access_token, access_token_secret); "
                            + "api = tweepy.API(auth); "
                            + $"public_tweets = api.search(q=\\\"#{hashtag}\\\", count={count}); "
                            + "for tweet in public_tweets: "
                            + "    analysis = TextBlob(tweet.text); "
                            + "    print(tweet.text, analysis.sentiment)\n"
            };

            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using(Process process = Process.Start(start))
            {
                using(StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }

            Console.ReadLine();
        }
    }
}
