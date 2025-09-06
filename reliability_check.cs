
using AForge.Imaging.Filters;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image
        Bitmap image = new Bitmap("input.jpg");
        
        // Convert the image to grayscale
        Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
        Bitmap grayscaleImage = filter.Apply(image);
        
        // Save the grayscale image
        grayscaleImage.Save("output.jpg");
        
        Console.WriteLine("Image converted to grayscale successfully.");
    }
}
