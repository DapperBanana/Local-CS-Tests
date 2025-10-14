
using System;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";
        
        using (WebClient client = new WebClient())
        {
            string jsonData = client.DownloadString(apiUrl);
            dynamic data = JsonConvert.DeserializeObject(jsonData);
            
            Console.WriteLine("Post ID: {0}", data.id);
            Console.WriteLine("User ID: {0}", data.userId);
            Console.WriteLine("Title: {0}", data.title);
            Console.WriteLine("Body: {0}", data.body);
        }        
    }
}
