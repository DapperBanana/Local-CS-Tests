
using System;
using OpenCvSharp;

class Program
{
    static void Main()
    {
        Mat image = Cv2.ImRead("image.jpg", ImreadModes.Color);

        if (image.Empty())
        {
            Console.WriteLine("Failed to load image!");
            return;
        }

        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        Mat[] contours;
        Mat hierarchy = new Mat();
        Cv2.FindContours(binaryImage, out contours, hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

        Mat resultImage = Mat.Zeros(image.Size(), MatType.CV_8UC3);
        
        int index = 0;
        foreach (var contour in contours)
        {
            Cv2.DrawContours(resultImage, contours, index, new Scalar(255, 255, 255), -1);
            index++;
        }

        Cv2.ImShow("Segmented Image", resultImage);
        Cv2.WaitKey();

        Cv2.DestroyAllWindows();
    }
}
