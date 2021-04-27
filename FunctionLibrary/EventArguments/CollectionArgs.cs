using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary.EventArguments
{
    /// <summary>
    /// Argument class to hold collection of Images
    /// 
    /// Author: Benedict Gardner
    /// </summary>
    public class CollectionArgs : EventArgs
    {
        public IDictionary<string, Image> _imageCollection
        { get; set; }

        /// <summary>
        /// Intantiate collection class with passed images
        /// </summary>
        /// <param name="pImages"></param>
        public CollectionArgs(IDictionary<string, Image> pImages)
        {
            this._imageCollection = pImages;
        }
    }
}
