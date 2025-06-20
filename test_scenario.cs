
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Specify the path to the image file
        string imagePath = "image.jpg";
        
        // Load the image
        using (Image image = Image.FromFile(imagePath))
        {
            // Get the PropertyItems property of the image
            PropertyItem[] propertyItems = image.PropertyItems;
            
            // Display the metadata information
            foreach (PropertyItem propertyItem in propertyItems)
            {
                Console.WriteLine($"ID: {propertyItem.Id}, Type: {propertyItem.Type}, Length: {propertyItem.Len}");

                // Decode and display the value of the property
                if (propertyItem.Type == 2) // ASCII string
                {
                    string value = System.Text.Encoding.UTF8.GetString(propertyItem.Value).Trim('\0');
                    Console.WriteLine($"Value: {value}");
                }
                else
                {
                    foreach (byte b in propertyItem.Value)
                    {
                        Console.Write($"{b:X} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
