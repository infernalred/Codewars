using System;
using System.Linq;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
    }

    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            var d = 2;
            while (d * d <= n && n % d != 0)
            {
                d++;
            }

            return d * d > n;
        }
    }
}
