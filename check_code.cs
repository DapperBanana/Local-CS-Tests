
using System;
using Rasterio;

class Program
{
    static void Main(string[] args)
    {
        // Open the satellite image file
        using (var dataset = Dataset.Open("satellite_image.tif"))
        {
            // Get the first band of the image
            var band = dataset.GetBand(1);

            // Get the dimensions of the image
            int width = dataset.Width;
            int height = dataset.Height;

            // Calculate the total number of pixels
            long totalPixels = width * height;

            // Count the number of pixels containing vegetation (assuming vegetation is represented by values between 0.2 and 1)
            long vegetationPixels = 0;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double pixelValue = band.ReadPixel(x, y);

                    if (pixelValue >= 0.2 && pixelValue <= 1)
                    {
                        vegetationPixels++;
                    }
                }
            }

            // Calculate the percentage of vegetation in the image
            double vegetationPercentage = (double)vegetationPixels / totalPixels * 100;

            Console.WriteLine("Percentage of vegetation in the image: " + vegetationPercentage + "%");
        }
    }
}
