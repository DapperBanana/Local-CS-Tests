
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        //Enter the URL you want to scrape
        string url = "https://example.com";

        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        //Select the elements you want to scrape using XPath
        var titleNode = doc.DocumentNode.SelectSingleNode("//title");
        var headingNodes = doc.DocumentNode.SelectNodes("//h1 | //h2 | //h3");

        if (titleNode != null)
        {
            Console.WriteLine("Title: " + titleNode.InnerText);
        }

        if (headingNodes != null)
        {
            foreach (var headingNode in headingNodes)
            {
                Console.WriteLine("Heading: " + headingNode.InnerText);
            }
        }

        // You can add more XPath queries to extract more information from the website

    }
}
