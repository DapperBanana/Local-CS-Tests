
using System;
using System.Net;
using System.IO;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        string url = "https://www.w3schools.com/html/html_tables.asp";

        var webRequest = WebRequest.Create(url);
        var webResponse = webRequest.GetResponse();
        var webStream = webResponse.GetResponseStream();
        var reader = new StreamReader(webStream);
        var html = reader.ReadToEnd();

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        var table = doc.DocumentNode.SelectSingleNode("//table[@id='customers']");
        var rows = table.SelectNodes(".//tr");

        foreach (var row in rows)
        {
            var cells = row.SelectNodes(".//td");
            if (cells != null)
            {
                foreach (var cell in cells)
                {
                    Console.Write(cell.InnerText + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
