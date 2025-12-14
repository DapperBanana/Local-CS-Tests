using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com"; // Replace with target website URL

        try
        {
            // Initialize HttpClient
            using HttpClient client = new HttpClient();

            // Download HTML content
            string htmlContent = await client.GetStringAsync(url);

            // Load HTML into HtmlAgilityPack
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlContent);

            // Example: Extract all links from the page
            var links = doc.DocumentNode.SelectNodes("//a[@href]");
            if (links != null)
            {
                foreach (var link in links)
                {
                    string href = link.GetAttributeValue("href", string.Empty);
                    string text = link.InnerText.Trim();
                    Console.WriteLine($"Link Text: {text} | Href: {href}");
                }
            }
            else
            {
                Console.WriteLine("No links found on the webpage.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}