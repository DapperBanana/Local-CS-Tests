
using System;
using System.Collections.Generic;
using System.Linq;
using Rasterio;

class Program
{
    static void Main()
    {
        string filePath = "path_to_your_satellite_image.tif";

        using (var dataset = Dataset.Open(filePath))
        {
            if (dataset != null)
            {
                Band greenBand = dataset.Bands.FirstOrDefault(band => band.Name.Contains("green"));
                Band redBand = dataset.Bands.FirstOrDefault(band => band.Name.Contains("red"));

                if (greenBand != null && redBand != null)
                {
                    double totalCount = 0.0;
                    double vegetationCount = 0.0;

                    for (int row = 0; row < dataset.Height; row++)
                    {
                        for (int col = 0; col < dataset.Width; col++)
                        {
                            double greenValue = greenBand.ReadPixel(row, col)[0];
                            double redValue = redBand.ReadPixel(row, col)[0];

                            if (greenValue > 0 && redValue > 0)
                            {
                                double ndvi = (greenValue - redValue) / (greenValue + redValue);

                                totalCount++;
                                if (ndvi > 0.2) // threshold for vegetation
                                {
                                    vegetationCount++;
                                }
                            }
                        }
                    }

                    double vegetationPercentage = (vegetationCount / totalCount) * 100;
                    Console.WriteLine($"Vegetation percentage: {vegetationPercentage}%");
                }
                else
                {
                    Console.WriteLine("Could not find green and red bands in the raster dataset.");
                }
            }
            else
            {
                Console.WriteLine("Failed to open raster dataset.");
            }
        }
    }
}
