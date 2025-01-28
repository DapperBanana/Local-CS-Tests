
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Data/Item");

        foreach (XmlNode node in nodes)
        {
            string name = node.SelectSingleNode("Name").InnerText;
            string price = node.SelectSingleNode("Price").InnerText;
            string description = node.SelectSingleNode("Description").InnerText;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Description: " + description);
        }
    }
}
