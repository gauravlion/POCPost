using PostPOC.App.ViewModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace PostPOC.App
{
    /// <summary>
    /// Class MainWindow.
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    [ExcludeFromCodeCoverage]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The main view model
        /// </summary>
        IMainViewModel _iMainViewModel = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        /// <param name="iMainViewModel">The i main view model.</param>
        public MainWindow(IMainViewModel iMainViewModel)
        {
            _iMainViewModel = iMainViewModel;
            InitializeComponent();
            this.MainDataGrid.DataContext = _iMainViewModel;
            this.MainDataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
        }

        /// <summary>
        /// Handles the Selected event of the MainDataGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Controls.SelectedCellsChangedEventArgs"/> instance containing the event data.</param>
        private void MainDataGrid_Selected(object sender, System.Windows.Controls.SelectedCellsChangedEventArgs e)
        {
            _iMainViewModel.ShowDetailedView();
        }
    }
}
