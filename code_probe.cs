
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibFaceLandmarkDetector;
using System;
using System.Drawing;
using System.IO;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load face detector and shape predictor models
            var faceDetector = Dlib.GetFrontalFaceDetector();
            var shapePredictor = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat");

            // Load test image
            var imagePath = "test.jpg";
            var image = LoadImage(imagePath);

            // Detect faces in the image
            var faces = faceDetector.Operator(image);
            Console.WriteLine($"Number of faces detected: {faces.Length}");

            // Iterate through each detected face and perform face recognition
            foreach (var face in faces)
            {
                // Get facial landmarks
                var landmarks = shapePredictor.Detect(image, face);

                // Perform face recognition
                // In this example, we are simply printing the coordinates of the facial landmarks
                foreach (var landmark in landmarks)
                {
                    Console.WriteLine($"Landmark: {landmark}");
                }
            }
        }

        static Array2D<RGBPixel> LoadImage(string path)
        {
            using (var bitmap = new Bitmap(path))
            {
                var array = new Array2D<RGBPixel>(bitmap.Height, bitmap.Width);
                DlibDotNet.Dlib.LoadImage(bitmap, array);
                return array;
            }
        }
    }
}
