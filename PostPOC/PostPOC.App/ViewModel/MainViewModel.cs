using Microsoft.Practices.Unity;
using PostPOC.App.Common;
using PostPOC.Common;
using PostPOC.DAL;
using PostPOC.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace PostPOC.App.ViewModel
{
    /// <summary>
    /// Class MainViewModel.
    /// </summary>
    /// <seealso cref="PostPOC.App.ViewModel.IMainViewModel" />
    public class MainViewModel : IMainViewModel
    {
        /// <summary>
        /// The post dal
        /// </summary>
        IPostDAL _postDAL;
        /// <summary>
        /// The i logger
        /// </summary>
        ILogger _iLogger = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        /// <param name="iPostDAL">The i post dal.</param>
        /// <param name="iLogger">The i logger.</param>
        public MainViewModel(IPostDAL iPostDAL, ILogger iLogger)
        {
            _postDAL = iPostDAL;
            _iLogger = iLogger;
        }

        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <value>The posts.</value>
        public List<Post> Posts
        {
            get
            {
                try
                {
                    return _postDAL.QueryDetail<List<Post>>(Helper.GetURL(new RequestObject() { URL = Constants.Posts }));
                }
                catch (Exception ex)
                {
                    CaptureError(ex);
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets or sets the selected post.
        /// </summary>
        /// <value>The selected post.</value>
        public Post SelectedPost
        {
            get;
            set;
        }

        /// <summary>
        /// Shows the detailed view.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public void ShowDetailedView()
        {
            try
            {
                var PostDetailView = ((PostPOC.App.App)App.Current).container.Resolve<PostDetailView>();
                PostDetailView._iPostViewModel.SelectedPost.Add(SelectedPost);
                PostDetailView.ShowDialog();
            }
            catch (Exception ex)
            {
                CaptureError(ex);
            }
        }

        /// <summary>
        /// Captures the error.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ExcludeFromCodeCoverage]
        private void CaptureError(Exception ex)
        {
            _iLogger.WriteInformation(ex.InnerException.Message);
            MessageBox.Show(ex.Message);
        }

    }
}
