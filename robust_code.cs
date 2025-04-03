
using HtmlAgilityPack;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var url = "https://www.website.com";
        var web = new HtmlWeb();
        var doc = web.Load(url);

        var tables = doc.DocumentNode.SelectNodes("//table");
        
        foreach (var table in tables)
        {
            var rows = table.SelectNodes(".//tr");
            
            foreach (var row in rows)
            {
                var cells = row.SelectNodes(".//td|.//th");
                
                foreach (var cell in cells)
                {
                    Console.Write(cell.InnerText.Trim() + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
