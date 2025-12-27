using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

class WebScraper
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com"; // Replace with the target website URL
        var htmlContent = await FetchHtmlAsync(url);
        if (htmlContent != null)
        {
            ExtractAndDisplayInfo(htmlContent);
        }
        else
        {
            Console.WriteLine("Failed to retrieve content.");
        }
    }

    static async Task<string> FetchHtmlAsync(string url)
    {
        try
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching HTML: {ex.Message}");
            return null;
        }
    }

    static void ExtractAndDisplayInfo(string html)
    {
        var htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(html);

        // Example: Extract all the href attributes from anchor tags
        var links = htmlDoc.DocumentNode.SelectNodes("//a[@href]");
        if (links != null)
        {
            Console.WriteLine("Found links:");
            foreach (var link in links)
            {
                string href = link.GetAttributeValue("href", "");
                Console.WriteLine(href);
            }
        }
        else
        {
            Console.WriteLine("No links found.");
        }
    }
}