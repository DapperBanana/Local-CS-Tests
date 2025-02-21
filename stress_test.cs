
using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";

        bool isValid = IsValidXml(xmlString);
        if (isValid)
        {
            Console.WriteLine("Valid XML document");
        }
        else
        {
            Console.WriteLine("Invalid XML document");
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
