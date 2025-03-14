
using HtmlAgilityPack;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var web = new HtmlWeb();
        var doc = web.Load("https://www.example.com");

        var table = doc.DocumentNode.SelectSingleNode("//table[@id='table_id']");
        
        if(table != null)
        {
            foreach (var row in table.SelectNodes("tr"))
            {
                var cells = row.SelectNodes("td");
                if (cells != null && cells.Count > 0)
                {
                    foreach (var cell in cells)
                    {
                        Console.Write(cell.InnerText + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
