
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child></child></root>";

        bool isValidXml = IsValidXml(xmlString);

        if (isValidXml)
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
        catch
        {
            return false;
        }
    }
}
