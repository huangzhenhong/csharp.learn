using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp.learn.automapper.ConfigurationValidation;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    public class ConfigurationValidationTests
    {
        [TestMethod]
        [ExpectedException(typeof(AutoMapperConfigurationException))]
        public void ConfigurationValidation_IsValid()
        {

            var configuration = new MapperConfiguration(
                    cfg => cfg.CreateMap<Source, Destination>());

            configuration.AssertConfigurationIsValid();

        }
    }
}
