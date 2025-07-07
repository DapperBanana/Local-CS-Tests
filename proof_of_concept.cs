
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

namespace ImageProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the image
            Bitmap image = new Bitmap("input.jpg");
            
            // Convert the image to grayscale
            Bitmap grayscaleImage = ToGrayscale(image);
            
            // Save the grayscale image
            grayscaleImage.Save("output.jpg", ImageFormat.Jpeg);
        }

        static Bitmap ToGrayscale(Bitmap image)
        {
            Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);
            
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    Color grayPixel = Color.FromArgb(gray, gray, gray);
                    grayscaleImage.SetPixel(x, y, grayPixel);
                }
            }
            
            return grayscaleImage;
        }
    }
}
