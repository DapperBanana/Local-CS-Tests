
using System;
using Python.Runtime;

namespace SatelliteImageryAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic rasterio = Py.Import("rasterio");

                string imagePath = "path_to_your_satellite_image.tif";
                using (var dataset = rasterio.open(imagePath))
                {
                    double[] redBand = dataset.Read(1);
                    double[] nirBand = dataset.Read(4);

                    double vegetationIndex = (nirBand - redBand) / (nirBand + redBand);

                    Console.WriteLine($"Vegetation index: {vegetationIndex}");
                }
            }
        }
    }
}
