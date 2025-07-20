
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string filePath = @"C:\path\to\image.jpg";
        
        Image image = Image.FromFile(filePath);

        PropertyItem[] propItems = image.PropertyItems;

        foreach (PropertyItem propItem in propItems)
        {
            Console.WriteLine("ID: 0x" + propItem.Id.ToString("x"));
            Console.WriteLine("Type: " + propItem.Type);
            Console.WriteLine("Value: " + BitConverter.ToString(propItem.Value));
            Console.WriteLine();
        }

        image.Dispose();
    }
}
