
using Rasterio;

namespace SatelliteImageAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "path_to_satellite_image.tif"; // Path to the satellite image file
            Dataset dataset = Dataset.Open(path, FileMode.ReadOnly);

            Band redBand = dataset.GetBand(1); // Red band
            Band nirBand = dataset.GetBand(4); // Near-infrared band

            double[] redValues = redBand.ReadRaster(0, 0, redBand.Width, redBand.Height);
            double[] nirValues = nirBand.ReadRaster(0, 0, nirBand.Width, nirBand.Height);

            double vegetationIndex = CalculateVegetationIndex(redValues, nirValues);

            Console.WriteLine($"Vegetation index: {vegetationIndex}");

            dataset.Dispose();
        }

        static double CalculateVegetationIndex(double[] redValues, double[] nirValues)
        {
            double vegetationIndex = 0;

            for (int i = 0; i < redValues.Length; i++)
            {
                vegetationIndex += (nirValues[i] - redValues[i]) / (nirValues[i] + redValues[i]);
            }

            vegetationIndex /= redValues.Length;

            return vegetationIndex;
        }
    }
}
