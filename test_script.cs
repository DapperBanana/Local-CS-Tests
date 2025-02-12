
using System;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the XML file
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");

            // Get the root element
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("//book");

            // Loop through each book node and extract specific information
            foreach (XmlNode node in nodes)
            {
                string title = node.SelectSingleNode("title").InnerText;
                string author = node.SelectSingleNode("author").InnerText;
                string genre = node.SelectSingleNode("genre").InnerText;

                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Genre: " + genre);
                Console.WriteLine();
            }
        }
    }
}
