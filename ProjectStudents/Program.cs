using System.Diagnostics;
using System.Xml.Linq;

namespace ProjectStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total student count :");
            int Studentcount = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[Studentcount];
            for (int i = 0; i < Studentcount; i++)
            {
                Console.WriteLine($"Student's name:");
                string? name = Console.ReadLine();

                Console.WriteLine("Student's grade:");
                int grade = Convert.ToInt32(Console.ReadLine());

                students[i] = new Student ( name, grade );
            }

            Console.WriteLine($"Average grade: {StatisticsHelper.GetAverageGrade(students)}");
            Console.WriteLine($"Highest grade: {StatisticsHelper.GetHighestGrade(students)}");
            Console.WriteLine($"Lowest grade: {StatisticsHelper.GetLowestGrade(students)}");

        }
    }
}