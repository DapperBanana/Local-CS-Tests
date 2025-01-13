
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "image.jpg";
            Image image = Image.FromFile(filePath);
            PropertyItem[] props = image.PropertyItems;

            foreach (PropertyItem prop in props)
            {
                Console.WriteLine($"ID: {prop.Id}");
                Console.WriteLine($"Type: {prop.Type}");
                Console.WriteLine($"Length: {prop.Len}");
                Console.WriteLine($"Value: {BitConverter.ToInt32(prop.Value, 0)}");
                Console.WriteLine();
            }

            image.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
