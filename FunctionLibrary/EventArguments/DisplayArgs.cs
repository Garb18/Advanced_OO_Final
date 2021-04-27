using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary.EventArguments
{
    /// <summary>
    /// Argument class to hold selected image
    /// 
    /// Author: Benedict Gardner
    /// </summary>
    public class DisplayArgs : EventArgs
    {
        public Image Image { get; set; }

        public DisplayArgs(Image pImage)
        {
            Image = pImage;
        }
    }
}
