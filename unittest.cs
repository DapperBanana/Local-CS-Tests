
using System;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");

            XmlNodeList nodeList = doc.GetElementsByTagName("person");

            foreach (XmlNode node in nodeList)
            {
                string name = node["name"].InnerText;
                int age = int.Parse(node["age"].InnerText);
                string city = node["city"].InnerText;

                Console.WriteLine("Name: {0}, Age: {1}, City: {2}", name, age, city);
            }
        }
    }
}
