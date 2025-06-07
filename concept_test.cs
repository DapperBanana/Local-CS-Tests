
using OpenCvSharp;
using System;

class Program
{
    static void Main(string[] args)
    {
        Mat image = Cv2.ImRead("example.jpg", ImreadModes.Color); // Read the image

        Mat dst = new Mat();
        Cv2.CvtColor(image, dst, ColorConversionCodes.BGR2GRAY); // Convert image to grayscale

        Cv2.Threshold(dst, dst, 128, 255, ThresholdTypes.Binary); // Apply thresholding

        Cv2.ImShow("Segmented Image", dst);
        Cv2.WaitKey(0);

        Cv2.DestroyAllWindows();
    }
}
