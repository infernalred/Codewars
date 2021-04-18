using System;
using System.Collections.Generic;

namespace Count_characters_in_your_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Kata
    {
        public static Dictionary<char, int> Count(string str)
        {
            var result = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (result.ContainsKey(c))
                    result[c] += 1;
                else
                {
                    result.Add(c, 1);
                }
            }
            return result;
        }
    }
}