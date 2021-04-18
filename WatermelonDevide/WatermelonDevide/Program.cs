using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatermelonDevide
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Watermelon
        {
            public static bool Divide(int weight) => (weight % 2 == 0) && weight > 2;
        }
    }
}
