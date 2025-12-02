using System;
using System.Collections.Generic;
using System.IO;
using DlibDotNet;
using DlibDotNet.Extensions;

class FaceRecognition
{
    static void Main(string[] args)
    {
        // Paths to data
        string shapePredictorPath = "shape_predictor_68_face_landmarks.dat";
        string faceRecognitionModelPath = "dlib_face_recognition_resnet_model_v1.dat";

        // Initialize face detector, shape predictor, and face recognition model
        using (var detector = Dnn.GetFrontalFaceDetector())
        using (var shapePredictor = ShapePredictor.Deserialize(shapePredictorPath))
        using (var faceRecognitionModel = LossMetric.Deserialize(faceRecognitionModelPath))
        {
            // Load known faces and their descriptors
            var knownFaces = new Dictionary<string, List<Matrix<float>>>()
            {
                { "Person1", new List<Matrix<float>>() },
                { "Person2", new List<Matrix<float>>() }
                // Add more persons as needed
            };

            // Example: Load known images and compute their descriptors
            foreach (var person in knownFaces.Keys)
            {
                var imagesDirectory = Path.Combine("known_faces", person);
                var imageFiles = Directory.GetFiles(imagesDirectory, "*.jpg");
                foreach (var imageFile in imageFiles)
                {
                    using (var img = Dlib.LoadImage<RgbPixel>(imageFile))
                    {
                        var faces = detector.Operator(img);
                        if (faces.Length > 0)
                        {
                            var shape = shapePredictor.Detect(img, faces[0]);
                            var faceDescriptor = faceRecognitionModel.ComputeDescriptor(img, shape);
                            knownFaces[person].Add(faceDescriptor);
                        }
                    }
                }
            }

            // Load an unknown image to identify
            string unknownImagePath = "unknown.jpg";
            using (var img = Dlib.LoadImage<RgbPixel>(unknownImagePath))
            {
                var faces = detector.Operator(img);
                foreach (var face in faces)
                {
                    var shape = shapePredictor.Detect(img, face);
                    var faceDescriptor = faceRecognitionModel.ComputeDescriptor(img, shape);

                    // Compare to known faces
                    string identifiedPerson = "Unknown";
                    double minDistance = double.MaxValue;

                    foreach (var person in knownFaces.Keys)
                    {
                        foreach (var knownDescriptor in knownFaces[person])
                        {
                            var distance = Dlib.Length(faceDescriptor - knownDescriptor);
                            if (distance < minDistance)
                            {
                                minDistance = distance;
                                identifiedPerson = person;
                            }
                        }
                    }

                    // Set a threshold for recognition
                    const double threshold = 0.6;
                    if (minDistance > threshold)
                        identifiedPerson = "Unknown";

                    // Output result
                    Console.WriteLine($"Detected {identifiedPerson} at {face.Rect} with distance {minDistance}");
                }
            }
        }
    }
}