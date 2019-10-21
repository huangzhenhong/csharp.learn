using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.Abstract;

namespace csharp.learn.UnitTests.learnTests
{
    [TestClass]
    public class AbstractTests
    {
        [TestMethod]
        public void VinNumberEqual_should_return_true() {

            Car car1 = new Car("VIN12345", 2, 4);
            Car car2 = new Car("VIN12345", 2, 4);

            var result = car1.VinNumberEqual(car2);

            Assert.IsTrue(result);
        }
    }
}
