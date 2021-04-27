using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FunctionLibrary.Interfaces;

namespace FunctionLibrary.MemoryManagement
{
    /// <summary>
    /// Acts as memory storage and retrieval
    /// which stores all images passed
    /// through into a collection.
    /// 
    /// Author: Benedict Gardner
    /// </summary>
    public class ImageMemoryManagement : IImageMemoryManagement
    {
        // DECLARE an IDictionary to store Images, call it '_images'
        private IDictionary<string, Image> _imageCollection;

        public ImageMemoryManagement()
        {
            //INSTANTIATE IDctionary as type Dictionary
            _imageCollection = new Dictionary<string, Image>();
        }

        /// <summary>
        /// Sets an image in at a location in memory
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pImage"></param>
        public void Set(string pId, Image pImage)
        {
            if (!_imageCollection.ContainsKey(pId))
            {
                _imageCollection.Add(pId, pImage);
            }
            else
            {
                _imageCollection[pId] = pImage;
            }
        }

        /// <summary>
        /// Returns image held in memory based on requested ID in dictionary
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Image Get(string pId)
        {
            return _imageCollection[pId];
        }
    }
}
