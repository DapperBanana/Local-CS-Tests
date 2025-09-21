
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<!DOCTYPE List [<!ELEMENT List (Item+)> <!ELEMENT Item (#PCDATA)>]><List><Item>Item 1</Item><Item>Item 2</Item></List>";

        try
        {
            XmlTextReader reader = new XmlTextReader(xmlString);
            while (reader.Read()) { }
            Console.WriteLine("The given string is a valid XML document with a DTD.");
        }
        catch (XmlException)
        {
            Console.WriteLine("The given string is not a valid XML document with a DTD.");
        }
    }
}
