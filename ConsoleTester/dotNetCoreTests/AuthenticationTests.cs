using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetCoreTests
{
    [TestClass]
    public class AuthenticationTests
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethodFailing()
        {
            Assert.IsTrue(false);
        }
    }
}
