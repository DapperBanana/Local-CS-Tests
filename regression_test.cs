
using System;
using Rasterio;

namespace NDVIAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the satellite image file
            Dataset image = Dataset.Open("path/to/satellite/image.tif", Access.ReadOnly);

            // Read the red and near-infrared bands
            Band redBand = image.GetBand(3);
            Band nirBand = image.GetBand(4);

            // Calculate NDVI pixel by pixel
            float[] redData = redBand.ReadAsArray().Data<float>();
            float[] nirData = nirBand.ReadAsArray().Data<float>();

            float[] ndviData = new float[redData.Length];
            for (int i = 0; i < redData.Length; i++)
            {
                ndviData[i] = (nirData[i] - redData[i]) / (nirData[i] + redData[i]);
            }

            // Write NDVI values to a new output raster
            string outputFilePath = "path/to/output/ndvi.tif";
            using (var outputImage = Rasterio.Rasterize(outputFilePath, image.Width, image.Height, 1, DataType.Float32))
            {
                outputImage.WriteBand(1, ndviData);
            }

            Console.WriteLine("NDVI calculation completed. Output saved to " + outputFilePath);
        }
    }
}
