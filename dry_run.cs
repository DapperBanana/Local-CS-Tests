
using System;
using System.Net.Http;
using System.Threading.Tasks;

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
                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Failed to retrieve data from API: " + response.ReasonPhrase);
            }
        }
    }
}
