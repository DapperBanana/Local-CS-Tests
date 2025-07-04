
using System;
using OpenCvSharp;

class Program
{
    static void Main()
    {
        Mat image = new Mat("input.jpg", ImreadModes.Color);

        Mat gray = new Mat();
        Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

        Mat binary = new Mat();
        Cv2.Threshold(gray, binary, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        Cv2.BitwiseNot(binary, binary);

        Mat[] contours;
        HierarchyIndex[] hierarchyIndexes;
        Cv2.FindContoursAsArray(binary, out contours, out hierarchyIndexes, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

        Mat segmentation = Mat.Zeros(image.Size(), MatType.CV_8UC3);
        for (int i = 0; i < contours.Length; i++)
        {
            Cv2.DrawContours(segmentation, contours, i, Scalar.RandomColor(), -1);
        }

        Cv2.ImShow("Segmentation", segmentation);
        Cv2.WaitKey();
    }
}
