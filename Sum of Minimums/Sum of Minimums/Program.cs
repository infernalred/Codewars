using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Minimums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Kata.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } });
        }
    }
    class Kata
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            //int result = 0;
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    int min = int.MaxValue;
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        if (numbers[i, j] < min)
            //            min = numbers[i, j];
            //    }
            //    result += min;
            //}
            //return result;
            return Enumerable.Range(0, numbers.GetLength(0))
                     .Select(x => Enumerable.Range(0, numbers.GetLength(1)).Select(y => numbers[x, y]))
                     .Sum(x => x.Min());
        }
    }
}
