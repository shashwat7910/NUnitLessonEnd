using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Subjects
    {
        public int id { get; set; }
        public string name { get; set; }
        public Subjects(int id,string name)
        {
            this.name = name;
            this.id = id;

        }
        public static  bool addsubject(List<Subjects> subjects,Subjects s)
        {
            subjects.Add(s);
            return true;
        }
        public static bool findsubjectbyid(List<Subjects> subjects,int id)
        {
            foreach(Subjects s in subjects)
            {
                if (s.id == id)
                    return true;
            }
            return false;
        }
        public static bool findsubjectbyname(List<Subjects> subjects, string id)
        {
            foreach (Subjects s in subjects)
            {
                if (s.name.Equals(id))
                    return true;
            }
            return false;
        }
    }
}
