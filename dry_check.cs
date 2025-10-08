
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            HttpResponseMessage response = await client.GetAsync("/todos");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Failed to fetch data from API. Status code: " + response.StatusCode);
            }
        }
    }
}
