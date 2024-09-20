
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";
        
        HttpClient client = new HttpClient();
        
        HttpResponseMessage response = await client.GetAsync(apiUrl);
        
        if(response.IsSuccessStatusCode)
        {
            string data = await response.Content.ReadAsStringAsync();
            Console.WriteLine(data);
        }
        else
        {
            Console.WriteLine("Failed to retrieve data from API. Status code: " + response.StatusCode);
        }
        
        client.Dispose();
    }
}
