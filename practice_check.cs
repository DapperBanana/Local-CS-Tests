
using System;
using System.Drawing;
using System.Drawing.Imaging;

class ImageMetadataExtractor
{
    static void Main()
    {
        string imageFilePath = "image.jpg"; // Change this to the path of your image file

        try
        {
            using (Image image = Image.FromFile(imageFilePath))
            {
                foreach (PropertyItem propertyItem in image.PropertyItems)
                {
                    Console.WriteLine($"ID: {propertyItem.Id}, Type: {propertyItem.Type}, Length: {propertyItem.Len}");
                    Console.WriteLine($"Value: {BitConverter.ToString(propertyItem.Value)}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
