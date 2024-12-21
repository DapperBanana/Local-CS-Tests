
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("file.xml");

        // Find all elements with the specified tag name
        XmlNodeList nodes = doc.GetElementsByTagName("book");

        // Loop through each book node and extract information
        foreach (XmlNode node in nodes)
        {
            string title = node.SelectSingleNode("title").InnerText;
            string author = node.SelectSingleNode("author").InnerText;
            string genre = node.SelectSingleNode("genre").InnerText;
            string price = node.SelectSingleNode("price").InnerText;

            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Price: " + price);
            Console.WriteLine();
        }
    }
}
