using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_first_non_consecutive_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8 });
        }
    }

    public class Kata
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] - 1 > arr[i - 1])
                    return arr[i];
            }
            //var response = arr.Skip(1).SkipWhile((e, id) => e == a[id] + 1).Cast<int?>().FirstOrDefault();
            return null;
        }
    }
}
