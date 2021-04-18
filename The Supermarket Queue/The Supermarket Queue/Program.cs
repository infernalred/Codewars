using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Supermarket_Queue
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
        public static long QueueTime(int[] customers, int n)
        {
            var queue = new int[n];

            foreach (var x in customers)
            {
                queue[0] += x;
                Array.Sort(queue);
            }


            return queue.Max();
        }
    }
}
