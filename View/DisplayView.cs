using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionLibrary;
using FunctionLibrary.Interfaces;
using FunctionLibrary.EventArguments;

namespace View
{
    public partial class DisplayView : Form, IDisplayListenerService
    {
        // DECLARE an execute delegate
        private ExecuteDelegate _execute;

        // DECLARE ICommand to open the panel with passed action
        private ICommand _open;

        // DECLARE a string to hold a reference to image id/key in collection
        private string _id;

        // DECLARE a picturebox to act as a viewport
        private PictureBox _image;

        #region Action declereations
        //Load an image
        private Action<string, int, int> _load;
        // Rotate an image
        private Action<string, int, int, float> _rotate;
        // Flip an image vertically or horizontally
        private Action<string, int, int, bool> _flip;
        // Rescale an image
        private Action<string, int, int> _resize;
        // Save an image to disk
        private Action<Image> _save;
        #endregion

        /// <summary>
        /// Constructor, does nothing for weak coupling
        /// </summary>
        public DisplayView(){/*Do nothing*/}

        /// <summary>
        /// Initialise the component and set all passed parameters
        /// and finally open the panel with image properties
        /// </summary>
        /// <param name="pExecute"></param>
        /// <param name="pId"></param>
        /// <param name="pLoad"></param>
        /// <param name="pRotate"></param>
        /// <param name="pFlip"></param>
        /// <param name="pResize"></param>
        /// <param name="pSave"></param>
        public void Init(ExecuteDelegate pExecute, string pId, Action<string, int, int> pLoad, Action<string, int, int, float> pRotate, Action<string, int, int, bool> pFlip, Action<string, int, int> pResize, Action<Image> pSave)
        {
            InitializeComponent();

            #region Set variables
            _execute = pExecute;
            _id = pId;
            _load = pLoad;
            _rotate = pRotate;
            _flip = pFlip;
            _resize = pResize;
            _save = pSave;
            _image = new PictureBox();
            //Prevent shrinking as buttons end up disappearing
            this.MinimumSize = new Size(this.Width, this.Height);
            #endregion

            //EXECUTE command to open the view
            _open = new Command<string, int, int>(_load, _id, imagePanel.Width, imagePanel.Height);
            _execute(_open);
        }

        /// <summary>
        /// Method to resize imagePanel so the image
        /// scales up with the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewResize(object sender, EventArgs e)
        {
            //Ensures panel doesn't overlap viewport
            imagePanel.Width = Width - 40;
            imagePanel.Height = Height - 200;

            //Resize the image to fit new size
            ICommand resize = new Command<string, int, int>(_load, _id, imagePanel.Width, imagePanel.Height);
            _execute(resize);
        }

        #region Button Functionality
        /// <summary>
        /// Rotate the image left 90 degrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            ICommand rotateLeft = new Command<string, int, int, float>(_rotate, _id, imagePanel.Width, imagePanel.Height, -90);
            _execute(rotateLeft);
        }
        /// <summary>
        /// Rotate the image right 90 degrees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            ICommand rotateRight = new Command<string, int, int, float>(_rotate, _id, imagePanel.Width, imagePanel.Height, 90);
            _execute(rotateRight);
        }
        /// <summary>
        /// Flip the iamge vertically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlipVert_Click(object sender, EventArgs e)
        {
            ICommand flipVertically = new Command<string, int, int, bool>(_flip, _id, imagePanel.Width, imagePanel.Height, true);
            _execute(flipVertically);
        }
        /// <summary>
        /// Flip the image horizontally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            ICommand flipHorizontal = new Command<string, int, int, bool>(_flip, _id, imagePanel.Width, imagePanel.Height, false);
            _execute(flipHorizontal);
        }
        /// <summary>
        /// Resize image based on inputed size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResize_Click(object sender, EventArgs e)
        {
            ICommand resize = new Command<string, int, int>(_resize, _id, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            _execute(resize);
        }
        /// <summary>
        /// Save the image to disk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ICommand save = new Command<Image>(_save, _image.Image);
            _execute(save);
        }
        #endregion

        /// <summary>
        /// Listener method for new event 
        /// from an image in CollectionView
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void OnInput(object source, DisplayArgs e)
        {
            _image.Image = e.Image;
            _image.Location = new Point(0, 0);
            _image.Size = new Size(e.Image.Width, e.Image.Height);
            imagePanel.Controls.Add(_image);
        }

    }
}
