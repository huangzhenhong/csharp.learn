using AutoMapper;

namespace csharp.learn.automapper.Products
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<Order, OrderDto>();
        }
    }
}
