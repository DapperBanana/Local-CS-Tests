
using System;
using System.Xml;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string xmlString = @"<?xml version=""1.0""?>
                            <!DOCTYPE note SYSTEM ""note.dtd"">
                            <note>
                                <to>Tove</to>
                                <from>Jani</from>
                                <heading>Reminder</heading>
                                <body>Don't forget me this weekend!</body>
                            </note>";

        XmlTextReader reader = new XmlTextReader(xmlString);
        XmlValidatingReader validReader = new XmlValidatingReader(reader);
        
        try
        {
            while (validReader.Read()) { }
            Console.WriteLine("The XML document is valid with DTD.");
        }
        catch (XmlSchemaValidationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            validReader.Close();
            reader.Close();
        }
    }
}
