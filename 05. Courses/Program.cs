using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about courses.
            //Each course has a name and registered students.
            //You will be receiving a course name and a student name, until you receive the command "end".
            
            //Register the user into the course. When you receive the command "end",
            //print the courses with their names and total registered users.
            //For each contest print the registered users.
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {//Programming Fundamentals : John Smith//"{courseName} : {studentName}".
                string[] inputCmd = input.Split(" : ");
                string courseName = inputCmd[0];
                string studentName = inputCmd[1];
                if (!courses.ContainsKey(courseName))//Check if such a course already exists, and if not, add the course.
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
                input = Console.ReadLine();            
            }
            foreach (var course in courses)//"{courseName}: {registeredStudents}"
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)//"-- {studentName}"
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
