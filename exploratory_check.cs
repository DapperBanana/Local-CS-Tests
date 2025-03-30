
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://example.com");

        HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[@class='my-table-class']");
        
        if(table != null)
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
