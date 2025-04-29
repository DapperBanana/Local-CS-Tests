
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                        <!DOCTYPE note SYSTEM ""Note.dtd"">
                        <note>
                            <to>Tove</to>
                            <from>Jani</from>
                            <heading>Reminder</heading>
                            <body>Don't forget me this weekend!</body>
                        </note>";

        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = new XmlUrlResolver();
            doc.LoadXml(xmlString);
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }
}
