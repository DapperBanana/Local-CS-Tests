
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("data.xml");

        // Get the root element
        XmlElement root = xmlDoc.DocumentElement;

        // Get specific information from the XML file
        XmlNodeList nodes = root.SelectNodes("//book");
        
        // Iterate through each book node and extract specific information
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
