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
using FunctionLibrary.EventArguments;
using FunctionLibrary.Interfaces;

namespace View
{
    public partial class CollectionView : Form, ICollectionListenerService
    {
        #region Declarations
        // DECLARE 5 ints for default image display properties.
        private int imageID, imageX, imageY, imageHeight, imageWidth;

        // DECLARE a ExecuteDelegate to store execute method
        private ExecuteDelegate _execute;

        // DECLARE an action to open the DisplayView
        private Action<string, Image> _openNewWindow;

        // DECLARE an action to load images from disk
        private Action<IList<string>, int, int> _load;
        #endregion

        public CollectionView() {/*Do nothing*/}

        /// <summary>
        /// Initialise all neseccary components of class before displaying the view
        /// </summary>
        /// <param name="pExecute"></param>
        /// <param name="pLoad"></param>
        /// <param name="pOpenNewWindow"></param>
        public void Init(ExecuteDelegate pExecute, Action<IList<string>, int, int> pLoad, Action<string, Image> pOpenNewWindow)
        {
            InitializeComponent();

            // ASSIGN delegate
            _execute = pExecute;

            // ASSIGN actions
            _load = pLoad;
            _openNewWindow = pOpenNewWindow;

            // ASSIGN values to default image display properties.
            imageID = imageX = 0;
            imageY = 70;
            imageHeight = imageWidth = 200;

            // ASSIGN max and min values to prevent resizing,
            // which breaks the program due to fixed scaling.
            MinimumSize = new Size(this.Width, this.Height);
            MaximumSize = new Size(this.Width, this.Height);
            this.imagePanel.AutoScroll = true;
        }

        /// <summary>
        /// Event listener for when load button is clicked
        /// Recycled code from Milestone01
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadImages_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Code Snippet: FileDialog access and check,
            /// Modified from https://stackoverflow.com/a/6123059 and attributed to user Cody Gray.
            /// 
            /// Code Snippet: FileDialog filter options,
            /// Modified from https://stackoverflow.com/a/12961589 and attributed to user itowlson
            /// </summary>
            OpenFileDialog fileExplorer = new OpenFileDialog
            {
                Title = "Select multiple images",
                Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp; *.gif|" + "All files (*.*)|*.*",
                Multiselect = true
            };

            if (fileExplorer.ShowDialog() == DialogResult.OK)
            {
                ICommand load = new Command<IList<string>, int, int>(_load, fileExplorer.FileNames.ToList(), imageWidth, imageHeight);
                _execute(load);
            }
        }

        /// <summary>
        /// Listener class for event from CollectionModel.
        /// Will update panel with new pictures boxes for each
        /// image loaded into memory
        /// Recycled code from Milestone01
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        void ICollectionListenerService.OnInput(object source, CollectionArgs e)
        {
            foreach (string id in e._imageCollection.Keys)
            {
                imageID++;
                PictureBox image = new PictureBox
                {
                    Image = e._imageCollection[id],
                    Size = new Size(imageWidth, imageHeight),
                    Location = new Point(imageX, imageY),
                    /// Set the name as ID
                    /// Ghetto way of passing the id
                    /// Messy, but it works!
                    Name = id
                };
                image.DoubleClick += new EventHandler(ImageClick);

                // Add new control to parent control collection.
                imagePanel.Controls.Add(image);

                // Change position for next image.
                if (imageID % 5 == 0)
                {
                    imageX = 0;
                    imageY += 225;
                }
                else
                {
                    imageX += 210;
                }
            }
        }

        /// <summary>
        /// Event method when an Image is clicked, passing reference to image ID
        /// and the image through an Action to DisplayView
        /// 
        /// Code Snippet: (Sender as x).property
        /// Modified from: https://forums.asp.net/t/343932.aspx?How+can+I+get+values+of+sender+object+in+C+
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageClick(object sender, EventArgs e)
        {
            ICommand displayViewPopup = new Command<string, Image>(_openNewWindow, (sender as PictureBox).Name, (sender as PictureBox).Image);
            _execute(displayViewPopup);
        }
    }               
}
