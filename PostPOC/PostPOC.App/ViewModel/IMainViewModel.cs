using PostPOC.Model;
using System.Collections.Generic;

namespace PostPOC.App.ViewModel
{
    /// <summary>
    /// Interface IMainViewModel
    /// </summary>
    public interface IMainViewModel
    {
        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <value>The posts.</value>
        List<Post> Posts { get; }
        /// <summary>
        /// Gets or sets the selected post.
        /// </summary>
        /// <value>The selected post.</value>
        Post SelectedPost { get; set; }

        /// <summary>
        /// Shows the detailed view.
        /// </summary>
        void ShowDetailedView();
    }
}
