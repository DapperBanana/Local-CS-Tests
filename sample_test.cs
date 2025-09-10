
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Load the image file
        string filePath = "image.jpg";
        Image image = Image.FromFile(filePath);

        // Get the properties collection of the image
        PropertyItem[] properties = image.PropertyItems;

        // Loop through each property and display its ID, type, and value
        foreach (PropertyItem property in properties)
        {
            Console.WriteLine($"Property ID: {property.Id}");
            Console.WriteLine($"Property Type: {property.Type}");
            Console.WriteLine($"Property Value: {BitConverter.ToString(property.Value)}");
            Console.WriteLine();
        }

        // Dispose the image after extracting metadata
        image.Dispose();
    }
}
