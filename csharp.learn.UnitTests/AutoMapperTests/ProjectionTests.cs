using AutoMapper;
using csharp.learn.automapper.Projection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace csharp.learn.UnitTests.AutoMapperTests
{
    [TestClass]
    public class ProjectionTests
    {
        [TestMethod]
        public void Projection_Test()
        {
            var configuration = new MapperConfiguration(
                cfg => cfg.AddProfile<AutoMapperProfile>());
            var mapper = new Mapper(configuration);

            var calendarEvent = new CalendarEvent
            {
                Date = new DateTime(2008, 12, 15, 20, 30, 0),
                Title = "Company Holiday Party"
            };

            // Perform mapping
            CalendarEventForm form = mapper.Map<CalendarEvent, CalendarEventForm>(calendarEvent);

            Assert.AreEqual(new DateTime(2008, 12, 15), form.EventDate);
            Assert.AreEqual(20, form.EventHour);
            Assert.AreEqual(30, form.EventMinute);
            Assert.AreEqual("Company Holiday Party", form.Title);
        }
    }
}
