
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://example.com");

        HtmlNode tableNode = doc.DocumentNode.SelectSingleNode("//table");

        if (tableNode != null)
        {
            foreach (HtmlNode row in tableNode.SelectNodes("tr"))
            {
                foreach (HtmlNode cell in row.SelectNodes("th|td"))
                {
                    Console.Write(cell.InnerText + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No table found on the web page.");
        }
    }
}
