using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PatternMatch.Models
{
    public struct ExchangeStudent
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string ShortCourse { get; }
        public DateTime VisaExpiryDate { get; }
        public ExchangeStudent((string firstname, string lastname, int age) personDetails, 
            UniversityCourses shortCourse, DateTime studentVisaExpiryDate)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            ShortCourse = shortCourse.ToString();
            VisaExpiryDate = studentVisaExpiryDate;
        }
        public (string fullName, string shortCourse, int daysLeftOnVisa) ExchangeStudentDetails()
        {
            double lenOfVisa = VisaExpiryDate.Subtract(DateTime.Now).TotalDays;
            var exchangeDetails = ($"{FirstName} {LastName}", ShortCourse,
            Convert.ToInt32(lenOfVisa));
            return exchangeDetails;
        }
    }
}
