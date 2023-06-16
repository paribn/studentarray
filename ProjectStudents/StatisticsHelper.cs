using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudents
{
    public static class StatisticsHelper
    { 
        public static int GetAverageGrade(Student[] students)

        {
            int total = 0;  
            foreach (var student in students)
            {
                total += student.Grade;

            }
            return total/students.Length;
            
        }
        
        public static int GetHighestGrade(Student[] students)
        {
           
            int highest = 0;
            foreach (var std in students)
            {
                if (std.Grade>highest)
                {
                    highest = std.Grade;
                }
            } 
           
           return highest;
        }
        public static int GetLowestGrade(Student[]students)
        {
            
            int lowest = int.MaxValue;
            foreach (var student in students)
            {
                if (student.Grade<lowest)
                {
                    lowest = student.Grade;

                }
            }
            return lowest;
        }
    }
}
