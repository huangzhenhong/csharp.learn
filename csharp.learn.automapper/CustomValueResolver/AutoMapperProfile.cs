using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace csharp.learn.automapper.CustomValueResolver
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            //CreateMap<Source, Destination>()
            //    .ForMember(dest => dest.Total, 
            //        ///opt => opt.MapFrom<CustomResolver>()
            //    );
        }
    }
}
