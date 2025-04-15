
using System;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://www.example.com");

        var table = doc.DocumentNode.SelectSingleNode("//table");

        if (table != null)
        {
            foreach (HtmlNode row in table.SelectNodes("tr"))
            {
                foreach (HtmlNode cell in row.SelectNodes("th|td"))
                {
                    Console.Write(cell.InnerText + "\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Table not found");
        }
    }
}
