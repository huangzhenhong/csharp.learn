using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.automapper.ListAndArray;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class ListAndArrayTests
    {
        [TestMethod]
        public void ListAndArray_Map_Test()
        {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var sources = new[]
                {
                    new Source { Value = 5 },
                    new Source { Value = 6 },
                    new Source { Value = 7 }
                };

            IList<Destination> destinationIList
                = mapper.Map<Source[], IList<Destination>>(sources);
            IEnumerable<Destination> destinationEnums
                = mapper.Map<Source[], IEnumerable<Destination>>(sources);
            ICollection<Destination> destinationCollections
                            = mapper.Map<Source[], ICollection<Destination>>(sources);
            List<Destination> destinationList
                            = mapper.Map<Source[], List<Destination>>(sources);


            Assert.AreEqual(3, destinationList.Count);
            Assert.AreEqual(3, destinationIList.Count);
            Assert.AreEqual(3, destinationCollections.Count);
        }

        [TestMethod]
        public void ListAndArray_Polymorphic_Map_Test()
        {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var sources = new[]
            {
                new ParentSource(),
                new ChildSource(),
                new ParentSource()
            };

            var destinations = mapper.Map<ParentSource[],
                ParentDestination[]>(sources);

            Assert.IsInstanceOfType(destinations[0], typeof(ParentDestination));
            Assert.IsInstanceOfType(destinations[1], typeof(ChildDestination));
            Assert.IsInstanceOfType(destinations[2], typeof(ParentDestination));
        }
    }
}
