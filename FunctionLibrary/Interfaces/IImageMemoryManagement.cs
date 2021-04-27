using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FunctionLibrary.Interfaces
{
    public interface IImageMemoryManagement
    {
        /// <summary>
        /// Set an image in memory if it does not already exist at that location in memory
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pImage"></param>
        void Set(string pId, Image pImage);

        /// <summary>
        /// Return an image held in memory based on requested ID in collection
        /// </summary>
        /// <param name="pFilePath"></param>
        /// <returns></returns>
        Image Get(string pFilePath);
    }
}
