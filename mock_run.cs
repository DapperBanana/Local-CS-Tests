
using System;
using System.Drawing;
using System.Drawing.Imaging;

class ImageMetadataExtractor
{
    static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine("Please provide the path to an image file.");
            return;
        }

        string imagePath = args[0];

        try
        {
            using (Image image = Image.FromFile(imagePath))
            {
                foreach (PropertyItem property in image.PropertyItems)
                {
                    string propertyName = property.Id.ToString("x");
                    string propertyValue = System.Text.Encoding.UTF8.GetString(property.Value);

                    Console.WriteLine($"Property {propertyName}: {propertyValue}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
