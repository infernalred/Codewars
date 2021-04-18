using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int report = Kata.Solution(10);
            //return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
    }
    public static class Kata
    {
        public static int Solution(int value)
        {
            int result = 0; 
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            return result;
        }
    }
}
