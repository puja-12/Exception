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
    public class HappySadmoodTests
    {
      
            [TestMethod()]
            public void TestMethod1()
            {
                HappySadmood analyser = new HappySadmood();
                string expected = analyser.Analyse("I am in Sad mood");
                Assert.AreEqual("SAD", expected);
            }
            [TestMethod()]
            public void TestMethod2()
            {
                HappySadmood analyser = new HappySadmood();
                string expected = analyser.Analyse("I am in Any mood");
                Assert.AreEqual("HAPPY", expected);
            }
        }
    }
