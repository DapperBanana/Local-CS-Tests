
using System;
using System.Xml;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0""?>
            <!DOCTYPE note [
                <!ELEMENT note (#PCDATA)>
            ]>
            <note>Sample XML document</note>";

        XmlReaderSettings settings = new XmlReaderSettings();
        settings.DtdProcessing = DtdProcessing.Parse;

        try
        {
            using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(xmlString), settings))
            {
                while (reader.Read())
                {
                    // Reading the XML document
                }
            }

            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        catch (XmlSchemaException ex)
        {
            Console.WriteLine($"Invalid XML document with DTD. Error: {ex.Message}");
        }
        catch (XmlException ex)
        {
            Console.WriteLine($"Invalid XML document. Error: {ex.Message}");
        }
    }
}
