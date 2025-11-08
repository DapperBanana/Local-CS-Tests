
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg"; // Path to the image file

        try
        {
            Image image = Image.FromFile(imagePath);

            Console.WriteLine("Image Metadata:");
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                Console.WriteLine($"{propertyItem.Id}: {BitConverter.ToString(propertyItem.Value)}");
            }

            image.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
