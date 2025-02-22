
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<!DOCTYPE note [<!ELEMENT note (#PCDATA)>]><note>Hello, World!</note>";

        bool isValid = IsXmlValidWithDTD(xmlString);

        if (isValid)
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool IsXmlValidWithDTD(string xmlString)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            doc.LoadXml(xmlString);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
