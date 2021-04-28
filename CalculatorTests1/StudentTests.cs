using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture()]
    public class StudentTests
    {

        List<Student> students = new List<Student>();
        [SetUp]
        public void Setup()
        {
        }
        [Test()]
        public void addstudentsTest()
        {
            Student s = new Student(001, "shashwat singh", "12B");
            bool result = Student.addstudents(students, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001, ExpectedResult = true)]
        public bool findbyidTest(int id)
        {
            bool result = Student.findbyid(students, id);
            return result;
        }

        [Test()]
        [TestCase("shashwat singh", ExpectedResult = true)]
        public bool findbyfullnameTest(string fullname)
        {
            bool result = Student.findbyfullname(students, fullname);
            return result;
        }

        [Test()]
        [TestCase("B", ExpectedResult = true)]
        public bool findbyeitherclassorsectionTest(string classorsection)
        {
            bool result = Student.findbyeitherclassorsection(students, classorsection);
            return result;
        }


        //[Test()]
        //[TestCase("12", ExpectedResult = true)]
        //public bool deletebyeitherclassorsectionTest(string classorsection)
        //{
        //    bool result = Student.deletebyeitherclassorsection(students, classorsection);
        //    if (result)
        //    {
        //        Student s = new Student(001, "shashwat singh", "12B");
        //        students.Add(s);
        //    }
        //    return result;

        //}
    }
}