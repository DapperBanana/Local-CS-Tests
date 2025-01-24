
using System;
using System.Xml;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string xmlString = @"
            <!DOCTYPE note [
                <!ELEMENT note (to,from,heading,body)>
                <!ELEMENT to (#PCDATA)>
                <!ELEMENT from (#PCDATA)>
                <!ELEMENT heading (#PCDATA)>
                <!ELEMENT body (#PCDATA)>
            ]>
            <note>
                <to>Tove</to>
                <from>Jani</from>
                <heading>Reminder</heading>
                <body>Don't forget me this weekend!</body>
            </note>";

        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            doc.LoadXml(xmlString);

            Console.WriteLine("The XML document with DTD is valid.");
        }
        catch (XmlSchemaValidationException ex)
        {
            Console.WriteLine("The XML document with DTD is invalid: " + ex.Message);
        }
    }
}
