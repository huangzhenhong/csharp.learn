using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.automapper.CustomTypeConverter;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    class CustomTypeConverterTests
    {
        [TestMethod]
        public void CustomTypeConverter_Mapper()
        {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            configuration.AssertConfigurationIsValid();

            var source = new Source
            {
                Value1 = "5",
                Value2 = "01/01/2000",
                Value3 = "csharp.learn.Destination"
            };

            var dest = mapper.Map<Source, Destination>(source);

            Assert.AreEqual(5, dest.Value1);
            Assert.AreEqual(new DateTime(2000, 1, 1), dest.Value2);
            Assert.AreEqual(typeof(Destination), dest.Value3);
        }
    }
}
