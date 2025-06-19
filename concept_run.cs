
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
                int id = propertyItem.Id;
                int type = propertyItem.Type;
                byte[] value = propertyItem.Value;
                Console.WriteLine($"Property ID: {id}");
                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Value: {BitConverter.ToString(value)}");
            }
        }
    }
}
