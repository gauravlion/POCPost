using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using PostPOC.App.Pattern;
using System.Windows.Controls;
using PostPOC.Model;
using PostPOC.App.Common;
using PostPOC.App.ViewModel;
using PostPOC.DAL;
using PostPOC.Common;
using PostPOC.DAL.Fakes;
using PostPOC.Common.Fakes;
using PostPOC.App.Pattern.Fakes;

namespace PostPOC.UnitTest
{
    /// <summary>
    /// Summary description for LayoutUnitTest
    /// </summary>
    [TestClass]
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]

    public class ModelViewUnitTest
    {
        /// <summary>
        /// The i main view model
        /// </summary>
        IMainViewModel _iMainViewModel = null;
        /// <summary>
        /// The post dal
        /// </summary>
        StubIPostDAL _postDAL = null;
        /// <summary>
        /// The i logger
        /// </summary>
        StubILogger _iLogger = null;

        /// <summary>
        /// The i post view model
        /// </summary>
        IPostViewModel _iPostViewModel = null;

        /// <summary>
        /// The i layout creator
        /// </summary>
        ILayoutCreator _iLayoutCreator = null;


        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _iLogger = new StubILogger();
            _postDAL = new StubIPostDAL();
            _iMainViewModel = new MainViewModel(_postDAL, _iLogger);
            _iLayoutCreator = new LayoutCreator();
            _iPostViewModel = new PostViewModel(_iLogger, _iLayoutCreator);
        }

        /// <summary>
        /// Lists the selected post is nullfor post view.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void listSelectedPostIsNullforPostView()
        {
            List<Post> post = _iPostViewModel.SelectedPost;
            Assert.IsTrue(post != null);
        }

        /// <summary>
        /// Lists the selected post.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void listSelectedPost()
        {
            List<Post> post = _iPostViewModel.SelectedPost = new List<Post>() { new Post() { id = 1 } };
            Assert.IsTrue(post != null && post.Count == 1);

        }

        /// <summary>
        /// Copies to clip with null.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void CopyToClipWithNull()
        {
            _iPostViewModel.CopyToClip(Constants.Text, null);
        }

        /// <summary>
        /// Copies to clip with data grid.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void CopyToClipWithDataGrid()
        {
            _iPostViewModel.CopyToClip(Constants.Text, new DataGrid());
        }

        /// <summary>
        /// Lists the selected post is null.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void listSelectedPostIsNull()
        {
            Post post = _iMainViewModel.SelectedPost;
            Assert.IsTrue(post == null);
        }


        /// <summary>
        /// Lists the post is null.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void listPostIsNull()
        {
            List<Post> listPost = _iMainViewModel.Posts;
            Assert.IsTrue(listPost == null);
        }


        /// <summary>
        /// Lists the post with exception.
        /// </summary>
        [TestCategory("Unit Test Case with popup")]
        [ExcludeFromCodeCoverage]
        public void listPostWithException()
        {
            _postDAL.QueryDetailOf1String<List<Post>>((a) => { throw new Exception("Custom error", new Exception("innerException")); });
            List<Post> listPost = _iMainViewModel.Posts;

            Assert.IsTrue(listPost == null);
        }

        /// <summary>
        /// Copies to clip.
        /// </summary>
        [TestCategory("Unit Test Case with popup")]
        [ExcludeFromCodeCoverage]
        public void CopyToClip()
        {
            StubILayoutCreator _iLayoutCreator = new StubILayoutCreator();
            _iPostViewModel = new PostViewModel(_iLogger, _iLayoutCreator);

            _iLayoutCreator.CreateLayoutString = (a) => { throw new Exception("Custom error", new Exception("innerException")); };

            _iPostViewModel.CopyToClip(Constants.Text, null);
        }




        /// <summary>
        /// Tests the tear down.
        /// </summary>
        [TestCleanup]
        public void TestTearDown()
        {

            if (_iMainViewModel != null)
                _iMainViewModel = null;
            if (_postDAL != null)
                _postDAL = null;
            if (_iLogger != null)
                _iLogger = null;
            if (_iPostViewModel != null)
                _iPostViewModel = null;
            if (_iLayoutCreator != null)
                _iLayoutCreator = null;
        }
    }
}
