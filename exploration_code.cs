
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // URL of the website to scrape
        string url = "https://www.example.com";

        // Create a new HtmlWeb instance and load the website content
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        // Extract information from the website
        HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//h2[@class='title']");

        if (nodes != null)
        {
            Console.WriteLine("Scraped information:");
            foreach (HtmlNode node in nodes)
            {
                Console.WriteLine(node.InnerText);
            }
        }
        else
        {
            Console.WriteLine("No information found.");
        }
    }
}
