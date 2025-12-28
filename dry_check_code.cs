using System;
using System.Xml;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's valid XML:");
        string input = Console.ReadLine();

        bool isValidXml = IsValidXml(input);
        Console.WriteLine($"Is the input valid XML? {isValidXml}");
    }

    static bool IsValidXml(string xmlString)
    {
        if (string.IsNullOrWhiteSpace(xmlString))
            return false;

        try
        {
            var xmlReaderSettings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Ignore,
                ValidationType = ValidationType.None
            };

            using (var reader = XmlReader.Create(new System.IO.StringReader(xmlString), xmlReaderSettings))
            {
                while (reader.Read())
                {
                    // Just read through the document
                }
            }
            return true;
        }
        catch (XmlException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
}