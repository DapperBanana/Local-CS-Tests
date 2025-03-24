
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        // Load webpage into HtmlDocument
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://example.com");

        // Find all HTML tables in the document
        HtmlNodeCollection tables = doc.DocumentNode.SelectNodes("//table");

        if (tables != null)
        {
            foreach (HtmlNode table in tables)
            {
                // Extract data from each table
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        Console.Write(cell.InnerText + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("No tables found on the page.");
        }
    }
}
