using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;
using FunctionLibrary.Interfaces;
using FunctionLibrary.EventArguments;
using FunctionLibrary.ImageFunctions;
using System.Drawing;

namespace Model.Models
{
    /// <summary>
    /// Model for Display View
    /// </summary>
    public class DisplayModel : IDisplayModel, IDisplaySubscriptionService
    {
        private IModel _imageFunctions;

        private event EventHandler<DisplayArgs> _displayArguments;

        public DisplayModel(IModel pImageFunctions)
        {
            _imageFunctions = pImageFunctions;
        }

        #region IDisplayModel Implementation
        /// <summary>
        /// Loads a scaled image
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        public void Load(string pId, int pWidth, int pHeight)
        {
            Image img = _imageFunctions.getImage(pId, pWidth, pHeight);
            DisplayArgs e = new DisplayArgs(img);
            _displayArguments(this, e);
        }
        /// <summary>
        /// Rotates a scaled image
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <param name="pAngle"></param>
        public void Rotate(string pId, int pWidth, int pHeight, float pAngle)
        {
            Image img = _imageFunctions.rotateImage(pId, pWidth, pHeight, pAngle);
            DisplayArgs e = new DisplayArgs(img);
            _displayArguments(this, e);
        }
        /// <summary>
        /// Flips a scaled image
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        /// <param name="pVertical"></param>
        public void Flip(string pId, int pWidth, int pHeight, bool pVertical)
        {
            Image img = _imageFunctions.flipImage(pId, pWidth, pHeight, pVertical);
            DisplayArgs e = new DisplayArgs(img);
            _displayArguments(this, e);
        }
        /// <summary>
        /// Resizes an image to specified scale
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pWidth"></param>
        /// <param name="pHeight"></param>
        public void Resize(string pId, int pWidth, int pHeight)
        {
            Image img = _imageFunctions.resizeImage(pId, pWidth, pHeight);
            DisplayArgs e = new DisplayArgs(img);
            _displayArguments(this, e);
        }
        #endregion

        #region IDisplaySubscription Implementation
        public void Subscribe(EventHandler<DisplayArgs> eventHandler)
        {
            _displayArguments += eventHandler;
        }
        public void Unsubscribe(EventHandler<DisplayArgs> eventHandler)
        {
            _displayArguments -= eventHandler;
        }
        #endregion
    }
}
