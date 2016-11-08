using PostPOC.App.Common;
using System.Windows.Controls;

namespace PostPOC.App.Pattern
{
    /// <summary>
    /// Class JasonLayout.
    /// </summary>
    /// <seealso cref="PostPOC.App.Pattern.ILayout" />
    public class JasonLayout : ILayout
    {
        /// <summary>
        /// Gets the layout.
        /// </summary>
        /// <param name="Item">The item.</param>
        public void GetLayout(object Item)
        {
            if (Item != null && Item is DataGrid)
            {
                var DataGrid = Item as DataGrid;
                DataGrid.SelectedIndex = 0;
                Helper.SetClipboard(Helper.JasonConverter(DataGrid.SelectedItem));
            }
        }
    }
}
