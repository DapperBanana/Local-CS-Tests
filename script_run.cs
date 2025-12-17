using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string xmlFilePath = "yourfile.xml"; // Replace with your XML file path

        XmlDocument xmlDoc = new XmlDocument();

        try
        {
            xmlDoc.Load(xmlFilePath);

            // Example: Extract all elements with a specific tag
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("YourElementName");

            foreach (XmlNode node in nodes)
            {
                // Access attributes
                string attributeValue = node.Attributes["AttributeName"]?.InnerText;

                // Access inner text
                string innerText = node.InnerText;

                Console.WriteLine($"Attribute: {attributeValue}, Text: {innerText}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading or parsing XML: " + ex.Message);
        }
    }
}