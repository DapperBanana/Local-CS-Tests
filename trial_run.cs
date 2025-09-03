
using System;
using System.Xml;

class Program
{
    static void Main()
    {
        XmlDocument xmlDoc = new XmlDocument();
        
        try
        {
            xmlDoc.Load("data.xml");

            XmlNodeList nodes = xmlDoc.GetElementsByTagName("student");
            foreach (XmlNode node in nodes)
            {
                string firstName = node.SelectSingleNode("firstName").InnerText;
                string lastName = node.SelectSingleNode("lastName").InnerText;
                int age = int.Parse(node.SelectSingleNode("age").InnerText);

                Console.WriteLine("Student: {0} {1}, Age: {2}", firstName, lastName, age);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading XML file: " + ex.Message);
        }
    }
}
