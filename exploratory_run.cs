
using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace JSONAPIReader
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/posts/1"; // example JSON API URL

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);

                int id = (int)data["id"];
                string title = data["title"].ToString();
                string body = data["body"].ToString();

                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Body: {body}");
            }
            else
            {
                Console.WriteLine("Failed to retrieve data from the API");
            }
        }
    }
}
