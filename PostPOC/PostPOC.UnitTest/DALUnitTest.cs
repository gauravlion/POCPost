using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using PostPOC.DAL;
using PostPOC.Model;
using System.Collections.Generic;
using PostPOC.Common;
using PostPOC.DAL.Fakes;
using System.Configuration;
using PostPOC.App.Common;

namespace PostPOC.UnitTest
{
    /// <summary>
    /// Class DALUnitTest.
    /// </summary>
    [TestClass]
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class DALUnitTest
    {
        /// <summary>
        /// The i post dal
        /// </summary>
        private IPostDAL _iPostDAL;
        /// <summary>
        /// The i logger
        /// </summary>
        private ILogger _iLogger;
        /// <summary>
        /// The i client
        /// </summary>
        private IClient _iClient;
        /// <summary>
        /// The stub i client
        /// </summary>
        private StubIClient _stubIClient;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _iLogger = new FileLogger();
            _iClient = new WebClient();
            _iPostDAL = new PostDAL(_iLogger, _iClient);
            _stubIClient = new StubIClient();

        }

        /// <summary>
        /// Queries the post i d1.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryPostID1()
        {
            var result = _iPostDAL.QueryDetail<Post>(Helper.GetURL(new RequestObject() { id = 1, URL = Constants.Posts }));

            ////Assert
            Assert.IsTrue(result != null && result.id == 1);
        }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void GetURL()
        {
            ////Assert
            Assert.IsTrue(Helper.GetURL(new RequestObject() { id = 1, URL = Constants.Posts }) == string.Format("{0}{1}", ConfigurationManager.AppSettings[Constants.JsonURL], "/posts/1"));
        }

        /// <summary>
        /// Gets the only URL.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void GetOnlyURL()
        {
            ////Assert
            Assert.IsTrue(Helper.GetURL(new RequestObject() { URL = Constants.Posts }) == string.Format("{0}{1}", ConfigurationManager.AppSettings[Constants.JsonURL], "/posts"));
        }

        /// <summary>
        /// Gets the empty URL.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void GetEmptyURL()
        {
            ////Assert
            Assert.IsTrue(Helper.GetURL(new RequestObject() { URL = string.Empty }) == ConfigurationManager.AppSettings[Constants.JsonURL]);
        }

        /// <summary>
        /// Gets the blank URL.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void GetBlankURL()
        {
            ////Assert
            Assert.IsTrue(Helper.GetURL(new RequestObject()) == ConfigurationManager.AppSettings[Constants.JsonURL]);
        }

        /// <summary>
        /// Queries the post i d1 title body attributes are filled.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryPostID1TitleBodyAttributesAreFilled()
        {
            var result = _iPostDAL.QueryDetail<Post>(Helper.GetURL(new RequestObject() { id = 1, URL = Constants.Posts }));
            //Assert
            Assert.IsTrue(result != null && result.id == 1);
            Assert.IsTrue(result != null && !string.IsNullOrEmpty(result.title) && !string.IsNullOrEmpty(result.body) && result.userId > 0);

        }

        /// <summary>
        /// Queries the post i D12.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryPostID12()
        {
            var result = _iPostDAL.QueryDetail<Post>(Helper.GetURL(new RequestObject() { id = 12, URL = Constants.Posts }));
            //Assert
            Assert.IsTrue(result != null && result.id == 12);

        }

        /// <summary>
        /// Queries all posts.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryAllPosts()
        {
            var result = _iPostDAL.QueryDetail<List<Post>>(Helper.GetURL(new RequestObject() { URL = Constants.Posts }));
            //Assert
            Assert.IsTrue(result != null && result.Count > 1);

        }

        /// <summary>
        /// Queries the user i d1.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryUserID1()
        {
            var result = _iPostDAL.QueryDetail<User>(Helper.GetURL(new RequestObject() { id = 1, URL = Constants.Users }));
            //Assert
            Assert.IsTrue(result != null && result.id == 1);

        }

        /// <summary>
        /// Queries the user i d1 with all attributes are filled.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryUserID1WithAllAttributesAreFilled()
        {
            var result = _iPostDAL.QueryDetail<User>(Helper.GetURL(new RequestObject() { id = 1, URL = Constants.Users }));
            //Assert
            Assert.IsTrue(result != null && result.id == 1);
            Assert.IsTrue(result != null && result.address != null && !string.IsNullOrEmpty(result.email) && !string.IsNullOrEmpty(result.name) && !string.IsNullOrEmpty(result.phone) && !string.IsNullOrEmpty(result.username) && !string.IsNullOrEmpty(result.website));
            Assert.IsTrue(!string.IsNullOrEmpty(result.address.city) && !string.IsNullOrEmpty(result.address.street) && !string.IsNullOrEmpty(result.address.suite) && !string.IsNullOrEmpty(result.address.zipcode));
            Assert.IsTrue(result.address.geo != null && !string.IsNullOrEmpty(Convert.ToString(result.address.geo.lat)) && !string.IsNullOrEmpty(Convert.ToString(result.address.geo.lng)));
            Assert.IsTrue(result.company != null && !string.IsNullOrEmpty(result.company.catchPhrase) && !string.IsNullOrEmpty(result.company.bs) && !string.IsNullOrEmpty(result.company.name));
        }

        /// <summary>
        /// Queries the user i d9.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryUserID9()
        {
            var result = _iPostDAL.QueryDetail<User>(Helper.GetURL(new RequestObject() { id = 9, URL = Constants.Users }));
            //Assert
            Assert.IsTrue(result != null && result.id == 9);

        }

        /// <summary>
        /// Queries all users.
        /// </summary>
        [TestMethod]
        [TestCategory("Functional Test Case")]
        public void QueryAllUsers()
        {
            var result = _iPostDAL.QueryDetail<List<User>>(Helper.GetURL(new RequestObject() { URL = Constants.Users }));
            //Assert
            Assert.IsTrue(result != null && result.Count > 1);

        }

        /// <summary>
        /// Creates the client instance.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void CreateClientInstance()
        {
            var Client = _iClient.GetClient();

            Assert.IsTrue(Client != null && Client.Timeout == new TimeSpan(1800000000));
        }


        /// <summary>
        /// Queries all posts on get string exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [TestCategory("Unit Test Case")]
        public void QueryAllPostsOnGetStringException()
        {
            _iPostDAL = new PostDAL(_iLogger, _stubIClient);

            _stubIClient.GetResponseHttpClientString = (arg1, arg2) =>
            {
                throw new Exception();
            };
            _iPostDAL.QueryDetail<Post>(Helper.GetURL(new RequestObject() { URL = "" }));
        }

        /// <summary>
        /// Queries all posts on get string is null.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void QueryAllPostsOnGetStringIsNull()
        {
            try
            {
                _iPostDAL = new PostDAL(_iLogger, _stubIClient);

                _stubIClient.GetResponseHttpClientString = (arg1, arg2) =>
                {
                    return "...";
                };
                _iPostDAL.QueryDetail<Post>(Helper.GetURL(new RequestObject() { URL = "" }));
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "Input string '...' is not a valid number. Path '', line 1, position 3.");
            }

        }

        /// <summary>
        /// Tests the tear down.
        /// </summary>
        [TestCleanup]
        public void TestTearDown()
        {
            if (_iPostDAL != null)
                _iPostDAL = null;
            if (_iClient != null)
                _iClient = null;

        }

    }
}
