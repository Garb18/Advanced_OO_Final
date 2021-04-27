using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.Interfaces;
using ImageProcessor;
using System.Drawing;

namespace FunctionLibrary.ImageProcessing
{
    public class ImgProcessor : IImageProcessor
    {
        // DECLARE an image factory
        private ImageFactory _imageFactory;

        public ImgProcessor()
        {
            // INSTANTIATE an image factory
            _imageFactory = new ImageFactory();
        }

        /// <summary>
        /// Uses image factory to load image from filepath to memory
        /// </summary>
        /// <param name="pImagePath"></param>
        /// <returns></returns>
        public Image Load(string pImagePath)
        {
            _imageFactory.Load(pImagePath);
            return _imageFactory.Image;
        }

        /// <summary>
        /// Uses image factory to resize passed image
        /// </summary>
        /// <param name="pImage"></param>
        /// <param name="pSize"></param>
        /// <returns></returns>
        public Image Resize(Image pImage, Size pSize)
        {
            _imageFactory.Load(pImage);
            _imageFactory.Resize(pSize);
            return _imageFactory.Image;
        }

        /// <summary>
        /// Uses image factory to rotate passed image
        /// </summary>
        /// <param name="pImage"></param>
        /// <param name="pAngle"></param>
        /// <returns></returns>
        public Image Rotate(Image pImage, float pAngle)
        {
            _imageFactory.Load(pImage);
            _imageFactory.Rotate(pAngle);
            return _imageFactory.Image;
        }

        /// <summary>
        /// Uses image factory to flip passed image
        /// </summary>
        /// <param name="pImage"></param>
        /// <param name="pVertical"></param>
        /// <returns></returns>
        public Image Flip(Image pImage, bool pVertical)
        {
            _imageFactory.Load(pImage);
            _imageFactory.Flip(pVertical);
            return _imageFactory.Image;
        }
    }
}
