
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main()
    {
        string imagePath = "example.jpg"; // Path to the image file

        if(File.Exists(imagePath))
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (Image image = Image.FromStream(fs, false, false))
                {
                    PropertyItem[] propItems = image.PropertyItems;

                    foreach(PropertyItem propItem in propItems)
                    {
                        Console.WriteLine($"Property ID: {propItem.Id}");
                        Console.WriteLine($"Type: {propItem.Type}");
                        Console.WriteLine($"Data size: {propItem.Len}");
                        Console.WriteLine($"Data: {BitConverter.ToString(propItem.Value)}");
                        Console.WriteLine();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Image file not found.");
        }
    }
}
