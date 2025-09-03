
using System;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string url = "https://jsonplaceholder.typicode.com/posts/1";
        
        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(url);
            dynamic data = JsonConvert.DeserializeObject(json);
            
            Console.WriteLine("Title: " + data.title);
            Console.WriteLine("Body: " + data.body);
        }
    }
}
