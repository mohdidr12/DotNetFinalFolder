using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcApp;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalcAppClass cs = new CalcAppClass();
           int result =  cs.Add();
            Assert.AreEqual(14, result);

        }
    }
}
