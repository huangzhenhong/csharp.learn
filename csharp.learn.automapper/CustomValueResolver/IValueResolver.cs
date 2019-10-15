using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

namespace csharp.learn.automapper.CustomValueResolver
{
    public interface IValueResolver<in TSource, in TDestination, TDestMember>
    {
        TDestMember Resolve(TSource source, TDestination destination, TDestMember destMember, ResolutionContext context);
    }
}
