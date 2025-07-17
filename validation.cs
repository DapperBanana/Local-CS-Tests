
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"<root></root>";

        if (IsValidXml(xmlString))
        {
            Console.WriteLine("The given string is a valid XML document.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }

    static bool IsValidXml(string xmlString)
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
