
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://example.com"; // URL of the website to scrape

        WebClient client = new WebClient();
        string html = client.DownloadString(url);

        // Extracting information from the HTML content
        ExtractInformation(html);
    }

    static void ExtractInformation(string html)
    {
        // Here you can implement the logic to extract specific information from the HTML content
        // For example, extracting all the links from the HTML content
        int startIndex, endIndex;
        while ((startIndex = html.IndexOf("<a href=")) != -1)
        {
            startIndex = html.IndexOf("\"", startIndex) + 1;
            endIndex = html.IndexOf("\"", startIndex);
            string link = html.Substring(startIndex, endIndex - startIndex);
            
            Console.WriteLine("Link: " + link);
            html = html.Substring(endIndex);
        }
    }
}
