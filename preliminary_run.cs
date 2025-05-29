
using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        using (var client = new HttpClient())
        {
            string url = "https://www.example.com";
            var response = await client.GetAsync(url);
            string html = await response.Content.ReadAsStringAsync();

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            Console.WriteLine("Title:");
            var titleNode = htmlDocument.DocumentNode.SelectSingleNode("//title");
            if (titleNode != null)
            {
                Console.WriteLine(titleNode.InnerText);
            }
            else
            {
                Console.WriteLine("Title not found");
            }

            Console.WriteLine("\nLinks:");
            var linkNodes = htmlDocument.DocumentNode.SelectNodes("//a[@href]");
            if (linkNodes != null)
            {
                foreach (var linkNode in linkNodes)
                {
                    Console.WriteLine(linkNode.Attributes["href"].Value);
                }
            }
            else
            {
                Console.WriteLine("No links found");
            }
        }
    }
}
