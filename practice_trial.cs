using System;
using System.Xml;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the XML string:");
        string xmlContent = Console.ReadLine();

        bool isValidDtd = IsValidXmlWithDtd(xmlContent);
        Console.WriteLine($"Is valid XML with DTD: {isValidDtd}");
    }

    static bool IsValidXmlWithDtd(string xmlContent)
    {
        try
        {
            // Set up settings for XmlReader
            XmlReaderSettings settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse,
                ValidationType = ValidationType.DTD,
                ValidationFlags = System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings
            };

            bool isValid = true;
            settings.ValidationEventHandler += (sender, args) =>
            {
                // Any validation error (including DTD issues) will mark invalid
                isValid = false;
            };

            using (StringReader stringReader = new StringReader(xmlContent))
            using (XmlReader reader = XmlReader.Create(stringReader, settings))
            {
                // Parse the XML document
                while (reader.Read()) { }
            }

            // If no validation errors encountered, it's valid with DTD
            return isValid;
        }
        catch (XmlException)
        {
            // Invalid XML format
            return false;
        }
        catch (Exception)
        {
            // Other errors
            return false;
        }
    }
}