
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        // Load the HTML document from a URL
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("http://example.com/table.html");

        // Select the table element by its class name
        var table = doc.DocumentNode.SelectSingleNode("//table[@class='table-class']");

        // Loop through each row in the table and extract data from each cell
        if (table != null)
        {
            foreach (var row in table.SelectNodes("tr"))
            {
                foreach (var cell in row.SelectNodes("td"))
                {
                    Console.Write(cell.InnerText + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Table not found.");
        }
    }
}
