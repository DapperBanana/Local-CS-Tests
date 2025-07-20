
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";

        using (Image image = new Bitmap(imagePath))
        {
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                string id = propertyItem.Id.ToString("x");
                string value = System.Text.Encoding.ASCII.GetString(propertyItem.Value);

                Console.WriteLine($"Metadata ID: {id}, Value: {value}");
            }
        }
    }
}
