using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using csharp.learn.automapper.Products;

namespace csharp.learn.automapper
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Console.WriteLine("Customer: {0}", dto.CustomerName);
            Console.WriteLine("Total = {0}", dto.Total);
            Console.Read();

        }
    }
}
