
using Rasterio;
using Rasterio.Enums;
using Rasterio.Band;

class Program
{
    static void Main()
    {
        string filePath = "path/to/satellite/image.tif";

        using (var dataset = Dataset.Open(filePath, AccessType.GA_ReadOnly))
        {
            if (dataset != null)
            {
                Band greenBand = dataset.GetBand(3); // Assuming green band is band 3
                Band nirBand = dataset.GetBand(4); // Assuming NIR band is band 4

                float[] greenData = greenBand.ReadRaster(0, 0, dataset.Width, dataset.Height);
                float[] nirData = nirBand.ReadRaster(0, 0, dataset.Width, dataset.Height);

                int vegetationCount = 0;

                for (int i = 0; i < greenData.Length; i++)
                {
                    float ndvi = (nirData[i] - greenData[i]) / (nirData[i] + greenData[i]);

                    if (ndvi > 0.3) // Threshold for vegetation
                    {
                        vegetationCount++;
                    }
                }

                Console.WriteLine($"Number of vegetation pixels: {vegetationCount}");
            }
            else
            {
                Console.WriteLine("Failed to open dataset.");
            }
        }
    }
}
