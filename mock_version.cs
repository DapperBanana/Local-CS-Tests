
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
            
            HttpResponseMessage response = await client.GetAsync("posts");
            
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
            }
        }
    }
}
