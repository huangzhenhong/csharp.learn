using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.automapper.ReverseMapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            // Option 1
            // CreateMap<Order, OrderDto>().ReverseMap();

            // Option 2
            CreateMap<Order, OrderDto>()
                .ForMember(d => d.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
                .ReverseMap();
        }
    }
}
