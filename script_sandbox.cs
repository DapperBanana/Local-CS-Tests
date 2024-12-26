
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

        // Get all elements with a specific tag name
        XmlNodeList nodes = root.GetElementsByTagName("book");

        // Iterate over each node and extract specific information
        foreach(XmlNode node in nodes)
        {
            string title = node["title"].InnerText;
            string author = node["author"].InnerText;
            int year = int.Parse(node["year"].InnerText);

            Console.WriteLine("Title: {0}, Author: {1}, Year: {2}", title, author, year);
        }
    }
}
