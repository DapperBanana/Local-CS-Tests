
using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string xmlString = "<root><element>test</element></root>";

        if (IsValidXml(xmlString))
        {
            Console.WriteLine("The provided string is a valid XML document.");
        }
        else
        {
            Console.WriteLine("The provided string is not a valid XML document.");
        }
    }

    static bool IsValidXml(string xmlString)
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
