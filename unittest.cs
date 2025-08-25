
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xml = @"<note>
                        <to>Tove</to>
                        <from>Jani</from>
                        <heading>Reminder</heading>
                        <body>Don't forget me this weekend!</body>
                      </note>";

        try
        {
            // Load the XML string into an XmlDocument object
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.XmlResolver = null; // Disable DTD resolution
            xmlDoc.LoadXml(xml);

            // Check if the XML document is valid
            Console.WriteLine("The XML document is valid.");
        }
        catch (XmlException ex)
        {
            Console.WriteLine("The XML document is not valid: " + ex.Message);
        }
    }
}
