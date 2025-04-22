
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image file
        Bitmap image = new Bitmap("input.jpg");
        
        // Perform grayscale conversion
        for (int i = 0; i < image.Width; i++)
        {
            for (int j = 0; j < image.Height; j++)
            {
                Color pixel = image.GetPixel(i, j);
                int grayscale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                Color newPixel = Color.FromArgb(grayscale, grayscale, grayscale);
                image.SetPixel(i, j, newPixel);
            }
        }
        
        // Save the modified image
        image.Save("output.jpg");
        
        Console.WriteLine("Grayscale conversion completed.");
    }
}
