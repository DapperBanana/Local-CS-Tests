
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();

        string url = "https://jsonplaceholder.typicode.com/posts";
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
        else
        {
            Console.WriteLine("Failed to retrieve data. Status code: " + response.StatusCode);
        }
    }
}
