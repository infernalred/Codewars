using System;
using System.Numerics;

namespace Powers_of_2
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
        public static BigInteger[] PowersOfTwo(int n)
        {
            var res = new BigInteger[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                res[i] = (BigInteger)Math.Pow(2, i);
            }
            return res;
        }
    }
}