
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.w3schools.com/html/html_tables.asp";
        
        WebClient client = new WebClient();
        string html = client.DownloadString(url);

        HtmlDocument doc = new HtmlDocument();
        doc.LoadHtml(html);

        HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[@id='customers']");
        
        if(table != null)
        {
            foreach(HtmlNode row in table.SelectNodes("tr"))
            {
                foreach(HtmlNode cell in row.SelectNodes("th|td"))
                {
                    Console.Write(cell.InnerText.Trim() + "\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Table with id 'customers' not found in the webpage.");
        }
    }
}
