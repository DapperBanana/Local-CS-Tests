
using DlibDotNet;
using System;
using System.Collections.Generic;
using System.IO;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            var recognitionFilePath = "dlib_face_recognition_resnet_model_v1.dat";
            var shapePredictorPath = "shape_predictor_5_face_landmarks.dat";

            // Load models
            using (var recognitionNet = Dlib.FaceRecognitionNet.Deserialize(recognitionFilePath))
            using (var sp = ShapePredictor.Deserialize(shapePredictorPath))
            {
                // Load image to recognize
                var testImagePath = "test_image.jpg";
                var testImage = Dlib.LoadImage<RgbPixel>(testImagePath);

                // Detect face in the image
                var faces = Dlib.FaceDetectors.GetFrontalFaceDetector().Operator(testImage);
                if (faces.Count == 0)
                {
                    Console.WriteLine("No faces detected in the image");
                    return;
                }

                // Get face descriptor
                var shape = sp.Detect(testImage, faces[0]);
                var faceDescriptor = recognitionNet.ComputeFullObjectDetectionDescriptor(testImage, shape);

                // Load dataset with known face descriptors
                var datasetPath = "known_faces_dataset.txt";
                var knownFaces = LoadKnownFaces(datasetPath);

                // Compare face descriptor to database and find the closest match
                string closestMatch = null;
                double minDistance = double.MaxValue;
                foreach (var pair in knownFaces)
                {
                    var distance = Dlib.Length(faceDescriptor - pair.Value);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestMatch = pair.Key;
                    }
                }

                Console.WriteLine($"Closest match: {closestMatch}, Distance: {minDistance}");
            }
        }

        static Dictionary<string, Matrix<double>> LoadKnownFaces(string datasetPath)
        {
            var knownFaces = new Dictionary<string, Matrix<double>>();

            using (var file = new StreamReader(datasetPath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    var name = parts[0];
                    var values = parts[1].Split(';');
                    var descriptor = new Matrix<double>(values.Length);

                    for (int i = 0; i < values.Length; i++)
                        descriptor[i] = double.Parse(values[i]);

                    knownFaces.Add(name, descriptor);
                }
            }

            return knownFaces;
        }
    }
}
