using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class WebScraper
{
    static async Task Main(string[] args)
    {
        string url = "https://example.com"; // Replace with target website URL

        try
        {
            string htmlContent = await FetchHtmlAsync(url);
            string extractedInfo = ExtractInformation(htmlContent);
            Console.WriteLine("Extracted Information:");
            Console.WriteLine(extractedInfo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static async Task<string> FetchHtmlAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            return await client.GetStringAsync(url);
        }
    }

    static string ExtractInformation(string html)
    {
        // Example: Extract all <h1> tags content
        MatchCollection matches = Regex.Matches(html, "<h1>(.*?)</h1>", RegexOptions.IgnoreCase);
        string result = "";
        foreach (Match match in matches)
        {
            result += match.Groups[1].Value + Environment.NewLine;
        }
        return result;
    }
}