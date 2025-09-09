
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://en.wikipedia.org/wiki/List_of_countries_by_population_(United_Nations)";
        var web = new HtmlWeb();
        var doc = web.Load(url);

        var tables = doc.DocumentNode.SelectNodes("//table");

        foreach (var table in tables)
        {
            var rows = table.SelectNodes(".//tr");

            foreach (var row in rows)
            {
                var cells = row.SelectNodes(".//td");

                if (cells != null)
                {
                    foreach (var cell in cells)
                    {
                        Console.Write(cell.InnerText + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
