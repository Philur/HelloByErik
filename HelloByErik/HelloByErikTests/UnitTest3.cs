using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloByErik;

namespace HelloByErikTests
{
    [TestClass]
    public class CreateMessageTests
    {
        [TestMethod]
        public void CreateMessageTest()
        {
            //HACK This really needs to be improved
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    
        [TestMethod]
        public void CreateMessageTestFail()
        {
            Assert.AreNotEqual("Hello World!!", Program.CreateMessage());
        }
    
        [TestMethod]
        public void CreateMessageGoodByeTest()
        {
            Assert.AreEqual("Goodbye World", Program.CreateMessageGoodBye());
        }
    
        [TestMethod]
        public void CreateMessageGoodByeTestFail()
        {
            Assert.AreNotEqual("Goodbye World!!", Program.CreateMessageGoodBye());
        }
    }
}
