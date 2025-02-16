
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com";
        
        WebClient webClient = new WebClient();
        string html = webClient.DownloadString(url);
        
        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);
        
        var table = doc.DocumentNode.SelectSingleNode("//table");
        
        if (table != null)
        {
            foreach (HtmlNode row in table.SelectNodes("tr"))
            {
                foreach (HtmlNode cell in row.SelectNodes("th|td"))
                {
                    Console.Write(cell.InnerText.Trim() + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
