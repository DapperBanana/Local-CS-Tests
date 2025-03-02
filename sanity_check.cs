
using HtmlAgilityPack;
using System;

class Program
{
    static void Main()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://example.com");

        HtmlNodeCollection titleNodes = doc.DocumentNode.SelectNodes("//title");
        foreach (var node in titleNodes)
        {
            Console.WriteLine("Title: " + node.InnerText);
        }

        HtmlNodeCollection paragraphNodes = doc.DocumentNode.SelectNodes("//p");
        foreach (var node in paragraphNodes)
        {
            Console.WriteLine("Paragraph: " + node.InnerText);
        }
    }
}
