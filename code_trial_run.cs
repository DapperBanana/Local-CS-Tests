
using System;
using OpenCvSharp;

class Program
{
    static void Main(string[] args)
    {
        Mat image = Cv2.ImRead("input_image.jpg", ImreadModes.Color);
        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        Mat threshImage = new Mat();
        Cv2.Threshold(grayImage, threshImage, 128, 255, ThresholdTypes.Binary);

        Mat[] contours;
        HierarchyIndex[] hierarchy;
        Cv2.FindContours(threshImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

        Mat result = Mat.Zeros(image.Size(), MatType.CV_8UC3);
        for (int i = 0; i < contours.Length; i++)
        {
            Cv2.DrawContours(result, contours, i, new Scalar(255, 255, 255), thickness: -1);
        }

        Cv2.ImShow("Segmented Image", result);
        Cv2.WaitKey(0);
    }
}
