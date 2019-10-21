using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.PropertiesDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp.learn.UnitTests.learnTests
{
    [TestClass]
    public class PropertiesTests
    {
        [TestMethod]
        public void TimePeriod_Should_have_correct_Value() {

            TimePeriod timePeriod = new TimePeriod();
            timePeriod.Hours = 24;

            Assert.AreEqual(24, timePeriod.Hours);
        }
    }
}
