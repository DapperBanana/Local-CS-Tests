
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        XmlNodeList nodes = doc.SelectNodes("/data/person");

        foreach (XmlNode node in nodes)
        {
            string name = node.SelectSingleNode("name").InnerText;
            int age = Convert.ToInt32(node.SelectSingleNode("age").InnerText);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }
    }
}
