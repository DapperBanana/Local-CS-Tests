
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://api.example.com/");
            HttpResponseMessage response = await client.GetAsync("data");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Failed to fetch data: " + response.ReasonPhrase);
            }
        }
    }
}
