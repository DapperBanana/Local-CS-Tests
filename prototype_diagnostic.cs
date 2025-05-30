
using HtmlAgilityPack;
using System;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            // URL of the website to scrape
            string url = "https://example.com";
            
            // Create HtmlWeb instance
            HtmlWeb web = new HtmlWeb();
            
            // Load the HTML document from the URL
            HtmlDocument document = web.Load(url);
            
            // Select the nodes containing the information you want to scrape
            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//div[@class='content']");
            
            if (nodes != null)
            {
                foreach (HtmlNode node in nodes)
                {
                    // Extract the text from the nodes
                    string text = node.InnerText.Trim();
                    Console.WriteLine(text);
                }
            }
            else
            {
                Console.WriteLine("No content found.");
            }
        }
    }
}
