
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("http://example.com");

        // Find all tables in the HTML document
        var tables = doc.DocumentNode.SelectNodes("//table");

        if (tables != null)
        {
            foreach (var table in tables)
            {
                // Extract data from each table
                var rows = table.SelectNodes(".//tr");

                if (rows != null)
                {
                    foreach (var row in rows)
                    {
                        var cells = row.SelectNodes(".//th|.//td");

                        if (cells != null)
                        {
                            var data = cells.Select(cell => cell.InnerText.Trim()).ToList();
                            Console.WriteLine(string.Join(", ", data));
                        }
                    }
                }
            }
        }
    }
}
