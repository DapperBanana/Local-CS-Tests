
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("http://example.com");
        
        foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
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
    }
}
