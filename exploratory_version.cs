
using HtmlAgilityPack;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument document = web.Load("https://www.w3schools.com/html/html_tables.asp");

        HtmlNode table = document.DocumentNode.SelectSingleNode("//table");

        if (table != null)
        {
            foreach (HtmlNode row in table.SelectNodes("tr"))
            {
                foreach (HtmlNode cell in row.SelectNodes("th|td"))
                {
                    Console.Write(cell.InnerText.Trim() + " ");
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
