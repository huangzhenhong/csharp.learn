using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace csharp.learn.automapper.Nested
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<OuterSource, OuterDest>();
            CreateMap<InnerSource, InnerDest>();
        }
    }
}
