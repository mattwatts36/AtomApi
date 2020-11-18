using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AtomApi.Core.Models
{
    public class AtomImage
    {
        public Image RequestedImage { get; set; }
        public string FileName { get; set; }
    }
}
