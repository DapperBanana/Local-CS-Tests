
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        string inputImagePath = "input.jpg";
        string outputImagePath = "output.jpg";

        Bitmap inputImage = new Bitmap(inputImagePath);
        Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

        for (int x = 0; x < inputImage.Width; x++)
        {
            for (int y = 0; y < inputImage.Height; y++)
            {
                Color pixel = inputImage.GetPixel(x, y);
                int grayValue = (int)(0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B);
                Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                outputImage.SetPixel(x, y, grayPixel);
            }
        }

        outputImage.Save(outputImagePath);
        Console.WriteLine("Grayscale conversion completed. Output image saved as " + outputImagePath);
    }
}
