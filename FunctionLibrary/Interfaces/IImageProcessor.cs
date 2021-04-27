using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;

namespace FunctionLibrary.Interfaces
{
    /// <summary>
    /// Image Processor library implementation
    /// 
    /// Author: Benedict Gardner
    /// </summary>
    public interface IImageProcessor
    {
        Image Load(string pFilePath);

        Image Resize(Image pImage, Size pSize);

        Image Rotate(Image pImage, float pAngle);

        Image Flip(Image pImage, bool pVertical);
    }
}
