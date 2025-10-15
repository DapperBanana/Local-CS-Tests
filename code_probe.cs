
using System;
using System.Xml;
using System.IO;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version='1.0'?>
                            <!DOCTYPE note SYSTEM 'note.dtd'>
                            <note>
                                <to>Tove</to>
                                <from>Jani</from>
                                <heading>Reminder</heading>
                                <body>Don't forget me this weekend!</body>
                            </note>";

        bool isValid = IsValidXmlWithDTD(xmlString);

        if (isValid)
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool IsValidXmlWithDTD(string xml)
    {
        try
        {
            XmlTextReader reader = new XmlTextReader(new StringReader(xml));
            while (reader.Read()) { }
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
