
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "example.jpg";

        using (Image image = Image.FromFile(imagePath))
        {
            PropertyItem[] propItems = image.PropertyItems;

            foreach (PropertyItem propItem in propItems)
            {
                Console.WriteLine($"Property ID: {propItem.Id}");
                Console.WriteLine($"Type: {propItem.Type}");
                Console.WriteLine($"Length: {propItem.Len}");
                Console.WriteLine($"Value: {BitConverter.ToString(propItem.Value)}");
                Console.WriteLine();
            }
        }
    }
}
