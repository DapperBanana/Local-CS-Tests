
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
                PropertyItem[] propItems = image.PropertyItems;
                
                foreach (PropertyItem propItem in propItems)
                {
                    Console.WriteLine($"ID: {propItem.Id}, Type: {propItem.Type}, Length: {propItem.Len}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
