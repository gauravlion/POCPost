using PostPOC.App.Pattern;
using PostPOC.Common;
using PostPOC.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace PostPOC.App.ViewModel
{
    /// <summary>
    /// Class PostViewModel.
    /// </summary>
    /// <seealso cref="PostPOC.App.ViewModel.IPostViewModel" />
    public class PostViewModel : IPostViewModel
    {
        /// <summary>
        /// The i logger
        /// </summary>
        ILogger _iLogger = null;

        /// <summary>
        /// The i layout creator
        /// </summary>
        ILayoutCreator _iLayoutCreator = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostViewModel" /> class.
        /// </summary>
        /// <param name="iLogger">The i logger.</param>
        /// <param name="iLayoutCreator">The i layout creator.</param>
        public PostViewModel(ILogger iLogger, ILayoutCreator iLayoutCreator)
        {
            _iLogger = iLogger;
            _iLayoutCreator = iLayoutCreator;
        }

        /// <summary>
        /// Gets or sets the selected post.
        /// </summary>
        /// <value>The selected post.</value>
        public List<Post> SelectedPost
        {
            get;
            set;

        } = new List<Post>();

        /// <summary>
        /// Captures the error.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ExcludeFromCodeCoverage]
        public void CaptureError(Exception ex)
        {
            _iLogger.WriteInformation(ex.InnerException.Message);
            MessageBox.Show(ex.Message);
        }

        /// <summary>
        /// Copies to clip.
        /// </summary>
        /// <param name="layout">The layout.</param>
        /// <param name="Item">The item.</param>
        public void CopyToClip(string layout, object Item)
        {
            try
            {
                ILayout iLayout = _iLayoutCreator.CreateLayout(layout);
                iLayout.GetLayout(Item);
            }
            catch (Exception ex)
            {
                CaptureError(ex);
            }
        }

    }
}
