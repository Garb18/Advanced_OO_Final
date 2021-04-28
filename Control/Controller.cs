using System.Windows.Forms;
using View;
using FunctionLibrary.Interfaces;
using System.Drawing;
using FunctionLibrary.ImageFunctions;
using Model.Interfaces;
using Model.Models;

namespace Control
{
    /// <summary>
    /// Entrypoint for Views. Assigns correct model to views and passes through execute commands
    /// </summary>
    class Controller
    {
        #region Declerations
        // DECLARE an IModel
        private IModel _imgFunctions;

        // DECLARE an ICollectionModel
        private ICollectionModel _collectionModel;
        
        // DECLARE a CollectionView
        private CollectionView _collectionView;
        #endregion

        /// <summary>
        /// Constructor to load data to the collection view and start application
        /// </summary>
        public Controller()
        {
            LoadCollectionView();

            Application.Run(_collectionView);
        }

        #region Load the views
        /// <summary>
        /// Method called on application start to pass relevant data and assign model
        /// </summary>
        private void LoadCollectionView()
        {
            _collectionView = new CollectionView();

            _imgFunctions = new ImageFunctions();

            _collectionModel = new CollectionModel(_imgFunctions);

            _collectionView.Init(Execute, _collectionModel.Load, LoadDisplayView);

            (_collectionModel as ICollectionSubscriptionService).Subscribe((_collectionView as ICollectionListenerService).OnInput);
        }

        /// <summary>
        /// Method passed as an action to be called when an image is double clicked
        /// </summary>
        /// <param name="pId"></param>
        /// <param name="pImage"></param>
        private void LoadDisplayView(string pId, Image pImage)
        {
            DisplayView _displayView = new DisplayView();

            IDisplayModel _displayModel = new DisplayModel(_imgFunctions);

            (_displayModel as IDisplaySubscriptionService).Subscribe((_displayView as IDisplayListenerService).OnInput);

            _displayView.Init(Execute, pId, _displayModel.Load, _displayModel.Rotate, _displayModel.Flip, _displayModel.Resize, Save);

            _displayView.Show();
        }
        #endregion

        #region Command Execution
        /// <summary>
        /// Execute the passed command
        /// </summary>
        /// <param name="pCommand"></param>
        public void Execute(ICommand pCommand)
        {
            pCommand.Execute();
        }
        #endregion

        #region Filestream Image Saving Implementation
        /// <summary>
        /// Code Snippet: Method to save the newly edited Image to file
        /// Modified from: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
        /// 
        /// Would preffered to have put this in Model, but kept getting errors
        /// </summary>
        /// <param name="pImage"></param>
        private void Save(Image pImage)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Title = "Save your Image",
                Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp; *.gif|" + "All files (*.*)|*.*",
            };
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveDialog.OpenFile();
                switch (saveDialog.FilterIndex)
                {
                    case 1:
                        pImage.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        pImage.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pImage.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case 4:
                        pImage.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                fs.Close();
            }
        }
        #endregion

    }
}