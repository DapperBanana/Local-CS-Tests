
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "image.jpg";

        try
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (Image image = Image.FromStream(fs))
                {
                    foreach (PropertyItem property in image.PropertyItems)
                    {
                        Console.WriteLine($"Id: {property.Id}, Type: {property.Type}, Length: {property.Len}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading metadata: {ex.Message}");
        }
    }
}
