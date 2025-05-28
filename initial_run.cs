
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/node");

        foreach (XmlNode node in nodes)
        {
            string name = node.SelectSingleNode("name").InnerText;
            string age = node.SelectSingleNode("age").InnerText;
            string email = node.SelectSingleNode("email").InnerText;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine();
        }
    }
}

