using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn;

namespace csharp.learn.UnitTests.learnTests
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void GetGuitarType_should_Return_Tuple() {

            TupleExample tupleExample = new TupleExample();
            var (item1, item2) = tupleExample.GetGuitarType();

            Assert.AreEqual("Stairway to Heaven", item1);
            Assert.AreEqual(1, item2);
        }

        [TestMethod]
        public void GetGuitarTypeWithSuggestedName_should_Return_Tuple()
        {

            TupleExample tupleExample = new TupleExample();
            var guitar = tupleExample.GetGuitarTypeWithSuggestedName();

            Assert.AreEqual("Les Paul Studio", guitar.GuitarType);
            Assert.AreEqual(6, guitar.StringCount);
        }

        [TestMethod]
        public void GetGuitarTypeWithSuggestedName_With_Changed_Name()
        {

            TupleExample tupleExample = new TupleExample();
            (string GuitarTypeChanged, int StringCountChanged) guitar = tupleExample.GetGuitarTypeWithSuggestedName();

            Assert.AreEqual("Les Paul Studio", guitar.GuitarTypeChanged);
            Assert.AreEqual(6, guitar.StringCountChanged);
        }

        [TestMethod]
        public void GetGuitarTypeWithSuggestedName_Deconstruction()
        {

            TupleExample tupleExample = new TupleExample();
            (string GuitarType, int StringCount) = tupleExample.GetGuitarTypeWithSuggestedName();

            Assert.AreEqual("Les Paul Studio", GuitarType);
            Assert.AreEqual(6, StringCount);
        }

        [TestMethod]
        public void PlayInstrument_Tuple_As_Parameter()
        {
            (string GuitarType, int StringCount) instrument = ("violin", 2);
            TupleExample tupleExample = new TupleExample();
            var result = tupleExample.PlayInstrument(instrument);

            Assert.AreEqual("violin",result.Item1);
            Assert.AreEqual(2, result.Item2);
        }
    }
}
