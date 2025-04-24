
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child>Test</child></root>"; // Replace with your XML string

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            Console.WriteLine("The XML is valid.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The XML is not valid.");
        }
    }
}
