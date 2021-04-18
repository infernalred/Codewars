using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var startArray = new int[] { 1, 2, 3, 4, 5 };
            var newArray = NoOddities.NoOdds(startArray);
        }
    }

    public class NoOddities
    {
        public static int[] NoOdds(int[] values) => values.Where(x => x % 2 == 0).ToArray();
    }
}
