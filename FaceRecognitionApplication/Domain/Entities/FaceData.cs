using System;
using System.Collections.Generic;
using System.Text;

namespace FaceRecognitionApplication.Domain.Model
{
    public class FaceData
    {
        public int FaceLabel { get; set; }
        public List<Face> Faces { get; set; }
    }
}
