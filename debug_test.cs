
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlString = "<root><child></child></root>"; // replace this with the XML string you want to check

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlString);
            
            Console.WriteLine("The given string is a valid XML document.");
        }
        catch (XmlException ex)
        {
            Console.WriteLine("The given string is not a valid XML document.");
            Console.WriteLine($"Error message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while checking if the string is a valid XML document.");
            Console.WriteLine($"Error message: {ex.Message}");
        }
    }
}
