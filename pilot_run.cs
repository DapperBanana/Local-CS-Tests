
using System;
using System.Net.Http;
using Newtonsoft.Json;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        
        string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";
        HttpResponseMessage response = await client.GetAsync(apiUrl);
        
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject(json);
            
            Console.WriteLine("Data fetched from API:");
            Console.WriteLine($"User ID: {data.userId}");
            Console.WriteLine($"ID: {data.id}");
            Console.WriteLine($"Title: {data.title}");
            Console.WriteLine($"Completed: {data.completed}");
        }
        else
        {
            Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
        }
    }
}
