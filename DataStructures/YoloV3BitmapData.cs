using Microsoft.ML.Data;
using Microsoft.ML.Transforms.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMauiObjectDetectionML.DataStructures
{
    public class YoloV3BitmapData
    {
        [ColumnName("bitmap")]
        [ImageType(416, 416)]
        public MLImage? Image { get; set; }

        [ColumnName("width")]
        public float ImageWidth => this.Image.Width;

        [ColumnName("height")]
        public float ImageHeight => this.Image.Height;
    }
}
