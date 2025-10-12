
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(json);

                foreach (var post in data)
                {
                    Console.WriteLine("Post ID: " + post.id);
                    Console.WriteLine("Title: " + post.title);
                    Console.WriteLine("Body: " + post.body);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
            }
        }
    }
}
