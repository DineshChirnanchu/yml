using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample_UTP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(2 == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 6 - 3 );
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(6, 4 + 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(12, 6 * 2);
        }
    }
}
