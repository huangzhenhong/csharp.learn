using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using csharp.learn.LocalFunc;
using csharp.learn.PatternMatch;
using csharp.learn.PatternMatch.Models;

namespace csharp.learn.UnitTests.learnTests
{
    [TestClass]
    public class LocalFunctionExampleTests
    {
        [TestMethod]
        public void LocalFunctionExample_Should_Return_Square() {
            Cube cube = new Cube(5);
            LocalFunctionExample exampleCube = new LocalFunctionExample(cube);
            Assert.AreEqual(Math.Pow(5, 3.00), exampleCube.ObjectVolumn);
        }

        [TestMethod]
        public void LocalFunctionExample_Should_Return_Tranigle()
        {
            Pyramid pyramid = new Pyramid(5, 5, 5);
            LocalFunctionExample examplePyramid = new LocalFunctionExample(pyramid);
            Assert.AreEqual((5.0 * 5 * 5) / 3, examplePyramid.ObjectVolumn);
        }

        [TestMethod]
        public void LocalFunctionExample_Should_Return_Sphere()
        {
            Sphere sphere = new Sphere(5);
            LocalFunctionExample exampleSphere = new LocalFunctionExample(sphere);
            Assert.AreEqual(4 * Math.PI * Math.Pow(5, 3) / 3, exampleSphere.ObjectVolumn);
        }

        [TestMethod]
        public void LocalFunctionExample_Should_Return_Invalid()
        {
            Student student = new Student(("daniel", "huang", 32), 423103, UniversityCourses.Maths);
            LocalFunctionExample exampleSphere = new LocalFunctionExample(student);
            Assert.AreEqual(0.0, exampleSphere.ObjectVolumn);
        }
    }
}
