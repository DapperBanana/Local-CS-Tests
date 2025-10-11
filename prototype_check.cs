
using System;
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

        bool isValid = CheckValidXMLWithDTD(xmlString);

        if (isValid)
        {
            Console.WriteLine("Given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("Given string is not a valid XML document with a DTD.");
        }
    }

    static bool CheckValidXMLWithDTD(string xmlString)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null; // Disable loading any external DTD
            doc.LoadXml(xmlString);
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
