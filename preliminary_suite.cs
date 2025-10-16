
using HtmlAgilityPack;
using System;
using System.Linq;

namespace HTMLTableExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("http://example.com");

            var tables = doc.DocumentNode.Descendants("table");

            foreach (var table in tables)
            {
                var rows = table.Descendants("tr");

                foreach (var row in rows)
                {
                    var cells = row.Descendants("td");

                    foreach (var cell in cells)
                    {
                        Console.Write(cell.InnerText.Trim() + "\t");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
