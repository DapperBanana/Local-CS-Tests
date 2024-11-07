
using System;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the XML file
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");

            // Get the root element
            XmlNode root = doc.DocumentElement;

            // Iterate through the child nodes to find the specific information
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "person")
                {
                    string name = node.SelectSingleNode("name").InnerText;
                    string age = node.SelectSingleNode("age").InnerText;

                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Age: " + age);
                }
            }
        }
    }
}
