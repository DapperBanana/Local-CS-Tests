
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "path_to_your_image.jpg";

        try
        {
            Image image = Image.FromFile(imagePath);

            Console.WriteLine("Metadata for: " + imagePath);
            Console.WriteLine("Format: " + image.RawFormat);

            foreach (PropertyItem prop in image.PropertyItems)
            {
                Console.WriteLine("ID: {0}, Type: {1}, Length: {2} bytes", prop.Id, prop.Type, prop.Len);
            }

            BitmapMetadata metadata = (BitmapMetadata)BitmapFrame.Create(new Uri(imagePath)).Metadata;

            foreach (string query in metadata)
            {
                Console.WriteLine("{0}: {1}", query, metadata.GetQuery(query));
            }

            image.Dispose();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
