
using System;
using System.IO;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version='1.0'?>
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

        bool isValid = IsXmlValid(xmlString);

        if (isValid)
        {
            Console.WriteLine("The given XML document is valid with a DTD.");
        }
        else
        {
            Console.WriteLine("The given XML document is not valid with a DTD.");
        }
    }

    static bool IsXmlValid(string xmlString)
    {
        try
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;

            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString), settings))
            {
                while (reader.Read()) ;
                return true;
            }
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
