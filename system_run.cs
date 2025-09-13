
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><element>value</element></root>";

        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ConformanceLevel = ConformanceLevel.Document;

        try
        {
            using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(xmlString), settings))
            {
                while (reader.Read()) { }
                Console.WriteLine("The given string is a valid XML document.");
            }
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document.");
        }
    }
}
