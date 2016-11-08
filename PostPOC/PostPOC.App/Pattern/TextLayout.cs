using System.Windows;

namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Class TextLayout.
    /// </summary>
    /// <seealso cref="PostPOC.App.Pattern.BaseLayout" />
    class TextLayout : BaseLayout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayout"/> class.
        /// </summary>
        public TextLayout()
        {
            textDataFormat = TextDataFormat.Text;
        }
    }
}
