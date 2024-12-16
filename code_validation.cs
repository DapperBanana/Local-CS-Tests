
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");

        // Get the root element
        XmlElement root = doc.DocumentElement;

        // Get a specific element and its child nodes
        XmlNodeList nodes = root.SelectNodes("/root/element/child");

        // Loop through the child nodes and extract specific information
        foreach (XmlNode node in nodes)
        {
            // Extract specific information from the node
            string value = node.InnerText;
            Console.WriteLine(value);
        }
    }
}
