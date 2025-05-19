
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "example.jpg";
        
        using (Image image = Image.FromFile(imagePath))
        {
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                Console.WriteLine($"ID: {propertyItem.Id}, Type: {propertyItem.Type}, Length: {propertyItem.Len}");
                
                if (propertyItem.Type == 2) // ASCII string
                {
                    string value = System.Text.Encoding.UTF8.GetString(propertyItem.Value);
                    Console.WriteLine($"Value: {value}");
                }
                else
                {
                    Console.WriteLine("Value: " + BitConverter.ToString(propertyItem.Value));
                }
            }
        }
    }
}
