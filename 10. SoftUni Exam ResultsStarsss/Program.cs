using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _10._SoftUni_Exam_ResultsStarsss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2Dictioary
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string,int> submissions = new Dictionary<string,int>();
            //while to "exam finished"
            string command = Console.ReadLine();
            while (command != "exam finished")
            {
                var tokens = command.Split("-");
                //user
                string user = tokens[0];
                if (tokens.Length > 2)
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!students.ContainsKey(user))//if user is here
                    {
                        students.Add(user, points);//add user
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;//point ++
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    if (students.ContainsKey(user))
                    {
                        students.Remove(user);
                    }
                }
                command = Console.ReadLine();
            }//while end
            Console.WriteLine("Results:");
            students = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            submissions = submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var submission in submissions)
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }

        }
    }
}
