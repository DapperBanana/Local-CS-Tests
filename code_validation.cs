
using HtmlAgilityPack;
using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        string url = "https://www.example.com";

        using (WebClient client = new WebClient())
        {
            string html = client.DownloadString(url);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//div[@class='product']");
        
            if (nodes != null)
            {
                foreach (HtmlNode node in nodes)
                {
                    string productName = node.SelectSingleNode("h2").InnerText;
                    string productPrice = node.SelectSingleNode("span[@class='price']").InnerText;

                    Console.WriteLine("Product Name: " + productName);
                    Console.WriteLine("Product Price: " + productPrice);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No products found on the page.");
            }
        }
    }
}
