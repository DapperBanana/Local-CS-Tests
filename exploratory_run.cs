
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = @"image.jpg";

        try
        {
            using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                BitmapDecoder decoder = BitmapDecoder.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.Default);
                BitmapMetadata metaData = (BitmapMetadata)decoder.Frames[0].Metadata;

                Console.WriteLine("Image Metadata:");
                Console.WriteLine("Title: " + metaData.Title);
                Console.WriteLine("Author: " + metaData.Author);
                Console.WriteLine("Date Taken: " + metaData.DateTaken);
                Console.WriteLine("Camera Model: " + metaData.CameraModel);
                Console.WriteLine("Width: " + decoder.Frames[0].PixelWidth + " pixels");
                Console.WriteLine("Height: " + decoder.Frames[0].PixelHeight + " pixels");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
