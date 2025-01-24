
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://www.example.com";
        
        WebClient client = new WebClient();
        string htmlCode = client.DownloadString(url);
        
        // Extract information from the HTML code here
        
        Console.WriteLine(htmlCode);
    }
}
