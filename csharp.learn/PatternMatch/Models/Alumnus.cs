using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PatternMatch.Models
{
    public class Alumnus: Person
    {
        public int YearCompleted { get; }
        public UniversityDegree DegreeObtained { get; }
        public Alumnus((string firstname, string lastname, int age) personDetails, 
            int yearStudiesCompleted, UniversityDegree degreeObtained)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            YearCompleted = yearStudiesCompleted;
            DegreeObtained = degreeObtained;
        }
        public (string fullName, int yearCompleted, string degreeObtained) AlumnusDetails()
        {
            var alumnusDetails = ($"{FirstName} {LastName}", YearCompleted,
            DegreeObtained.ToString());
            return alumnusDetails;
        }
    }
}
