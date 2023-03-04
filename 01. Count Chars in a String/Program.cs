using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that counts all characters in a string, except for space (' '). 
            //Print all the occurrences in the following format:
            //"{char} -> {occurrences}"
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string input = Console.ReadLine();
            foreach (char currChar in input)
            {
                if (currChar == ' ') continue;
                if (!letters.ContainsKey(currChar))
                {
                    letters.Add(currChar, 0);
                }
                letters[currChar]++;
            }
            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }

        }
    }
}
