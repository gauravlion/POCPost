using PostPOC.App.Common;
using System.Windows;
using System.Windows.Controls;

namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Class BaseLayout.
    /// </summary>
    /// <seealso cref="PostPOC.App.Pattern.ILayout" />
    public abstract class BaseLayout : ILayout
    {
        /// <summary>
        /// The text data format
        /// </summary>
        internal TextDataFormat textDataFormat = TextDataFormat.UnicodeText;
        /// <summary>
        /// Gets the layout.
        /// </summary>
        /// <param name="Item">The item.</param>
        public void GetLayout(object Item)
        {
            if (Item != null && Item is DataGrid)
            {
                var DataGrid = Item as System.Windows.Controls.DataGrid;
                DataGrid.SelectedIndex = 0;
                Helper.CopyCommand(DataGrid);
                Helper.SetClipboard(Helper.Converter(textDataFormat));
            }
        }

    }
}
