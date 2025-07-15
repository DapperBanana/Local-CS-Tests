
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Input XML string with DTD
        string xmlString = @"<?xml version=""1.0"" encoding=""utf-8""?>
                            <!DOCTYPE note [
                                <!ELEMENT note (to,from,heading,body)>
                                <!ELEMENT to #PCDATA>
                                <!ELEMENT from #PCDATA>
                                <!ELEMENT heading #PCDATA>
                                <!ELEMENT body #PCDATA>
                            ]>
                            <note>
                                <to>Tove</to>
                                <from>Jani</from>
                                <heading>Reminder</heading>
                                <body>Don't forget me this weekend!</body>
                            </note>";
        
        // Create an XmlReaderSettings object with ProhibitDtd set to false to allow DTD processing
        XmlReaderSettings settings = new XmlReaderSettings();
        settings.ProhibitDtd = false;

        // Create an XmlReader object with the XML string and settings
        using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(xmlString), settings))
        {
            try
            {
                // Read the XML
                while (reader.Read()) { }

                Console.WriteLine("The given string is a valid XML document with DTD.");
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
