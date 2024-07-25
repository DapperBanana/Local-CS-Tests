
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xml = "<!DOCTYPE note [<!ENTITY foo 'bar'>]><note><to>John</to><from>&foo;</from><heading>Reminder</heading><body>Don't forget to bring the documents.</body></note>";

        if (IsValidXml(xml))
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool IsValidXml(string xml)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            doc.LoadXml(xml);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
