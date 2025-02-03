
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

        // Iterate through each child node
        foreach (XmlNode node in root.ChildNodes)
        {
            if (node.Name == "book")
            {
                // Extract information from the book node
                string title = node["title"].InnerText;
                string author = node["author"].InnerText;
                string genre = node["genre"].InnerText;

                // Display the extracted information
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Genre: " + genre);
                Console.WriteLine();
            }
        }
    }
}
