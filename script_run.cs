
using Rasterio;

public class VegetationAnalyzer
{
    public static void Main(string[] args)
    {
        string filePath = "path_to_your_satellite_image.tif";
        
        using (var dataset = Rasterio.Dataset.Open(filePath))
        {
            int width = dataset.Width;
            int height = dataset.Height;
            
            double[] redBand = dataset.ReadRaster(1);
            double[] nirBand = dataset.ReadRaster(4);
            
            double[] ndviValues = new double[width * height];
            
            for (int i = 0; i < ndviValues.Length; i++)
            {
                double ndvi = (nirBand[i] - redBand[i]) / (nirBand[i] + redBand[i]);
                ndviValues[i] = ndvi;
            }
            
            // Calculate average NDVI value for vegetation
            double sum = 0;
            foreach (var value in ndviValues)
            {
                sum += value;
            }
            double averageNDVI = sum / ndviValues.Length;
            
            Console.WriteLine("Average NDVI value for vegetation: " + averageNDVI);
        }
    }
}
