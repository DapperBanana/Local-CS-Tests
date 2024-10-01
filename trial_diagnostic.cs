
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

class ImageMetadataExtractor
{
    static void Main()
    {
        string imagePath = "image.jpg"; // replace with your image file path
        try
        {
            using (Image image = Image.FromFile(imagePath))
            {
                PropertyItem[] propertyItems = image.PropertyItems;
                
                StringBuilder metadata = new StringBuilder();
                foreach (PropertyItem propertyItem in propertyItems)
                {
                    string id = propertyItem.Id.ToString("x");
                    string type = propertyItem.Type.ToString();
                    byte[] value = propertyItem.Value;

                    string formattedData = $"ID: 0x{id}, Type: {type}, Value: {Encoding.ASCII.GetString(value)}";
                    metadata.AppendLine(formattedData);
                }

                Console.WriteLine("Image Metadata:");
                Console.WriteLine(metadata.ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
