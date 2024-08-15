
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                            <!DOCTYPE note SYSTEM ""note.dtd"">
                            <note>
                                <to>Tove</to>
                                <from>Jani</from>
                                <heading>Reminder</heading>
                                <body>Don't forget me this weekend!</body>
                            </note>";

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.XmlResolver = null; // Disable external DTD fetching
            xmlDoc.LoadXml(xmlString);
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }
}
