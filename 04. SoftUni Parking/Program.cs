using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which validates a parking place for an online service.
            int n = int.Parse(Console.ReadLine());
            ///Users can register to park and unregister to leave
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            //•	Next n lines: commands in one of the two possible formats:
            {   //   receives 2 commands:	
                //"register {username} {licensePlateNumber}":
          
                string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];
                string userName = cmdArg[1];
                //o Register: "register {username} {licensePlateNumber}"
                if (command == "register")
                {
                    string placeNumber = cmdArg[2];
                    if (parking.ContainsKey(userName))//one car per user
                    {//"ERROR: already registered with plate number {licensePlateNumber}"
                        Console.WriteLine($"ERROR: already registered with plate number {placeNumber}");
                    }
                    else
                    {
                        parking[userName] = placeNumber;
                        Console.WriteLine($"{userName} registered {placeNumber} successfully");
                    }
                }
                else if (command == "unregister") //•	"unregister {username}"
                {
                    //"{username} registered {licensePlateNumber} successfully"
                    if (!parking.ContainsKey(userName))
                    {//"ERROR: user {username} not found"
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else //"{username} unregistered successfully"
                    {
                        parking.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }
            foreach (var kvp in parking)
            {//	"{username} => {licensePlateNumber}"
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
