
using HtmlAgilityPack;
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var url = "https://www.example.com/table.html";

        var httpClient = new HttpClient();
        var html = await httpClient.GetStringAsync(url);

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        var table = doc.DocumentNode.SelectSingleNode("//table");
        var rows = table.SelectNodes("tr");

        foreach (var row in rows)
        {
            var cells = row.SelectNodes("th|td");
            foreach (var cell in cells)
            {
                Console.Write(cell.InnerText.Trim() + '\t');
            }
            Console.WriteLine();
        }
    }
}
