
using System;
using System.Xml;
using System.IO;

class Program
{
    static void Main()
    {
        string xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<!DOCTYPE note[\n<!ELEMENT note (to, from, heading, body)>\n<!ELEMENT to (#PCDATA)>\n<!ELEMENT from (#PCDATA)>\n<!ELEMENT heading (#PCDATA)>\n<!ELEMENT body (#PCDATA)>\n]>\n<note>\n<to>Tove</to>\n<from>Jani</from>\n<heading>Reminder</heading>\n<body>Don't forget me this weekend!</body>\n</note>";

        bool isValid = ValidateXmlWithDTD(xmlString);

        if (isValid)
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool ValidateXmlWithDTD(string xmlString)
    {
        try
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.XmlResolver = new XmlUrlResolver();
            settings.DtdProcessing = DtdProcessing.Parse;

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString), settings))
            {
                while (reader.Read()) { }
            }

            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
