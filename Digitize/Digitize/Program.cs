using System;

namespace Digitize
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
        public static int[] digitize(int n) => Array.ConvertAll(n.ToString().ToCharArray(), x => x - 48);
    }
}
