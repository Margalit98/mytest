using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    public class Student:Person
    {
        public string Subject { get; set; }
        public Student() { }
        public Student(string fullname, string addres, string city, string subject) {
            FullName = fullname;
            Address = addres;
            City = city;
            Subject = subject;
        }
        public override string ToString()
        {
            return "My name is "+FullName+" and I live in "+Address+", "+City+".\nI am studing is "+Subject;
        }
    }
}
