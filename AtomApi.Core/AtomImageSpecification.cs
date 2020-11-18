using System;
using System.Collections.Generic;
using System.Text;

namespace AtomApi.Core
{
    public class AtomImageSpecification
    {
        public string ImageFileName { get; set; }
        public string Watermark { get; set; }
        public string ImageFileExtension { get; set; }
        public string BackgroundColour { get; set; }
        public float VerticalResolution { get; set; }
        public float HorizontalResolution { get; set; }
    }
}
