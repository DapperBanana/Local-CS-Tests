
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string input = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";

        try
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(input);
            Console.WriteLine("The input is a valid XML document.");
        }
        catch (Exception)
        {
            Console.WriteLine("The input is not a valid XML document.");
        }
    }
}
