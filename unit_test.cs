
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";

        using (Image image = Image.FromFile(imagePath))
        {
            foreach (PropertyItem property in image.PropertyItems)
            {
                Console.WriteLine($"Property ID: {property.Id}");
                Console.WriteLine($"Data Type: {property.Type}");
                Console.WriteLine($"Data Size: {property.Len}");
                Console.WriteLine($"Value: {BitConverter.ToString(property.Value)}");
                Console.WriteLine();
            }
        }
    }
}
