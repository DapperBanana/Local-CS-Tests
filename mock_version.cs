
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("sample.xml");

        // Get the root element
        XmlElement root = doc.DocumentElement;

        // Get a specific node by tag name
        XmlNodeList nodes = root.GetElementsByTagName("book");

        // Loop through each node and extract information
        foreach (XmlNode node in nodes)
        {
            XmlNode titleNode = node.SelectSingleNode("title");
            XmlNode authorNode = node.SelectSingleNode("author");
            XmlNode genreNode = node.SelectSingleNode("genre");

            string title = titleNode.InnerText;
            string author = authorNode.InnerText;
            string genre = genreNode.InnerText;

            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine();
        }
    }
}
