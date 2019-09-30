using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.automapper.IncludeMembers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Source, Destination>().IncludeMembers(s => s.InnerSource, s => s.OtherInnerSource);
            CreateMap<InnerSource, Destination>(MemberList.None);
            CreateMap<OtherInnerSource, Destination>();
        }   
    }
}
