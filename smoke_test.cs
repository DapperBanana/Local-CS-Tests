
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        // Get a list of all the <person> nodes in the XML
        XmlNodeList personNodes = doc.SelectNodes("//person");

        // Loop through each <person> node
        foreach (XmlNode personNode in personNodes)
        {
            // Extract specific information from the <person> node
            string name = personNode.SelectSingleNode("name").InnerText;
            string age = personNode.SelectSingleNode("age").InnerText;

            // Print out the information
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }
    }
}
