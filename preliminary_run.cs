
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";

        Image img = Image.FromFile(imagePath);
        PropertyItem[] propItems = img.PropertyItems;

        foreach (PropertyItem propItem in propItems)
        {
            Console.WriteLine($"ID: {propItem.Id.ToString("x")}");
            Console.WriteLine($"Type: {propItem.Type}");
            Console.WriteLine($"Length: {propItem.Len}");
            Console.WriteLine($"Value: {BitConverter.ToString(propItem.Value)}");
            Console.WriteLine();
        }
    }
}
