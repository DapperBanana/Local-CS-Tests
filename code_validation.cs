
using System;
using System.Net;
using Newtonsoft.Json;

namespace JsonApiExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";
            
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(apiUrl);
                dynamic data = JsonConvert.DeserializeObject(json);

                foreach (var item in data)
                {
                    Console.WriteLine($"Title: {item.title}");
                    Console.WriteLine($"Body: {item.body}");
                    Console.WriteLine();
                }
            }
        }
    }
}
