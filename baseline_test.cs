
using System;
using System.Xml;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0"" encoding=""UTF-8""?>
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
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.DTD;

            XmlReader reader = XmlReader.Create(xmlDocument.CreateNavigator().ReadSubtree(), settings);

            while (reader.Read()) { }

            Console.WriteLine("Valid XML document with DTD.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid XML document with DTD: " + ex.Message);
        }
    }
}
