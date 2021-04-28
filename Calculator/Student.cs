using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Student
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string classandsection { get; set; }

        public Student(int id,string fullname,string classandsection)
        {
            this.id = id;
            this.fullname = fullname;
            this.classandsection = classandsection;
        }

        public static bool addstudents(List<Student> students,Student s)
        {
            students.Add(s);
            return true;
        }
        public static bool findbyid(List<Student> students, int id)
        {
            foreach(Student s in students)
            {
                if (s.id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyfullname(List<Student> students, string fullname)
        {
            foreach (Student s in students)
            {
                if (s.fullname.Equals(fullname))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyeitherclassorsection(List<Student> students, string classorsection)
        {
            foreach (Student s in students)
            {

                if (s.classandsection.Contains(classorsection))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool deletebyeitherclassorsection(List<Student> students, string classorsection)
        {
            foreach (Student s in students)
            {
                if (s.classandsection.Contains(classorsection))
                {
                    students.Remove(s);
                    return true;
                }
            }
            return false;
        }

    }
}
