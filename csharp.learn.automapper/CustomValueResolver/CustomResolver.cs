using AutoMapper;

namespace csharp.learn.automapper.CustomValueResolver
{
    public class CustomResolver : IValueResolver<Source, Destination, int>
    {
        public int Resolve(Source source, Destination destination, int destMember, ResolutionContext context)
        {
            return source.Value1 + source.Value2;
        }
    }
}
