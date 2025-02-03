
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        // Get a list of all the <book> nodes in the XML file
        XmlNodeList bookNodes = doc.GetElementsByTagName("book");

        // Loop through each <book> node and extract the information
        foreach (XmlNode bookNode in bookNodes)
        {
            // Get the title of the book
            string title = bookNode.SelectSingleNode("title").InnerText;

            // Get the author of the book
            string author = bookNode.SelectSingleNode("author").InnerText;

            // Get the publication year of the book
            string publicationYear = bookNode.SelectSingleNode("publicationYear").InnerText;

            // Print out the information
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publication Year: " + publicationYear);
            Console.WriteLine();
        }
    }
}
