
using HtmlAgilityPack;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var url = "https://example.com"; // URL of the web page with the HTML table

        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        var table = doc.DocumentNode.SelectSingleNode("//table"); // Assuming there is only one table on the page
        var rows = table.SelectNodes("tr");

        foreach (var row in rows)
        {
            var cells = row.SelectNodes("td");
            if (cells != null)
            {
                List<string> rowData = new List<string>();
                foreach (var cell in cells)
                {
                    rowData.Add(cell.InnerText.Trim());
                }
                Console.WriteLine(string.Join(", ", rowData));
            }
        }
    }
}
