
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("data.xml");

        XmlNodeList bookList = xmlDoc.GetElementsByTagName("book");

        foreach (XmlNode bookNode in bookList)
        {
            string title = bookNode["title"].InnerText;
            string author = bookNode["author"].InnerText;
            string genre = bookNode["genre"].InnerText;
            string price = bookNode["price"].InnerText;

            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Price: " + price);
            Console.WriteLine();
        }
    }
}
