using Microsoft.Practices.Unity;
using PostPOC.App.Pattern;
using PostPOC.App.ViewModel;
using PostPOC.Common;
using PostPOC.DAL;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
namespace PostPOC.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Application" />
    /// <seealso cref="System.IDisposable" />
    [ExcludeFromCodeCoverage]
    public partial class App : Application, IDisposable
    {
        /// <summary>
        /// The container
        /// </summary>
        public UnityContainer container = new UnityContainer();

        /// <summary>
        /// Finalizes an instance of the <see cref="App"/> class.
        /// </summary>
        ~App()
        {
            Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            container.RegisterType<IMainViewModel, MainViewModel>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPostDAL, PostDAL>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILogger, FileLogger>(new ContainerControlledLifetimeManager());
            container.RegisterType<IClient, WebClient>(new ContainerControlledLifetimeManager());
            container.RegisterType<IPostViewModel, PostViewModel>();
            container.RegisterType<ILayoutCreator, LayoutCreator>();

            var window = container.Resolve<MainWindow>();
            window.Show();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {

            // If disposing equals true, dispose all managed and unmanaged resources.
            if (disposing)
            {
                // Dispose managed resources.
                if (container != null)
                    container.Dispose();
                container = null;
            }
        }

    }
}
