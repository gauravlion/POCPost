using PostPOC.App.ViewModel;
using PostPOC.Model;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace PostPOC.App
{
    /// <summary>
    /// Interaction logic for PostDetailView.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [ExcludeFromCodeCoverage]
    public partial class PostDetailView : Window
    {
        /// <summary>
        /// Gets or sets the i post view model.
        /// </summary>
        /// <value>The i post view model.</value>
        public IPostViewModel _iPostViewModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDetailView"/> class.
        /// </summary>
        /// <param name="selectedPost">The selected post.</param>
        /// <param name="iPostViewModel">The i post view model.</param>
        public PostDetailView(Post selectedPost, IPostViewModel iPostViewModel)
        {
            InitializeComponent();
            _iPostViewModel = iPostViewModel;
            this.MainDataGrid.DataContext = _iPostViewModel;
            this.MainDataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
        }

        /// <summary>
        /// Handles the Click event of the button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Converts the text.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ConvertText(object sender, RoutedEventArgs e)
        {
            _iPostViewModel.CopyToClip(Convert.ToString((sender as Button).Tag), this.MainDataGrid);
        }
    }
}
