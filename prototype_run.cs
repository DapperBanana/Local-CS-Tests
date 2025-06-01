
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://example.com";
        
        WebClient client = new WebClient();
        string htmlCode = client.DownloadString(url);
        
        // Extracting title from the HTML code
        int startIndex = htmlCode.IndexOf("<title>") + 7;
        int endIndex = htmlCode.IndexOf("</title>");
        string title = htmlCode.Substring(startIndex, endIndex - startIndex);
        
        // Extracting body text from the HTML code
        int startBodyIndex = htmlCode.IndexOf("<body>") + 6;
        int endBodyIndex = htmlCode.IndexOf("</body>");
        string bodyText = htmlCode.Substring(startBodyIndex, endBodyIndex - startBodyIndex);
        
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Body Text: " + bodyText);
    }
}
