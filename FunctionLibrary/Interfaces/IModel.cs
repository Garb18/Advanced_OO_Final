using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FunctionLibrary.Interfaces
{
    /// <summary>
    /// Expanded IModel interface from Milestone01, with expanded functionality
    /// 
    /// Authors: Marc Price, Benedict Gardner
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the 'Model'
        /// </summary>
        /// <param name="pathfilenames">a vector of strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        IList<String> load(IList<String> pathfilenames);

        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimentsions of the visual container (ie frame) it will be viewed in.
        /// </summary>
        /// <param name="key">the unique identifier for the image to be returned</param>
        /// <param name="frameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="frameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image pointed identified by key</returns>
        Image getImage(string key, int frameWidth, int frameHeight);

        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimensions of the visual container to be viewed in and rotated accordingly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <param name="rotateDegrees"></param>
        /// <returns></returns>
        Image rotateImage(string key, int frameWidth, int frameHeight, float pDegrees);

        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimensions of the visual container and flipped accordingly
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <param name="flipVeritcal"></param>
        /// <param name="flipHorizontal"></param>
        /// <returns></returns>
        Image flipImage(string key, int frameWidth, int frameHeight, bool pVertical);

        /// <summary>
        /// Return a copy of the image specified by 'key', accordingly resized
        /// </summary>
        /// <param name="key"></param>
        /// <param name="frameWidth"></param>
        /// <param name="frameHeight"></param>
        /// <returns></returns>
        Image resizeImage(string key, int frameWidth, int frameHeight);
    }
}
