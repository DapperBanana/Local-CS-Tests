
using System;
using OpenCvSharp;

namespace ImageSegmentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat image = Cv2.ImRead("input_image.jpg", ImreadModes.Color);

            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            Mat binaryImage = new Mat();
            Cv2.Threshold(grayImage, binaryImage, 127, 255, ThresholdTypes.Binary);

            using (Window window = new Window("Binary Image"))
            {
                window.ShowImage(binaryImage);

                Cv2.WaitKey();
            }
        }
    }
}
