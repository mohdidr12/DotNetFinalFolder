
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UniTtestingMvc.Controllers;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForViewName1()
        {
            CustomController c = new CustomController();
            ViewResult v = c.Index(0) as ViewResult;
            
        }
    }
}
