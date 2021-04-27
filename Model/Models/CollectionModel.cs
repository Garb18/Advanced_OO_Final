using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary.EventArguments;
using FunctionLibrary.Interfaces;
using Model.Interfaces;
using System.Drawing;

namespace Model.Models
{
    public class CollectionModel : ICollectionModel, ICollectionSubscriptionService
    {
        // DECLARE an event handler of type collection to communicate arguments
        private event EventHandler<CollectionArgs> _event;

        // DECLARE an IModel
        private IModel _imgFunctions;

        public CollectionModel(IModel pImgFunctions)
        {
            _imgFunctions = pImgFunctions;
        }

        /// <summary>
        /// Loads images selected from disk
        /// Recycled code from Milestone01
        /// </summary>
        /// <param name="pFileLocation"></param>
        /// <param name="imageWidth"></param>
        /// <param name="imageHeight"></param>
        public void Load(IList<string> pFileLocation, int imageWidth, int imageHeight)
        {
            IDictionary<string, Image> _images;
            _images = new Dictionary<string, Image>();

            foreach (string id in _imgFunctions.load(pFileLocation.ToList()))
            {
                _images.Add(id, _imgFunctions.getImage(id, imageWidth, imageHeight));
            }

            CollectionArgs args = new CollectionArgs(_images);
            _event(this, args);
        }

        #region ICollectionSubscriptionService implementation
        public void Subscribe(EventHandler<CollectionArgs> handler)
        {
            _event += handler;
        }

        public void Unsubscribe(EventHandler<CollectionArgs> handler)
        {
            _event -= handler;
        }
        #endregion
    }
}
