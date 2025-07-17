
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0""?>
                            <!DOCTYPE note [
                                <!ELEMENT note (to,from,heading,body)>
                                <!ELEMENT to (#PCDATA)>
                                <!ELEMENT from (#PCDATA)>
                                <!ELEMENT heading (#PCDATA)>
                                <!ELEMENT body (#PCDATA)>
                            ]>
                            <note>
                                <to>Alice</to>
                                <from>Bob</from>
                                <heading>Hello</heading>
                                <body>Just wanted to say hi!</body>
                            </note>";

        XmlDocument doc = new XmlDocument();

        try
        {
            doc.LoadXml(xmlString);
            Console.WriteLine("The XML document is valid with a DTD.");
        }
        catch (XmlException e)
        {
            Console.WriteLine("The XML document is not valid with a DTD. Error message: " + e.Message);
        }
    }
}
