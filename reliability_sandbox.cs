
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/item");

        foreach (XmlNode node in nodes)
        {
            string name = node.SelectSingleNode("name").InnerText;
            int quantity = Convert.ToInt32(node.SelectSingleNode("quantity").InnerText);
            double price = Convert.ToDouble(node.SelectSingleNode("price").InnerText);

            Console.WriteLine("Item Name: " + name);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine();
        }
    }
}
