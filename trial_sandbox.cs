
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // Load the XML file
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml");
        
        // Get the root element
        XmlElement root = doc.DocumentElement;
        
        // Get a list of all <person> elements
        XmlNodeList persons = root.GetElementsByTagName("person");
        
        // Iterate through each <person> element
        foreach(XmlNode person in persons)
        {
            // Get the name attribute value
            string name = person.Attributes["name"].Value;
            
            // Get the age element value
            int age = int.Parse(person["age"].InnerText);
            
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
        }
    }
}
