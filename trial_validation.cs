
using OpenCvSharp;
using System;

class Program
{
    static void Main(string[] args)
    {
        Mat image = Cv2.ImRead("image.jpg", ImreadModes.Color);
        
        if (image.Empty())
        {
            Console.WriteLine("Error: Image not found!");
            return;
        }

        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        using (Window window = new Window("Image segmentation", image))
        using (Window window2 = new Window("Binary image", binaryImage))
        {
            Cv2.WaitKey();
        }
    }
}
