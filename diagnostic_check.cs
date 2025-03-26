
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JSONAPIExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";
            
            HttpClient client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            
            if(response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                
                // You can now parse and process the JSON data here
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Error fetching data from API. Status code: " + response.StatusCode);
            }
        }
    }
}
