
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"
            <?xml version='1.0'?>
            <!DOCTYPE note [
                <!ELEMENT note (to, from, heading, body)>
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
            doc.XmlResolver = null; // Disable loading external DTDs
            doc.LoadXml(xmlString);

            Console.WriteLine("The given XML document is valid with DTD.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document with DTD.");
        }
    }
}
