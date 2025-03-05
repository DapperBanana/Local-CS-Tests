
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
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(json);

                foreach (var item in data)
                {
                    Console.WriteLine("Post ID: {0}", item.id);
                    Console.WriteLine("Title: {0}", item.title);
                    Console.WriteLine("Body: {0}", item.body);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve data: {0}", response.ReasonPhrase);
            }
        }
    }
}
