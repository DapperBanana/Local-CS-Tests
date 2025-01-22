
using System;
using System.Net;

class Program
{
    static void Main()
    {
        // URL of the website to scrape
        string url = "https://www.example.com";
        
        // Create a WebClient to download the website content
        WebClient client = new WebClient();
        
        // Download the website content as a string
        string html = client.DownloadString(url);
        
        // Print the website content to the console
        Console.WriteLine(html);
        
        // Extract specific information from the website content
        // For example, extracting the title of the website
        int start = html.IndexOf("<title>") + 7;
        int end = html.IndexOf("</title>");
        string title = html.Substring(start, end - start);
        
        // Print the extracted information to the console
        Console.WriteLine("Title: " + title);
        
        // Close the WebClient
        client.Dispose();
    }
}
