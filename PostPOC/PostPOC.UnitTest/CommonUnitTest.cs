using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostPOC.Common;
using PostPOC.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostPOC.UnitTest
{
    /// <summary>
    /// Class CommonUnitTest.
    /// </summary>
    [TestClass]
    [SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]

    public class CommonUnitTest
    {
        /// <summary>
        /// The i logger
        /// </summary>
        private ILogger _ILogger;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _ILogger = new FileLogger();

        }



        /// <summary>
        /// Writes the information.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void WriteInformation()
        {
            _ILogger.WriteInformation("this is a test");
        }


        /// <summary>
        /// Writes the verbose.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void WriteVerbose()
        {
            _ILogger.WriteVerbose("this is a test");
        }

        /// <summary>
        /// Writes the information string empty.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void WriteInformationStringEmpty()
        {
            _ILogger.WriteInformation(string.Empty);
        }


        /// <summary>
        /// Writes the verbose string empty.
        /// </summary>
        [TestMethod]
        [TestCategory("Unit Test Case")]
        public void WriteVerboseStringEmpty()
        {
            _ILogger.WriteVerbose(string.Empty);
        }



        /// <summary>
        /// Tests the tear down.
        /// </summary>
        [TestCleanup]
        public void TestTearDown()
        {
            if (_ILogger != null)
                _ILogger = null;
        }
    }
}
