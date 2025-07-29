
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Input string that we want to check if it's a valid XML document
        string inputString = "<body><h1>Hello World</h1><p>This is a paragraph</p></body>";

        try
        {
            // Create a new XML document
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(inputString);

            // If no exception is thrown, then the input string is a valid XML document
            Console.WriteLine("Valid XML document.");
        }
        catch (XmlException)
        {
            // If an exception is thrown, then the input string is not a valid XML document
            Console.WriteLine("Invalid XML document.");
        }
    }
}
