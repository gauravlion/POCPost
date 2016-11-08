using PostPOC.Model;
using System.Collections.Generic;

namespace PostPOC.App.ViewModel
{
    /// <summary>
    /// Interface IPostViewModel
    /// </summary>
    public interface IPostViewModel
    {
        /// <summary>
        /// Gets or sets the selected post.
        /// </summary>
        /// <value>The selected post.</value>
        List<Post> SelectedPost { get; set; }
        /// <summary>
        /// Copies to clip.
        /// </summary>
        /// <param name="layout">The layout.</param>
        /// <param name="Item">The item.</param>
        void CopyToClip(string layout, object Item);
    }
}
