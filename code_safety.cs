
using HtmlAgilityPack;
using System;
using System.Net;

class Program
{
    static void Main()
    {
        string url = "https://www.example.com";
        
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);
        
        HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");
        string title = titleNode.InnerText;
        
        Console.WriteLine("Title: " + title);
        
        HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//a[@href]");
        foreach (var linkNode in linkNodes)
        {
            string link = linkNode.GetAttributeValue("href", "");
            Console.WriteLine("Link: " + link);
        }
    }
}
