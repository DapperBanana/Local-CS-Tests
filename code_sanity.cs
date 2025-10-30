
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            HttpResponseMessage response = await client.GetAsync("/posts");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                dynamic jsonData = JsonConvert.DeserializeObject(data);

                foreach (var item in jsonData)
                {
                    Console.WriteLine($"Post ID: {item.id}");
                    Console.WriteLine($"Title: {item.title}");
                    Console.WriteLine($"Body: {item.body}\n");
                }
            }
            else
            {
                Console.WriteLine("Failed to get data. API returned: " + response.StatusCode);
            }
        }
    }
}
