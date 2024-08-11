
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Twitter handle of the user you want to analyze:");
            string userHandle = Console.ReadLine();

            var client = new HttpClient();
            var response = client.GetAsync($"https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name={userHandle}&count=100").Result;
            var tweets = response.Content.ReadAsStringAsync().Result;

            dynamic jsonTweets = JsonConvert.DeserializeObject(tweets);

            double totalSentiment = 0;

            foreach (var tweet in jsonTweets)
            {
                string text = tweet.text.ToString();
                double sentiment = PerformSentimentAnalysis(text);
                totalSentiment += sentiment;
            }

            double averageSentiment = totalSentiment / jsonTweets.Count;
            Console.WriteLine($"Average sentiment for user {userHandle}: {averageSentiment}");
        }

        static double PerformSentimentAnalysis(string text)
        {
            // Perform sentiment analysis using TextBlob or any other library
            // For TextBlob example, refer to: https://textblob.readthedocs.io/en/dev/quickstart.html#categorical-analysis

            return 0.5; // dummy value for demonstration
        }
    }
}
