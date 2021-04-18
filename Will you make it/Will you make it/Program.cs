using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_you_make_it
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Kata.ZeroFuel(100, 50, 1);
        }
    }


    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => mpg * fuelLeft >= distanceToPump;
    }
}
