
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://example.com";
        
        WebClient client = new WebClient();
        string html = client.DownloadString(url);
        
        // Extracting information from the website
        // For example, extracting all links from the website
        string[] links = ExtractLinks(html);
        
        // Display the extracted links
        foreach (string link in links)
        {
            Console.WriteLine(link);
        }
    }
    
    static string[] ExtractLinks(string html)
    {
        // Example of extracting links from the HTML
        // This is a basic example and may need to be adjusted based on the structure of the website
        // Regular expressions or HTML parsers can be used for more complex extraction tasks
        string[] splitHtml = html.Split(new[] { "href=\"" }, StringSplitOptions.None);
        string[] links = new string[splitHtml.Length - 1];
        
        for (int i = 1; i < splitHtml.Length; i++)
        {
            int endIndex = splitHtml[i].IndexOf("\"");
            links[i - 1] = splitHtml[i].Substring(0, endIndex);
        }
        
        return links;
    }
}
