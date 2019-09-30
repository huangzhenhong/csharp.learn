using AutoMapper;

namespace csharp.learn.automapper.Projection
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<CalendarEvent, CalendarEventForm>()
                .ForMember(d => d.EventDate, opt => opt.MapFrom(src => src.Date.Date))
                .ForMember(d => d.EventHour, opt => opt.MapFrom(src => src.Date.Hour))
                .ForMember(d => d.EventMinute, opt => opt.MapFrom(src => src.Date.Minute));
        }
    }
}
