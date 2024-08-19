
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML document
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");
        
        // Get a list of all "book" elements
        XmlNodeList bookNodes = doc.SelectNodes("library/book");
        
        // Loop through each "book" element and extract information
        foreach (XmlNode bookNode in bookNodes)
        {
            string title = bookNode.SelectSingleNode("title").InnerText;
            string author = bookNode.SelectSingleNode("author").InnerText;
            string genre = bookNode.SelectSingleNode("genre").InnerText;
            int publishedYear = Convert.ToInt32(bookNode.SelectSingleNode("publishedYear").InnerText);
            
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Published Year: " + publishedYear);
            Console.WriteLine();
        }
    }
}
