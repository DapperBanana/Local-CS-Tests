
using DlibDotNet;
using DlibDotNet.Extensions;
using System;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load face recognition models
            var faceRecognition = Dlib.GetFrontalFaceDetector();
            var shapePredictor = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat");
            var faceRecognitionModel = Dlib.GetFaceRecognitionModel();

            // Load images for face recognition
            var img1 = Dlib.LoadImageAsMatrix("image1.jpg");
            var img2 = Dlib.LoadImageAsMatrix("image2.jpg");

            // Detect faces in the images
            var faces1 = faceRecognition.Operator(img1);
            var faces2 = faceRecognition.Operator(img2);

            // Get facial landmarks for the detected faces
            var shape1 = shapePredictor.Detect(img1, faces1[0]);
            var shape2 = shapePredictor.Detect(img2, faces2[0]);

            // Compute face descriptors for the detected faces
            var faceDesc1 = faceRecognitionModel.ComputeFaceDescriptor(img1, shape1);
            var faceDesc2 = faceRecognitionModel.ComputeFaceDescriptor(img2, shape2);

            // Compute the distance between the face descriptors
            var distance = Dlib.Distance(faceDesc1, faceDesc2);

            // Output the result
            Console.WriteLine($"Distance between the faces: {distance}");
        }
    }
}
