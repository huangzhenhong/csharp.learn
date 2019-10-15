using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PatternMatch.Models
{
    public class Lecturer: Person
    {
        public int EmployeeNumber { get; }
        public string CourseSpecialization { get; }
        public DateTime DateEmployed { get; }
        public Lecturer((string firstname, string lastname, int age) personDetails, 
            int employeeNumber, UniversityCourses courseSpecialization, DateTime dateEmployed)
        {
            FirstName = personDetails.firstname;
            LastName = personDetails.lastname;
            Age = personDetails.age;
            EmployeeNumber = employeeNumber;
            CourseSpecialization = courseSpecialization.ToString();
            DateEmployed = dateEmployed;
        }
        public (string fullName, int employeeNum, string courseSpecial, int totalDayesEmployed) LecturerDetails()
        {
            double lengthOfServiceInDays = DateTime.Now.Subtract(DateEmployed).TotalDays;
            var lecturerDetails = ($"{FirstName} {LastName}", EmployeeNumber,
            CourseSpecialization, Convert.ToInt32(lengthOfServiceInDays));
            return lecturerDetails;
        }
    }
}
