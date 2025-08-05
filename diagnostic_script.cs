
using System;
using System.Collections.Generic;
using System.Drawing;
using DlibDotNet;
using DlibDotNet.Extensions;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            var shapePredictorPath = "shape_predictor_68_face_landmarks.dat";
            var faceRecognitionModelPath = "dlib_face_recognition_resnet_model_v1.dat";

            using (var sp = ShapePredictor.Deserialize(shapePredictorPath))
            using (var net = LossMetric.Deserialize(faceRecognitionModelPath))
            {
                // Load an image to perform face recognition
                var image = LoadImage("test.jpg");

                // Detect faces in the image
                var detector = Dlib.GetFrontalFaceDetector();
                var faces = detector.Operator(image);

                // Iterate over each detected face
                foreach (var face in faces)
                {
                    // Get the face landmarks
                    var shape = sp.Detect(image, face);

                    // Perform face recognition
                    var faceDescriptor = net.ComputeFaceDescriptor(image, shape);

                    // Print the face descriptor
                    Console.WriteLine($"Face Descriptor: {string.Join(", ", faceDescriptor)}");
                }
            }
        }

        private static Array2D<RgbPixel> LoadImage(string filePath)
        {
            // Load the image using the Dlib library
            var image = Dlib.LoadImage<RgbPixel>(filePath);

            return image;
        }
    }
}
