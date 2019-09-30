using Microsoft.VisualStudio.TestTools.UnitTesting;
using csharp.learn.automapper.Products;
using AutoMapper;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class FlatteningTests
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
    }
}
