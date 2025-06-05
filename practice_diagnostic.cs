
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child1/></root>"; // Change this to the XML string you want to check

        bool isValidXml = IsXmlValid(xmlString);
        
        if (isValidXml)
        {
            Console.WriteLine("The given string is a valid XML document.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }

    static bool IsXmlValid(string xmlString)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
