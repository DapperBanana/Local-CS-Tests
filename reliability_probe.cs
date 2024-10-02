
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://example.com";
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        // Get all tables from the HTML document
        var tables = doc.DocumentNode.SelectNodes("//table");

        if (tables != null)
        {
            foreach (var table in tables)
            {
                // Parse and extract data from each table
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
            Console.WriteLine("No tables found on the web page.");
        }
    }
}
