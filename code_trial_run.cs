
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            Console.WriteLine("The given string is a valid XML document.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }
}
