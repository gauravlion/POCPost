using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using PostPOC.App.Pattern;
using System.Windows.Controls;
using PostPOC.Model;
using PostPOC.App.Common;

namespace PostPOC.UnitTest
{
    /// <summary>
    /// Summary description for LayoutUnitTest
    /// </summary>
    [TestClass]
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]

    public class LayoutUnitTest
    {
        /// <summary>
        /// The layout creator
        /// </summary>
        LayoutCreator _layoutCreator = null;
        /// <summary>
        /// The i layout
        /// </summary>
        ILayout _iLayout = null;


        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _layoutCreator = new LayoutCreator();
        }



        /// <summary>
        /// Layouts the creator for text.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void layoutCreatorForText()
        {
            _iLayout = _layoutCreator.CreateLayout(Constants.Text);
            var dataGrid = new DataGrid();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            dataGrid.ItemsSource = new List<Post>() {
                new Post() { id = 1, body="body", title="title" , userId = 1 },
                new Post() { id = 1, body="body", title="title" , userId = 2 }
            };

            _iLayout.GetLayout(dataGrid);

            Assert.IsTrue(dataGrid.SelectedIndex == 0);
        }

        /// <summary>
        /// Layouts the creator for HTML.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void layoutCreatorForHtml()
        {
            LayoutCreator layoutCreator = new LayoutCreator();
            ILayout iLayout = layoutCreator.CreateLayout(Constants.Html);
            var dataGrid = new DataGrid();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            dataGrid.ItemsSource = new List<Post>() {
                new Post() { id = 1, body="body", title="title" , userId = 1 },
                new Post() { id = 1, body="body", title="title" , userId = 2 }
            };

            iLayout.GetLayout(dataGrid);

            Assert.IsTrue(dataGrid.SelectedIndex == 0);
        }

        /// <summary>
        /// Layouts the creator for jason.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void layoutCreatorForJason()
        {
            LayoutCreator layoutCreator = new LayoutCreator();
            ILayout iLayout = layoutCreator.CreateLayout(Constants.Jason);
            var dataGrid = new DataGrid();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            dataGrid.ItemsSource = new List<Post>() {
                new Post() { id = 1, body="body", title="title" , userId = 1 },
                new Post() { id = 1, body="body", title="title" , userId = 2 }
            };

            iLayout.GetLayout(dataGrid);

            Assert.IsTrue(dataGrid.SelectedIndex == 0);
        }

        /// <summary>
        /// Layouts the creator for null jason.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void layoutCreatorForNullJason()
        {
            LayoutCreator layoutCreator = new LayoutCreator();
            ILayout iLayout = layoutCreator.CreateLayout(Constants.Jason);
            var dataGrid = new DataGrid();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            //dataGrid.ItemsSource = new List<Post>() {
            //    new Post() { id = 1, body="body", title="title" , userId = 1 },
            //    new Post() { id = 1, body="body", title="title" , userId = 2 }
            //};

            iLayout.GetLayout(dataGrid);
        }

        /// <summary>
        /// Layouts the creator for default.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void layoutCreatorForDefault()
        {
            LayoutCreator layoutCreator = new LayoutCreator();
            ILayout iLayout = layoutCreator.CreateLayout("Default");
            var dataGrid = new DataGrid();
            dataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.ExcludeHeader;
            dataGrid.ItemsSource = new List<Post>() {
                new Post() { id = 1, body="body", title="title" , userId = 1 },
                new Post() { id = 1, body="body", title="title" , userId = 2 }
            };

            iLayout.GetLayout(dataGrid);

            Assert.IsTrue(dataGrid.SelectedIndex == 0);
        }

        /// <summary>
        /// Tests the tear down.
        /// </summary>
        [TestCleanup]
        public void TestTearDown()
        {

            if (_layoutCreator != null)
                _layoutCreator = null;
            if (_iLayout != null)
                _iLayout = null;
        }
    }
}
