
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";

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
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
