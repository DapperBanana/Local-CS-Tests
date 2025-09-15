
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<!DOCTYPE note [<!ELEMENT note (to,from,heading,body)>]><note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";
        
        if (IsValidXmlWithDtd(xmlString))
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool IsValidXmlWithDtd(string xmlString)
    {
        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.XmlResolver = null; // Disable DTD processing
            xmlDoc.LoadXml(xmlString);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
