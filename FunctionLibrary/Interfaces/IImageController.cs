using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary.Interfaces
{
    public interface IImageController
    {
        IList<string> Load(IList<String> pFilePath);

        Image Get(string pIndex, int pWidth, int pHeight);

        Image Rotate(string pIndex, int pWidth, int pHeight, float pAngle);

        Image Flip(string pIndex, int pWidth, int pHeight, bool pVert, bool pHorz);

        Image Resize(string pIndex, int pWidth, int pHeight);
    }
}
