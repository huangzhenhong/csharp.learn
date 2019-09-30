using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.automapper.ListAndArray
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<Source, Destination>();
            CreateMap<ParentSource, ParentDestination>()
                .Include<ChildSource, ChildDestination>();
            CreateMap<ChildSource, ChildDestination>();
        }
    }
}
