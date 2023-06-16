using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudents
{
    public class Student
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Grade { get; set; }

    }
}
