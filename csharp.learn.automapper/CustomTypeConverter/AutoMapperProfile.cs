using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;

namespace csharp.learn.automapper.CustomTypeConverter
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<string, int>().ConvertUsing(s => Convert.ToInt32(s));
            CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());
            CreateMap<string, Type>().ConvertUsing<TypeTypeConverter>();
            CreateMap<Source, Destination>();
        }

        public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
        {
            public DateTime Convert(string source, DateTime destination, ResolutionContext context)
            {
                return System.Convert.ToDateTime(source);
            }
        }

        public class TypeTypeConverter : ITypeConverter<string, Type>
        {
            public Type Convert(string source, Type destination, ResolutionContext context)
            {
                return Assembly.GetExecutingAssembly().GetType(source);
            }
        }
    }
}
