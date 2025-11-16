
using DlibDotNet;
using System;
using System.Drawing;
using System.IO;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the face detector
            using (var detector = Dlib.GetFrontalFaceDetector())
            {
                // Load the input image
                var inputImagePath = "input.jpg";
                var inputImage = Dlib.LoadImage<RGBPixel>(inputImagePath);

                // Detect faces in the image
                var rects = detector.Operator(inputImage);

                // Load the face recognition model
                using (var shapePredictor = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat"))
                using (var net = DlibDotNet.Dnn.Deserialize("dlib_face_recognition_resnet_model_v1.dat"))
                {
                    // Load pre-trained face recognition model
                    using (var recognitiion = Dlib.FaceRecognition.Create(net, shapePredictor))
                    {
                        // Iterate through the detected faces
                        foreach (var rect in rects)
                        {
                            var shape = shapePredictor.Detect(inputImage, rect);

                            var faceDescriptors = recognitiion.ComputeFaceDescriptors(inputImage, shape);

                            // Perform face recognition
                            var result = recognitiion.ComputeFaceDescriptor(inputImage, shape);

                            // Output the result
                            Console.WriteLine($"Detected face at: {rect.Left}, {rect.Top}");
                        }
                    }
                }
            }
        }
    }
}
