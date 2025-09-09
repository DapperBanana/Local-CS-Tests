
using System;
using OpenCvSharp;

class Program
{
    static void Main()
    {
        Mat image = new Mat("input.jpg", ImreadModes.Color);

        Mat gray = new Mat();
        Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

        Mat threshold = new Mat();
        Cv2.Threshold(gray, threshold, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        Mat[] contours;
        Mat hierarchy = new Mat();
        Cv2.FindContours(threshold, out contours, hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);

        Mat result = new Mat(image.Size(), MatType.CV_8UC3, Scalar.All(0));
        
        for (int i = 0; i < contours.Length; i++)
        {
            Cv2.DrawContours(result, contours, i, new Scalar(255, 255, 255), -1);
        }

        Cv2.ImShow("Result", result);
        Cv2.WaitKey(0);
    }
}
