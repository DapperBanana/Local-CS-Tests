
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://example.com"; // URL of the web page containing the table

        HtmlWeb web = new HtmlWeb();
        var doc = web.Load(url);

        HtmlNode table = doc.DocumentNode.SelectSingleNode("//table");

        if (table != null)
        {
            foreach (HtmlNode row in table.SelectNodes("tr"))
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
            Console.WriteLine("Table not found on the web page.");
        }
    }
}
