using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp.learn.automapper.Products;
using csharp.learn.automapper.IncludeMembers;
using csharp.learn.automapper.Projection;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace csharp.learn.UnitTests
{
    [TestClass]
    public class AutoMapperTests
    {
        [TestMethod]
        public void Products_Should_MapToOrderDto()
        {
            // Prepare
            var customer = new Customer
            {
                Name = "George Costanza"
            };
            var order = new Order
            {
                Customer = customer
            };
            var bosco = new Product
            {
                Name = "Bosco",
                Price = 4.99m
            };
            order.AddOrderLineItem(bosco, 15);

            // Configure AutoMapper
            // Option 1
            // var configuration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            // IMapper mapper = new Mapper(configuration);

            // Option 2
            //var configuration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            //var mapper = new Mapper(configuration);

            // Option 3 
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDto>());
            var mapper = new Mapper(configuration);
            
            // Perform mapping
            OrderDto dto = mapper.Map<Order, OrderDto>(order);

            // Assert
            Assert.AreEqual(dto.CustomerName, "George Costanza");
            Assert.AreEqual(dto.Total, 74.85m);

        }

        [TestMethod]
        public void IncludeMembers_Should_Flatten() {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.IncludeMembers.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var source = new Source
            {
                Name = "name",
                InnerSource = new InnerSource {
                    Description = "description",
                    Name = "inner name"
                },
                OtherInnerSource = new OtherInnerSource {
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

        [TestMethod]
        public void ReverseMapping_Test() {

            var customer = new automapper.ReverseMapping.Customer
            {
                Name = "Bob"
            };

            var order = new automapper.ReverseMapping.Order
            {
                Customer = customer,
                Total = 15.8m
            };

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.ReverseMapping.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var orderDto = mapper.Map<automapper.ReverseMapping.OrderDto>(order);

            orderDto.CustomerName = "Joe";

            mapper.Map(orderDto, order);

            Assert.AreEqual("Joe", order.Customer.Name);

        }

        [TestMethod]
        public void Projection_Test() {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.Projection.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var calendarEvent = new CalendarEvent
            {
                Date = new DateTime(2008, 12, 15, 20, 30, 0),
                Title = "Company Holiday Party"
            };

            // Perform mapping
            CalendarEventForm form = mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);

            Assert.AreEqual(new DateTime(2008, 12, 15), form.EventDate);
            Assert.AreEqual(20, form.EventHour);
            Assert.AreEqual(30, form.EventMinute);
            Assert.AreEqual("Company Holiday Party", form.Title);
        }

        [TestMethod]
        [ExpectedException(typeof(AutoMapperConfigurationException))]
        public void ConfigurationValidation_IsValid() {

            var configuration = new MapperConfiguration(
                    cfg => cfg.CreateMap<automapper.ConfigurationValidation.Source, 
                    automapper.ConfigurationValidation.Destination>());

            configuration.AssertConfigurationIsValid();

        }

        [TestMethod]
        public void ListAndArray_Map_Test() {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.ListAndArray.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var sources = new[]
                {
                    new automapper.ListAndArray.Source { Value = 5 },
                    new automapper.ListAndArray.Source { Value = 6 },
                    new automapper.ListAndArray.Source { Value = 7 }
                };

            IList<automapper.ListAndArray.Destination> destinationIList
                = mapper.Map<automapper.ListAndArray.Source[], IList<automapper.ListAndArray.Destination>>(sources);
            IEnumerable<automapper.ListAndArray.Destination> destinationEnums
                = mapper.Map<automapper.ListAndArray.Source[], IEnumerable<automapper.ListAndArray.Destination>>(sources);
            ICollection<automapper.ListAndArray.Destination> destinationCollections
                            = mapper.Map<automapper.ListAndArray.Source[], ICollection<automapper.ListAndArray.Destination>>(sources);
            List<automapper.ListAndArray.Destination> destinationList
                            = mapper.Map<automapper.ListAndArray.Source[], List<automapper.ListAndArray.Destination>>(sources);


            Assert.AreEqual(3, destinationList.Count);
            Assert.AreEqual(3, destinationIList.Count);
            Assert.AreEqual(3, destinationCollections.Count);
        }

        [TestMethod]
        public void ListAndArray_Polymorphic_Map_Test()
        {

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.ListAndArray.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var sources = new[]
            {
                new automapper.ListAndArray.ParentSource(),
                new automapper.ListAndArray.ChildSource(),
                new automapper.ListAndArray.ParentSource()
            };

            var destinations = mapper.Map<automapper.ListAndArray.ParentSource[], 
                automapper.ListAndArray.ParentDestination[]>(sources);

            Assert.IsInstanceOfType(destinations[0], typeof(automapper.ListAndArray.ParentDestination));
            Assert.IsInstanceOfType(destinations[1], typeof(automapper.ListAndArray.ChildDestination));
            Assert.IsInstanceOfType(destinations[2], typeof(automapper.ListAndArray.ParentDestination));
        }

        [TestMethod]
        public void Nested_Map_Test() {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<automapper.Nested.AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            configuration.AssertConfigurationIsValid();

            var source = new automapper.Nested.OuterSource
            {
                Value = 5,
                Inner = new automapper.Nested.InnerSource { OtherValue = 15 }
            };

            var dest = mapper.Map<automapper.Nested.OuterSource, automapper.Nested.OuterDest>(source);

            Assert.AreEqual(5, dest.Value);
            Assert.IsNotNull(dest.Inner);
            Assert.AreEqual(15, dest.Inner.OtherValue);
        }
    }
}
