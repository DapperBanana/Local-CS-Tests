
using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        string imagePath = "sample.jpg";
        
        Bitmap image = new Bitmap(imagePath);

        // Convert the image to grayscale
        for (int i = 0; i < image.Width; i++)
        {
            for (int j = 0; j < image.Height; j++)
            {
                Color pixel = image.GetPixel(i, j);
                
                int average = (pixel.R + pixel.G + pixel.B) / 3;
                
                Color newPixel = Color.FromArgb(average, average, average);
                
                image.SetPixel(i, j, newPixel);
            }
        }

        // Save the grayscale image
        string outputPath = "grayscale.jpg";
        image.Save(outputPath);

        Console.WriteLine("Grayscale image saved to " + outputPath);
    }
}
