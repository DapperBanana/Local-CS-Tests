
using System;
using System.Net;
using System.IO;

public class Program
{
    public static void Main()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        
        WebRequest request = WebRequest.Create(apiUrl);
        WebResponse response = request.GetResponse();
        
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseData = reader.ReadToEnd();
            Console.WriteLine(responseData);
        }
        
        response.Close();
    }
}
