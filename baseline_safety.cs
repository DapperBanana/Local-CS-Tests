using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class WebScraper
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com"; // Replace with the target website URL
        try
        {
            string pageContent = await FetchWebPageAsync(url);
            var extractedInfo = ExtractInformation(pageContent);
            Console.WriteLine("Extracted Information:");
            Console.WriteLine(extractedInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static async Task<string> FetchWebPageAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // Optional: set user agent header
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; BasicWebScraper/1.0)");
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }

    static string ExtractInformation(string htmlContent)
    {
        // Example: Extract all the titles inside <title> tags
        Match match = Regex.Match(htmlContent, "<title>(.*?)</title>", RegexOptions.IgnoreCase);
        if (match.Success)
        {
            return $"Page Title: {match.Groups[1].Value}";
        }
        else
        {
            return "Title not found.";
        }
    }
}