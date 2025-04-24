
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        var url = "https://www.example.com/table.html";
        
        var web = new HtmlWeb();
        var doc = web.Load(url);
        
        var table = doc.DocumentNode.SelectSingleNode("//table");
        
        if(table != null)
        {
            var rows = table.SelectNodes(".//tr");
            
            foreach(var row in rows)
            {
                var cells = row.SelectNodes(".//td");
                
                foreach(var cell in cells)
                {
                    Console.Write(cell.InnerText + "\t");
                }
                
                Console.WriteLine();
            }
        }
    }
}
