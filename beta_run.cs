// Note: BeautifulSoup is a Python library and cannot be used directly in C#.
// In C#, you can perform HTML parsing and data extraction using libraries like HtmlAgilityPack.
// Here's an example of how to extract data from HTML tables using HtmlAgilityPack:

using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com"; // replace with your URL
        var httpClient = new HttpClient();
        string htmlContent = await httpClient.GetStringAsync(url);

        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(htmlContent);

        // Select all tables in the HTML document
        var tables = htmlDoc.DocumentNode.SelectNodes("//table");
        if (tables != null)
        {
            int tableIndex = 1;
            foreach (var table in tables)
            {
                Console.WriteLine($"Table {tableIndex}:");
                // Extract table headers
                var headerNodes = table.SelectNodes(".//th");
                string[] headers;
                if (headerNodes != null)
                {
                    headers = new string[headerNodes.Count];
                    for (int i = 0; i < headerNodes.Count; i++)
                    {
                        headers[i] = headerNodes[i].InnerText.Trim();
                        Console.Write($"{headers[i]}\t");
                    }
                    Console.WriteLine();
                }
                else
                {
                    // No headers present
                    headers = null;
                }

                // Extract table rows
                var rows = table.SelectNodes(".//tr");
                if (rows != null)
                {
                    foreach (var row in rows)
                    {
                        var cells = row.SelectNodes("./td");
                        if (cells != null)
                        {
                            for (int i = 0; i < cells.Count; i++)
                            {
                                string cellText = cells[i].InnerText.Trim();
                                Console.Write($"{cellText}\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine(); // Separator between tables
                tableIndex++;
            }
        }
        else
        {
            Console.WriteLine("No tables found in the HTML document.");
        }
    }
}