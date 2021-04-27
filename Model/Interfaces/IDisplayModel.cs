using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    /// <summary>
    /// Interface for the DisplayModel
    /// </summary>
    public interface IDisplayModel
    {
        void Load(string pId, int pWidth, int pHeight);

        void Resize(string pId, int pWidth, int pHeight);

        void Rotate(string pId, int pWidth, int pHeight, float pAngle);

        void Flip(string pID, int pWidth, int pHeight, bool pVertical);
    }
}
