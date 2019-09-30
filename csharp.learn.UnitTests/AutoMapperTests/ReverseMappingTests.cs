using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoMapper;
using csharp.learn.automapper.ReverseMapping;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class ReverseMappingTests
    {
        [TestMethod]
        public void ReverseMapping_Test()
        {

            var customer = new Customer
            {
                Name = "Bob"
            };

            var order = new Order
            {
                Customer = customer,
                Total = 15.8m
            };

            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var orderDto = mapper.Map<OrderDto>(order);

            orderDto.CustomerName = "Joe";

            mapper.Map(orderDto, order);

            Assert.AreEqual("Joe", order.Customer.Name);

        }
    }
}
