using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.Interfaces;
using FunctionLibrary.MemoryManagement;
using System.Drawing;
using FunctionLibrary.ImageProcessing;

namespace FunctionLibrary.ImageFunctions
{
    public class ImageFunctions : IModel
    {
        private IImageMemoryManagement _images;

        private IImageProcessor _imageProcessor;

        /// <summary>
        /// Constructor for ImageModel
        /// </summary>
        public ImageFunctions()
        {
            _images = new ImageMemoryManagement();

            _imageProcessor = new ImgProcessor();
        }

        #region IModel implementation
        /// <summary>
        /// Uses ImageProcessor library to return collection of images. Use of GUID
        /// to provide random ID to adhere to IModel.
        /// 
        /// Works through passing the same reference back to two classes. One class can request
        /// the data stored with a key value matching the one stored in the returned list.
        /// 
        /// Code Snippet: GUID usage,
        /// Modified from https://stackoverflow.com/a/11313258 and attributed to user Jaime Torres.
        /// </summary>
        /// <param name="pathfilenames"></param>
        /// <returns>
        /// GUID reference to a correctly formatted image that can be
        /// loaded from memory. 
        /// </returns>
        public IList<string> load(IList<string> pathfilenames)
        {
            IList<string> imageReference;
            imageReference = new List<string>();
            foreach (string filelocation in pathfilenames)
            {
                Image image = _imageProcessor.Load(filelocation);
                string id = Guid.NewGuid().ToString();
                _images.Set(id, image);
                imageReference.Add(id);
            }
            return imageReference;
        }

        /// <summary>
        /// Returns the image held in a collection within
        /// memory management class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <returns>
        /// An image based off of a passed key, which will match the key
        /// of the dictionary used to store all of the images within memory.
        /// </returns>
        public Image getImage(string key, int frameWidth, int frameHeight)
        {
            return _imageProcessor.Resize(_images.Get(key), new Size(frameWidth, frameHeight));
        }

        /// <summary>
        /// Calls Imageprocessor library to rotate an image
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <param name="pAngle"></param>
        /// <returns></returns>
        public Image rotateImage(string key, int frameWidth, int frameHeight, float pAngle)
        {
            Image image = getImage(key, frameWidth, frameHeight);
            image = _imageProcessor.Rotate(image, pAngle);
            _images.Set(key, image);
            return image;
        }

        /// <summary>
        /// Calls Imageprocessor library to flip an image
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <param name="pVertical"></param>
        /// <returns></returns>
        public Image flipImage(string key, int frameWidth, int frameHeight, bool pVertical)
        {
            Image image = getImage(key, frameWidth, frameHeight);
            image = _imageProcessor.Flip(image, pVertical);
            _images.Set(key, image);
            return image;
        }

        /// <summary>
        /// Calls Imageprocessor library to resize an image
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <returns></returns>
        public Image resizeImage(string key, int frameWidth, int frameHeight)
        {
            Image image = getImage(key, frameWidth, frameHeight);
            _images.Set(key, image);
            return image;
        }
        #endregion
    }
}
