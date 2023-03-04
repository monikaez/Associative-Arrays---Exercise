using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will be receiving a company name and an employee's id, until you receive the "End" command
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string input;
            while ((input=Console.ReadLine())!="End")
            {
                string[]cmdArg = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string company = cmdArg[0];
                string employeeId = cmdArg[1];
                //. Add each employee to the given company.
                //Keep in mind that a company cannot have two employees with the same id.
                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers[company] = new List<string>();
                }
                if (!companyUsers[company].Contains(employeeId))
                {
                    companyUsers[company].Add(employeeId);
                }
            }
            foreach (var company in companyUsers)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var user in company.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
            //{companyName}
            //-- { id1}
            //-- { id2}
            //-- { idN}
        }
    }
}
