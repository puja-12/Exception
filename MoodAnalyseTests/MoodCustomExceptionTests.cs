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
    public class MoodAnalysisExceptionTests
    {
        [TestMethod()]
        public void MMoodAnalysisExceptionMethodTest()
        {
            try
            {
                string message = "";
                MoodAnalysisException moodAnalysisException = new MoodAnalysisException();
            }
            catch (MoodCustomException ex)
            {

                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }



        [TestMethod()]
        public void MMoodAnalysisExceptionMethodTest1()
        {
            try
            {
                string message = null;
                MoodAnalysisException moodAnalysisException = new MoodAnalysisException();
            }
            catch (MoodCustomException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
    }

}