
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string input = "<root><element1>value1</element1><element2>value2</element2></root>";
        
        if (IsValidXml(input))
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
