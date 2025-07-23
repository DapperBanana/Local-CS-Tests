
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "sample.jpg";

        try
        {
            using (Bitmap bmp = new Bitmap(imagePath))
            {
                PropertyItem[] propItems = bmp.PropertyItems;

                Console.WriteLine("Metadata for image '{0}':", imagePath);
                foreach (PropertyItem propItem in propItems)
                {
                    Console.WriteLine("ID: {0}, Type: {1}, Length: {2}",
                        propItem.Id, propItem.Type, propItem.Len);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
