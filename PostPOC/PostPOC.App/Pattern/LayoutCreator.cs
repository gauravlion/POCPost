using PostPOC.App.Common;

namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Class LayoutCreator.
    /// </summary>
    public class LayoutCreator : ILayoutCreator
    {
        /// <summary>
        /// Creates the layout.
        /// </summary>
        /// <param name="layout">The layout.</param>
        /// <returns>ILayout.</returns>
        public ILayout CreateLayout(string layout)
        {
            if (layout == Constants.Html)
            {
                return new HtmlLayout();
            }
            else if (layout == Constants.Jason)
            {
                return new JasonLayout();
            }
            return new TextLayout();
        }

    }
}
