using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Teacher
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string classestaught { get; set; }

        public Teacher(int id, string fullname, string classestaught)
        {
            this.id = id;
            this.fullname = fullname;
            this.classestaught = classestaught;
        }

        public static bool addteacher(List<Teacher> teachers, Teacher t)
        {
            teachers.Add(t);
            return true;
        }
        public static bool findbyid(List<Teacher> teachers, int id)
        {
            foreach (Teacher s in teachers)
            {
                if (s.id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyfullname(List<Teacher> teachers, string fullname)
        {
            foreach (Teacher s in teachers)
            {
                if (s.fullname.Equals(fullname))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyclassestaught(List<Teacher> teachers, string classestaught)
        {
            foreach (Teacher s in teachers)
            {

                if (s.classestaught.Contains(classestaught))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
