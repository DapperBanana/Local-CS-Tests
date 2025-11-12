
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                        <!DOCTYPE note SYSTEM ""note.dtd"">
                        <note>
                          <to>Tove</to>
                          <from>Jani</from>
                          <heading>Reminder</heading>
                          <body>Don't forget me this weekend!</body>
                        </note>";

        XmlDocument doc = new XmlDocument();
        doc.XmlResolver = null; // Disable DTD resolution
        try
        {
            doc.LoadXml(xml);
            Console.WriteLine("Valid XML document with DTD.");
        }
        catch (XmlException e)
        {
            Console.WriteLine("Invalid XML document with DTD: " + e.Message);
        }
    }
}
