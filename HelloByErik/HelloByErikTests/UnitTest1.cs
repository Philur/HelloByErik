using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloByErik;

namespace HelloByErikTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Goodbye World", Program.CreateMessageGoodBye());
        }
    }


    [TestClass]
    public class UnitTest4
    {
            [TestMethod]
            public void TestMethod4()
            {
                Assert.AreNotEqual("Goodbye World!!", Program.CreateMessageGoodBye());
            }
        }
}
