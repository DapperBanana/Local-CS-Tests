
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        WebClient client = new WebClient();
        string url = "https://example.com";
        string htmlCode = client.DownloadString(url);

        // Extract information from the HTML code
        // For example, let's extract the title of the website
        int startIndex = htmlCode.IndexOf("<title>") + 7;
        int endIndex = htmlCode.IndexOf("</title>");
        string title = htmlCode.Substring(startIndex, endIndex - startIndex);

        Console.WriteLine("Title: " + title);

        // You can add more code here to extract other information from the website
    }
}
