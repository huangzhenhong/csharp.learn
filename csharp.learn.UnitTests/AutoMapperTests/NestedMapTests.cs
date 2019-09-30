using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.automapper.Nested;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class NestedMapTests
    {
        [TestMethod]
        public void Nested_Map_Test()
        {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            configuration.AssertConfigurationIsValid();

            var source = new OuterSource
            {
                Value = 5,
                Inner = new InnerSource { OtherValue = 15 }
            };

            var dest = mapper.Map<OuterSource, OuterDest>(source);

            Assert.AreEqual(5, dest.Value);
            Assert.IsNotNull(dest.Inner);
            Assert.AreEqual(15, dest.Inner.OtherValue);
        }
    }
}
