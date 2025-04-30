
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com";
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);
        
        HtmlNodeCollection tables = doc.DocumentNode.SelectNodes("//table");
        
        if (tables != null)
        {
            foreach (HtmlNode table in tables)
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
        }
    }
}
