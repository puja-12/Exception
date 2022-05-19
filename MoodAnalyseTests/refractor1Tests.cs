using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse.Tests
{
    [TestClass()]
    public class refractor1Tests
    {
        [TestMethod()]
        public void refractor1Test()
        {
            refractor1 A1 = new refractor1();
            string expected = A1.Analyse();
            Assert.AreEqual("SAD", expected);

        }
        [TestMethod()]
        public void refractorTest2()
        {
            refractor1 A2 = new refractor1("I am in Happy mood");
            string expected = A2.Analyse();
            Assert.AreEqual("HAPPY", expected);


        }
    }
}