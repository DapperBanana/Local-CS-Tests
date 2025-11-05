
using System;
using System.Net;
using System.IO;

class Program
{
    static void Main()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        
        if (response.StatusCode == HttpStatusCode.OK)
        {
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            
            Console.WriteLine(responseFromServer);
            
            reader.Close();
            dataStream.Close();
            response.Close();
        }
        else
        {
            Console.WriteLine("Error: " + response.StatusCode);
        }
    }
}
