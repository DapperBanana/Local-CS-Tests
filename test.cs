
using HtmlAgilityPack;
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://www.example.com"; // Website URL to scrape

        // Download the HTML content of the website
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        // Extract specific information from the website
        var title = doc.DocumentNode.SelectSingleNode("//title").InnerText;
        var paragraphs = doc.DocumentNode.SelectNodes("//p");

        // Display the extracted information
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Paragraphs:");
        foreach (var p in paragraphs)
        {
            Console.WriteLine(p.InnerText);
        }
    }
}
