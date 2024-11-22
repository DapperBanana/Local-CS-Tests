
using System;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        // URL of the website to scrape
        string url = "https://example.com";
        
        // Load website content
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);
        
        // Extract information
        var titleNode = doc.DocumentNode.SelectSingleNode("//title");
        var paragraphs = doc.DocumentNode.SelectNodes("//p");
        
        // Print out extracted information
        Console.WriteLine("Title: " + titleNode.InnerText);
        Console.WriteLine("Paragraphs:");
        foreach (var p in paragraphs)
        {
            Console.WriteLine(p.InnerText);
        }
    }
}
