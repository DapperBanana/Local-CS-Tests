
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
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(responseBody);

                foreach (var item in data)
                {
                    Console.WriteLine("Title: " + item.title);
                    Console.WriteLine("Body: " + item.body);
                    Console.WriteLine("-----------------------------");
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve data from API. Status code: " + response.StatusCode);
            }
        }
    }
}
