
using System;
using System.Xml;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                                <!DOCTYPE note SYSTEM ""note.dtd"">
                                <note>
                                    <to>Tove</to>
                                    <from>Jani</from>
                                    <heading>Reminder</heading>
                                    <body>Don't forget me this weekend!</body>
                                </note>";

        bool isValid = ValidateXmlWithDtd(xmlString);
        if (isValid)
        {
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }

    static bool ValidateXmlWithDtd(string xmlString)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = new XmlUrlResolver();
            doc.LoadXml(xmlString);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ProhibitDtd = false;
            settings.DtdProcessing = DtdProcessing.Parse;

            XmlReader reader = XmlReader.Create(new System.IO.StringReader(xmlString), settings);

            while (reader.Read()) { }

            return true;
        }
        catch (XmlSchemaValidationException)
        {
            return false;
        }
    }
}
