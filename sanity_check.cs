
using System;
using OpenCvSharp;

class Program
{
    static void Main()
    {
        Mat image = new Mat("image.jpg", ImreadModes.Color);

        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 127, 255, ThresholdTypes.Binary);

        Mat[] contours;
        HierarchyIndex[] hierarchy;

        Cv2.FindContours(binaryImage, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

        Mat segmented = Mat.Zeros(image.Size(), MatType.CV_8UC3);
        foreach (var contour in contours)
        {
            Cv2.DrawContours(segmented, new[] { contour }, 0, Scalar.White, -1);
        }

        Cv2.ImShow("Segmented Image", segmented);
        Cv2.WaitKey(0);
    }
}
