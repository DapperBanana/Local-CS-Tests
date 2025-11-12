
using System;
using System.Drawing;
using FaceRecognitionWrapper;

namespace FaceRecognitionApp {
    class Program {
        static void Main(string[] args) {
            Bitmap image = new Bitmap("path/to/image.jpg");
            FaceRecognition faceRecognition = new FaceRecognition();
            faceRecognition.DetectFaces(image);
            image.Save("path/to/output.jpg");
        }
    }
}
