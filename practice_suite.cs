
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com";
        WebClient client = new WebClient();
        string html = client.DownloadString(url);

        // Extracting information from the HTML content
        string title = GetTitle(html);
        string body = GetBody(html);

        Console.WriteLine("Title: " + title);
        Console.WriteLine("Body: " + body);
    }

    static string GetTitle(string html)
    {
        int startIndex = html.IndexOf("<title>") + "<title>".Length;
        int endIndex = html.IndexOf("</title>");
        return html.Substring(startIndex, endIndex - startIndex);
    }

    static string GetBody(string html)
    {
        int startIndex = html.IndexOf("<body>") + "<body>".Length;
        int endIndex = html.IndexOf("</body>");
        return html.Substring(startIndex, endIndex - startIndex);
    }
}
