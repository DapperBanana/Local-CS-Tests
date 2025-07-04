
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        // Specify the URL of the web page containing the HTML table
        string url = "https://example.com/table.html";

        // Create a new HtmlWeb instance and load the web page
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);

        // Find the HTML table element by its ID
        HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[@id='tableId']");

        // Iterate through each row in the table
        foreach (HtmlNode row in table.SelectNodes("tr"))
        {
            // Iterate through each cell in the row
            foreach (HtmlNode cell in row.SelectNodes("th|td"))
            {
                // Extract the text content of the cell and print it
                Console.Write(cell.InnerText + "\t");
            }

            Console.WriteLine(); // Move to the next row
        }
    }
}
