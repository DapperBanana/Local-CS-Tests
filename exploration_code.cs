
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("data.xml");

            XmlNodeList nodes = xmlDoc.SelectNodes("//book");

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
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
