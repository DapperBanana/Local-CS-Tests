// Note: BeautifulSoup is a Python library. For HTML parsing in C#, a popular alternative is HtmlAgilityPack.
// Below is a C# example using HtmlAgilityPack to extract data from HTML tables.

using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        var url = "https://example.com"; // Replace with your target URL
        var html = await FetchHtmlAsync(url);
        var tableData = ExtractTableData(html, "//table"); // XPath to target the table(s)

        foreach (var row in tableData)
        {
            Console.WriteLine(string.Join("\t", row));
        }
    }

    static async Task<string> FetchHtmlAsync(string url)
    {
        using (var client = new HttpClient())
        {
            return await client.GetStringAsync(url);
        }
    }

    static System.Collections.Generic.List<System.Collections.Generic.List<string>> ExtractTableData(string html, string tableXPath)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);
        var tableNodes = doc.DocumentNode.SelectNodes(tableXPath);

        var tablesData = new System.Collections.Generic.List<System.Collections.Generic.List<string>>();

        if (tableNodes != null)
        {
            foreach (var table in tableNodes)
            {
                var tableRows = new System.Collections.Generic.List<string>();
                foreach (var row in table.SelectNodes(".//tr"))
                {
                    var cells = row.SelectNodes(".//th|.//td");
                    if (cells != null)
                    {
                        var rowData = new System.Collections.Generic.List<string>();
                        foreach (var cell in cells)
                        {
                            rowData.Add(cell.InnerText.Trim());
                        }
                        tableRows.Add(string.Join(" | ", rowData));
                    }
                }
                tablesData.Add(tableRows);
            }
        }

        return tablesData;
    }
}