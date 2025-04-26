
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        string url = "http://example.com"; // URL of the website to scrape

        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//h2"); // Get all h2 elements on the webpage

        if (nodes != null)
        {
            foreach (HtmlNode node in nodes)
            {
                Console.WriteLine(node.InnerText); // Output the inner text of each h2 element
            }
        }
        else
        {
            Console.WriteLine("No h2 elements found on the webpage.");
        }
    }
}
