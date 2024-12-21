
using System;
using System.Drawing;
using System.Text;

namespace ImageMetadataExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagePath = "image.jpg";
            Image image = Image.FromFile(imagePath);

            Console.WriteLine("Image Metadata:");
            Console.WriteLine("*************************");

            foreach (var propItem in image.PropertyItems)
            {
                string propertyName = GetPropertyItemName(propItem.Id);
                string propertyValue = Encoding.UTF8.GetString(propItem.Value);

                Console.WriteLine($"{propertyName}: {propertyValue}");
            }
        }

        static string GetPropertyItemName(int id)
        {
            switch (id)
            {
                case 0x010f:
                    return "Artist";
                case 0x013b:
                    return "DateTime";
                case 0x0110:
                    return "Model";
                case 0x8769:
                    return "Exif IFD Pointer";

                // Add more cases for other property items as needed

                default:
                    return $"Unknown Property ({id})";
            }
        }
    }
}
