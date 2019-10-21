using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.learn.PropertiesDemo
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public Person(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Expression body definitions (C# 6.0)
        // Read-only Name property
        public string Name => $"{_firstName} {_lastName}";
    }
}
