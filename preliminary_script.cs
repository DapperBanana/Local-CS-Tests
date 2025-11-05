
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            response.EnsureSuccessStatusCode(); // Throw an exception if the request was not successful

            string responseBody = await response.Content.ReadAsStringAsync();
            JArray posts = JArray.Parse(responseBody);

            foreach (JObject post in posts)
            {
                Console.WriteLine("Title: " + post["title"]);
                Console.WriteLine("Body: " + post["body"]);
                Console.WriteLine();
            }
        }
    }
}
