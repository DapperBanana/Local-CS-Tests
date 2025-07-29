
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xml = @"<?xml version='1.0'?>
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
        
        bool isValid = IsValidXmlWithDtd(xml);
        Console.WriteLine($"Is Valid XML with DTD: {isValid}");
    }

    static bool IsValidXmlWithDtd(string xml)
    {
        try
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Prohibit;
            
            using (XmlReader reader = XmlReader.Create(new System.IO.StringReader(xml), settings))
            {
                while (reader.Read()) { }
            }

            return true;
        }
        catch (XmlException)
        {
            return false;
        }
    }
}
