
using HtmlAgilityPack;
using System;

namespace HTMLTableExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://www.w3schools.com/html/html_tables.asp");

            HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[@class='w3-table-all']");
            if (table != null)
            {
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    int colCount = 0;
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        Console.WriteLine("Row {0}, Column {1}: {2}", row.Line, colCount, cell.InnerText.Trim());
                        colCount++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Table not found on the page.");
            }
        }
    }
}
