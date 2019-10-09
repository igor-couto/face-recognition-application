using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceRecognitionApplication
{
    public class Face
    {
        public Image<Gray, byte> FaceImage { get; set; }
        public DateTime CaptureDate { get; set; }
        public bool IsMainPicture { get; set; }
    }
}