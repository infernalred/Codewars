using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Kata.MaxMultiply(2, 7);
        }
    }
    public class Kata
    {
        public static int MaxMultiply(int divisor, int bound) => bound - (bound % divisor);
    }
}
