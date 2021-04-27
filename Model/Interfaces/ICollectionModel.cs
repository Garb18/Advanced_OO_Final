using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface ICollectionModel
    {
        void Load(IList<string> pFileLocation, int Width, int Height);
    }
}
