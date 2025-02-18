
using DlibDotNet;
using DlibDotNet.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the dlib shape predictor model and face recognition model
            using (var predictor = Dlib.GetShapePredictor("shape_predictor_68_face_landmarks.dat"))
            using (var net = Dlib.GetFrontalFaceDetector())
            using (var recognitionNet = Dlib.GetFaceRecognitionNet())
            {
                // Load the image containing the face to recognize
                var image = Dlib.LoadImageAsMatrix<RGBPixel>("test_image.jpg");

                // Detect faces in the image
                var faces = net.Operator(image);

                if (faces.Length == 0)
                {
                    Console.WriteLine("No faces found in the image.");
                    return;
                }

                // Get the shape of the first face found in the image
                var shape = predictor.Detect(image, faces[0]);

                // Recognize the face
                var faceDescriptor = recognitionNet.ComputeFaceDescriptor(image, shape);

                // Load a database of known face descriptors
                var knownDescriptors = new List<Matrix<double>>();
                // Add known face descriptors to the list

                // Calculate the Euclidean distance between the face descriptor of the detected face and each known face descriptor
                var distances = knownDescriptors.Select(descriptor => Dlib.Length(faceDescriptor - descriptor)).ToArray();

                // Find the index of the closest match
                var minDistanceIndex = Array.IndexOf(distances, distances.Min());

                // Output the name of the recognized person
                Console.WriteLine($"Recognized person: Person{minDistanceIndex + 1}");
            }
        }
    }
}
