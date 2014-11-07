using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloByErik;

namespace HelloByErikTests
{
    [TestClass]
    public class UnitTestA
    {
        [TestMethod]
        public void TestMethodA()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
    [TestClass]
    public class UnitTestB
    {
        [TestMethod]
        public void TestMethodB()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
    [TestClass]
    public class UnitTestC
    {
        [TestMethod]
        public void TestMethodC()
        {
            Assert.AreEqual("Goodbye World", Program.CreateMessageGoodBye());
        }
    }
    [TestClass]
    public class UnitTestD
    {
        [TestMethod]
        public void TestMethodD()
        {
            Assert.AreEqual("Goodbye World", Program.CreateMessageGoodBye());
        }
    }
}
