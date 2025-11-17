
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        // Get the root element
        XmlElement root = doc.DocumentElement;

        // Get a list of all elements with a specific tag name
        XmlNodeList nodeList = root.GetElementsByTagName("book");

        // Iterate through the list and extract specific information
        foreach (XmlNode node in nodeList)
        {
            string title = node["title"].InnerText;
            string author = node["author"].InnerText;
            string genre = node["genre"].InnerText;
            string price = node["price"].InnerText;

            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Price: " + price);
            Console.WriteLine();
        }
    }
}
