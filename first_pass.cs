
using Rasterio;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "path/to/your/satellite/image.tif";

        using (var dataset = Dataset.Open(filePath, "r"))
        {
            int width = dataset.Width;
            int height = dataset.Height;

            int[] redBand = dataset.ReadRaster(1, 0, width, height);
            int[] nirBand = dataset.ReadRaster(4, 0, width, height);

            double[] ndvi = CalculateNDVI(redBand, nirBand);

            double vegetationPercentage = CalculateVegetationPercentage(ndvi);

            Console.WriteLine("Vegetation percentage: " + vegetationPercentage);
        }
    }

    static double[] CalculateNDVI(int[] redBand, int[] nirBand)
    {
        double[] ndvi = new double[redBand.Length];

        for (int i = 0; i < redBand.Length; i++)
        {
            ndvi[i] = (nirBand[i] - redBand[i]) / (nirBand[i] + redBand[i]);
        }

        return ndvi;
    }

    static double CalculateVegetationPercentage(double[] ndvi)
    {
        int count = 0;

        foreach (var value in ndvi)
        {
            if (value > 0.5 && value <= 1.0)
            {
                count++;
            }
        }

        return (double)count / ndvi.Length * 100;
    }
}
