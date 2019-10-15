using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.PatternMatch.Models;

namespace csharp.learn.PatternMatch
{
    public enum UniversityCourses { Maths, Chemistry, Anatomy, LifeSkills }
    public enum UniversityDegree { BA, BSc }
    public class PatternMatchingExample
    {
        public string FindUserBeforeCsharp7(Person someperson) {
            // Before C# 7
            var resultString = "";
            if (someperson is Student)
            {
                var student = (Student)someperson;
                resultString =  $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            }
            else if (someperson is Lecturer)
            {
                var lecturer = (Lecturer)someperson;
                resultString = $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            }
            else if (someperson is Alumnus)
            {
                var alumnus = (Alumnus)someperson;
                resultString = $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            }

            return resultString;
        }

        public string FindUserWithParttenExpression(Person someperson)
        {
            var resultString = "";
            if (someperson is Student student)
            {
                resultString = $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
            }
            else if (someperson is Lecturer lecturer)
            {
                resultString = $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
            }
            else if (someperson is Alumnus alumnus)
            {
                resultString = $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
            }

            return resultString;
        }

        public string FindUserWithSwitchParttenMatchingStatement(Person someperson)
        {
            var resultString = "";
            switch (someperson) {
                case Student student:
                    resultString = $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";
                    break;
                case Lecturer lecturer:
                    resultString = $"{lecturer.LecturerDetails().fullName} teaches {lecturer.LecturerDetails().courseSpecial}";
                    break;
                case Alumnus alumnus when alumnus.YearCompleted <= 1975:
                    resultString = $"{alumnus.AlumnusDetails().fullName} is a senior Alumnus";
                    break;
                case Alumnus alumnus:
                    resultString = $"{alumnus.AlumnusDetails().fullName} has completed {alumnus.AlumnusDetails().degreeObtained} in {alumnus.AlumnusDetails().yearCompleted}";
                    break;
            }

            return resultString;
        }

        public string FindUserWithSwitchAndCheckForNull(object someperson) {
            switch (someperson)
            {
                case Student student:
                    return $"{student.StudentDetails().fullName}";
                case Lecturer lecturer:
                    return $"{lecturer.LecturerDetails().fullName}";
                case Alumnus alumnus:
                    return $"{alumnus.AlumnusDetails().fullName}";
                case ExchangeStudent exchangeStudent:
                    return $"{exchangeStudent.ExchangeStudentDetails().fullName}";
                case null:
                    return $"{nameof(someperson)} cannot be null";
            }
            return "";
        }

    }
}
