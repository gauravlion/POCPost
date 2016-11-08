using System.Windows;

namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Class HtmlLayout.
    /// </summary>
    /// <seealso cref="PostPOC.App.Pattern.BaseLayout" />
    public class HtmlLayout : BaseLayout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlLayout"/> class.
        /// </summary>
        public HtmlLayout()
        {
            textDataFormat = TextDataFormat.Html;
        }

    }
}
