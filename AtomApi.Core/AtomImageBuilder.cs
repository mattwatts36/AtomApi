using System.Drawing;
using AtomApi.Core.Models;

namespace AtomApi.Core
{
    public class AtomImageBuilder
    {
        public AtomImage AtomImage { get; set; }
        private readonly AtomImageSpecification _atomImageSpecification;
        private readonly string _imageFileLocation;

        public AtomImageBuilder(AtomImageSpecification atomImageSpecification, string imageFileLocation)
        {
            _atomImageSpecification = atomImageSpecification;
            _imageFileLocation = imageFileLocation;
        }

        public AtomImageBuilder Build()
        {
            return this;
        }

        public void AddWatermarkTextToImage()
        {
            var currentImageFile = Bitmap.FromFile(_imageFileLocation);
            var imageFileWithWatermark = new Bitmap(currentImageFile.Width, currentImageFile.Height + 50);

            var graphicFileToAddWatermark = Graphics.FromImage(imageFileWithWatermark);
            graphicFileToAddWatermark.DrawImageUnscaled(currentImageFile, 50, 50);
            graphicFileToAddWatermark.DrawString(_atomImageSpecification.Watermark, SystemFonts.DefaultFont, Brushes.Black,
                new RectangleF(0, currentImageFile.Height, currentImageFile.Width, 50));
            
            AtomImage.RequestedImage = imageFileWithWatermark;
        }

        public void ChangeImageResolution()
        {
            var currentImageFile = Bitmap.FromFile(_imageFileLocation);
            var newFile = new Bitmap(currentImageFile);
            
            newFile.SetResolution(_atomImageSpecification.HorizontalResolution, _atomImageSpecification.VerticalResolution);
            
            AtomImage.RequestedImage = newFile;
        }

        public void ChangeImageBackGroundColor()
        {
            var currentImageFile = Bitmap.FromFile(_imageFileLocation);
            var newImageFile = Graphics.FromImage(currentImageFile);

            newImageFile.Clear(Color.FromName(_atomImageSpecification.BackgroundColour));

            AtomImage.RequestedImage = currentImageFile;
        }


    }
}
