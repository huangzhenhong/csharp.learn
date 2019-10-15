using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.PatternMatch;
using csharp.learn.PatternMatch.Models;

namespace csharp.learn.UnitTests.learnTests
{
    [TestClass]
    public class ParttenMatchTests
    {
        [TestMethod]
        public void FindUserBeforeCsharp7_Should_Return_Person() {
            PatternMatchingExample example = new PatternMatchingExample();
            Student student = new Student(("daniel", "huang", 32), 423103, UniversityCourses.Maths);

            var expected = $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";

            var result = example.FindUserBeforeCsharp7(student);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindUserWithParttenExpression_Should_Return_Person()
        {
            PatternMatchingExample example = new PatternMatchingExample();
            Student student = new Student(("daniel", "huang", 32), 423103, UniversityCourses.Maths);

            var expected = $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";

            var result = example.FindUserWithParttenExpression(student);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindUserWithSwitchParttenMatchingStatement_Should_Return_Person()
        {
            PatternMatchingExample example = new PatternMatchingExample();
            Student student = new Student(("daniel", "huang", 32), 423103, UniversityCourses.Maths);

            var expected = $"{student.StudentDetails().fullName} is enrolled for {student.StudentDetails().studentCourse} with student number {student.StudentDetails().studentNum}";

            var result = example.FindUserWithSwitchParttenMatchingStatement(student);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindUserWithSwitchParttenMatchingStatement_WhenClauses_Should_Return_Person()
        {
            PatternMatchingExample example = new PatternMatchingExample();
            Alumnus alumnus = new Alumnus(("Steven", "Jobs", 32), 1974, UniversityDegree.BSc);

            var expected = $"{alumnus.AlumnusDetails().fullName} is a senior Alumnus";

            var result = example.FindUserWithSwitchParttenMatchingStatement(alumnus);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindUserWithSwitchAndCheckForNull_Switch_Should_Return() {
            
            PatternMatchingExample example = new PatternMatchingExample();
            var someperson = new object();
            someperson = null;
            var expected = $"{nameof(someperson)} cannot be null";

            var result = example.FindUserWithSwitchAndCheckForNull(someperson);

            Assert.AreEqual(expected, result);
        }
    }
}
