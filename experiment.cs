
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
            PropertyItem[] propertyItems = image.PropertyItems;
            foreach (PropertyItem pi in propertyItems)
            {
                Console.WriteLine($"Id: {pi.Id}");
                Console.WriteLine($"Type: {pi.Type}");
                Console.WriteLine($"Length: {pi.Len}");
                Console.WriteLine($"Value: {BitConverter.ToString(pi.Value)}");
                Console.WriteLine();
            }
        }
    }
}
