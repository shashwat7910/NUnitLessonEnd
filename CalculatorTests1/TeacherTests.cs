using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture()]
    public class TeacherTests
    {
        List<Teacher> teachers = new List<Teacher>();

        [Test()]
        public void addteacherTest()
        {
            Teacher s = new Teacher(001, "Nishikant prasad", "12,11,10");
            bool result = Teacher.addteacher(teachers, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001,ExpectedResult =true)]
        public bool findbyidTest(int id)
        {
            bool result = Teacher.findbyid(teachers, id);
            return result;
        }

        [Test()]
        [TestCase("Nishikant prasad", ExpectedResult = true)]
        public bool findbyfullnameTest(string fullname)
        {
            bool result = Teacher.findbyfullname(teachers, fullname);
            return result;
        }

        [Test()]
        [TestCase("12", ExpectedResult = true)]
        public bool findbyclassestaughtTest(string classestaught)
        {
            bool result = Teacher.findbyclassestaught(teachers, classestaught);
            return result;
        }
    }
}