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
    public class MoodAnalyzerExceptionTests
    {
        [TestMethod()]
        public void ExceptionMethodTest()
        {      
         
                MoodAnalyzerException A4 = new();
                string mood = A4.ExceptionMethod(null);
                Assert.AreEqual("Happy", mood);
            }
    }
}