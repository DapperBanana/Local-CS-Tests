
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";
        
        try
        {
            using (Image image = Image.FromFile(imagePath))
            {
                foreach (PropertyItem property in image.PropertyItems)
                {
                    Console.WriteLine($"ID: {property.Id}");
                    Console.WriteLine($"Type: {property.Type}");
                    Console.WriteLine($"Length: {property.Len}");
                    Console.WriteLine($"Value: {BitConverter.ToString(property.Value)}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
