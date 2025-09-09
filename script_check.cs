
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child>data</child></root>";

        try
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);
            Console.WriteLine("The given string is a valid XML document.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }
}
