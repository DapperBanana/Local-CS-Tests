
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child>Test</child></root>"; // XML string to be checked
        
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            Console.WriteLine("The given string is a valid XML document.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }
}
