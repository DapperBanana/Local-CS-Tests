
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        // Get a list of all the <person> elements
        XmlNodeList personNodes = doc.SelectNodes("//person");

        // Loop through each <person> element and extract the desired information
        foreach (XmlNode personNode in personNodes)
        {
            string name = personNode.SelectSingleNode("name").InnerText;
            int age = int.Parse(personNode.SelectSingleNode("age").InnerText);
            string occupation = personNode.SelectSingleNode("occupation").InnerText;

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Occupation: {0}", occupation);
            Console.WriteLine();
        }
    }
}
