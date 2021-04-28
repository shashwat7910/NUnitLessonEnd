using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture()]
    public class SubjectsTests
    {

        List<Subjects> subjects = new List<Subjects>();
        [Test()]
        public void addsubjectTest()
        {
            Subjects s = new Subjects(001, "Physics");
            bool result = Subjects.addsubject(subjects, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001, ExpectedResult = true)]
        public bool findsubjectbyidTest(int id)
        {
            bool result = Subjects.findsubjectbyid(subjects, id);
            return result;
        }

        [Test()]
        [TestCase("Physics", ExpectedResult = true)]
        public bool findsubjectbynametest(string name)
        {
            bool result = Subjects.findsubjectbyname(subjects, name);
            return result;
        }
    }
}