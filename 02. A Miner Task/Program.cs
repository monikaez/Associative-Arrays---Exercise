using System;
using System.Collections.Generic;
using System.Resources;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {//You will be given a sequence of strings, each on a new line.
         //Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on)
         //and every even - quantity. Your task is to collect the resources and print them each on a new line.
         // Print the resources and their quantities in the following format:
         //"{resource} –> {quantity}"
         //1 red -resours string
         //2 red -quantity int
            Dictionary<string, int> mine = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop") break;
                int quantity = int.Parse(Console.ReadLine());
                if (!mine.ContainsKey(resource))
                {
                    mine.Add(resource, 0);
                }
                mine[resource] += quantity;
            }
            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
