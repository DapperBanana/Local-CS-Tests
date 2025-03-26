
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        WebClient client = new WebClient();
        string url = "https://www.example.com";
        string htmlCode = client.DownloadString(url);

        // Extract information from the HTML code
        // For example, extracting the title of the website
        int titleStartIndex = htmlCode.IndexOf("<title>") + 7;
        int titleEndIndex = htmlCode.IndexOf("</title>");
        string title = htmlCode.Substring(titleStartIndex, titleEndIndex - titleStartIndex);

        Console.WriteLine("Title of the website: " + title);
    }
}
