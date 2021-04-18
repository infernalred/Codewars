using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = LargestTwo.TwoOldestAges(new[] { 1, 5, 87, 45, 8, 8 });
            int[] report = LargestTwo.TwoOldestAges(result);
        }
    }

    public class LargestTwo
    {
        public static int[] TwoOldestAges(int[] ages)
        {
            
            return ages.OrderByDescending(x => x).Take(2).OrderBy(x => x).ToArray();
        }
    }
}
