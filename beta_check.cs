
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";

        using (Image image = Image.FromFile(imagePath))
        {
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                Console.WriteLine($"Property ID: {propertyItem.Id}");
                Console.WriteLine($"Type: {propertyItem.Type}");
                Console.WriteLine($"Length: {propertyItem.Len}");

                // Convert byte array to string
                string value = System.Text.Encoding.ASCII.GetString(propertyItem.Value);
                Console.WriteLine($"Value: {value}");
                Console.WriteLine();
            }
        }
    }
}
