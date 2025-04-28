
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Dnn;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Load pre-trained face detection model
        Net faceDetectionNet = DnnInvoke.ReadNetFromCaffe("deploy.prototxt", "res10_300x300_ssd_iter_140000.caffemodel");

        // Load pre-trained face recognition model
        using (FaceRecognition recognizer = new FaceRecognition())
        {
            // Capture video from webcam
            VideoCapture capture = new VideoCapture(0);

            while (true)
            {
                // Read frame from webcam
                Mat frame = capture.QueryFrame();
                if (frame == null)
                    break;

                // Detect faces in the frame
                List<Rectangle> faces = DetectFaces(frame, faceDetectionNet);

                // Recognize faces
                foreach (Rectangle face in faces)
                {
                    Mat faceImage = new Mat(frame, face);
                    string name = recognizer.Recognize(faceImage);

                    CvInvoke.Rectangle(frame, face, new MCvScalar(0, 255, 0), 2);
                    CvInvoke.PutText(frame, name, new System.Drawing.Point(face.Left, face.Top - 10), FontFace.HersheyComplex, 0.8, new MCvScalar(0, 255, 0));
                }

                CvInvoke.Imshow("Face Recognition", frame);
                if (CvInvoke.WaitKey(1) == 27) // ESC key to exit
                    break;
            }

            capture.Release();
            CvInvoke.DestroyAllWindows();
        }
    }

    static List<Rectangle> DetectFaces(Mat frame, Net faceDetectionNet)
    {
        List<Rectangle> faces = new List<Rectangle>();

        Mat inputBlob = DnnInvoke.BlobFromImage(frame, 1.0, new System.Drawing.Size(300, 300), new MCvScalar(104, 177, 123));

        faceDetectionNet.SetInput(inputBlob);

        Mat detection = faceDetectionNet.Forward();
        for (int i = 0; i < detection.SizeOfDimension[2]; i++)
        {
            float confidence = detection.GetData(0, i, 2)[0];
            if (confidence > 0.5)
            {
                int x = (int)(detection.GetData(0, i, 3)[0] * frame.Width);
                int y = (int)(detection.GetData(0, i, 4)[0] * frame.Height);
                int w = (int)(detection.GetData(0, i, 5)[0] * frame.Width) - x;
                int h = (int)(detection.GetData(0, i, 6)[0] * frame.Height) - y;

                faces.Add(new Rectangle(x, y, w, h));
            }
        }

        return faces;
    }
}
