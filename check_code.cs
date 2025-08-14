
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://www.example.com";
        
        WebClient client = new WebClient();
        string htmlContent = client.DownloadString(url);

        int startIndex = htmlContent.IndexOf("<title>") + 7;
        int endIndex = htmlContent.IndexOf("</title>");
        string title = htmlContent.Substring(startIndex, endIndex - startIndex);

        Console.WriteLine("Title: " + title);
    }
}
