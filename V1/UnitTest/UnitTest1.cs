using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using V1;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase01()
        {
            Sequence seq = new Sequence();
            string s = seq.fun1("6 1 5 9 2");
            //Assert.AreEqual(seq, "1 5 9");
            Assert.AreEqual(s, "null");
        }
    }
}
