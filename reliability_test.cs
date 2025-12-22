using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<!DOCTYPE note SYSTEM \"Note.dtd\"><note><to>Tove</to></note>"; // Example XML with DTD

        bool isValid = IsValidXmlWithDtd(xmlString);

        Console.WriteLine($"Is the XML valid with DTD? {isValid}");
    }

    static bool IsValidXmlWithDtd(string xml)
    {
        try
        {
            XmlReaderSettings settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse,
                ValidationType = ValidationType.DTD,
                ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings,
                XmlResolver = new XmlUrlResolver()
            };

            settings.ValidationEventHandler += (sender, args) =>
            {
                // Handle validation errors or warnings
                throw new XmlException($"Validation {args.Severity}: {args.Message}");
            };

            using (var reader = XmlReader.Create(new System.IO.StringReader(xml), settings))
            {
                while (reader.Read()) { } // Parse the XML document
            }

            // If parsing completes without exceptions, XML is valid with DTD
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}