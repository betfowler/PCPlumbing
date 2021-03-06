// <copyright file="AdminsControllerTest.cs">Copyright ©  2017</copyright>
using System;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCPlumbing.Controllers;

namespace PCPlumbing.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for AdminsController</summary>
    [PexClass(typeof(AdminsController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AdminsControllerTest
    {
        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]AdminsController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method AdminsControllerTest.IndexTest(AdminsController)
        }
    }
}
