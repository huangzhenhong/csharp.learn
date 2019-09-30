using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp.learn.automapper.IncludeMembers;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class IncludeMembersTests
    {
        [TestMethod]
        public void IncludeMembers_Should_Flatten()
        {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var source = new Source
            {
                Name = "name",
                InnerSource = new InnerSource
                {
                    Description = "description",
                    Name = "inner name"
                },
                OtherInnerSource = new OtherInnerSource
                {
                    Title = "title",
                    Name = "other inner name",
                    Description = "other inner description"
                }
            };

            var destination = mapper.Map<Destination>(source);

            Assert.AreEqual("name", destination.Name);
            Assert.AreEqual("description", destination.Description);
            Assert.AreEqual("title", destination.Title);
        }
    }
}
