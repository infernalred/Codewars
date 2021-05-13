using System;
using System.Collections.Generic;

namespace Greed_is_Good
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
        public static int Score(int[] dice)
        {
            var dices = new Dictionary<int, string>
            {
                {1, ""}, {2, ""}, {3, ""}, {4, ""}, {5, ""}, {6, ""}
            };
            
            Console.WriteLine($"{string.Join(", ",dice)}");
            
            var scores = new Dictionary<string, int>
            {
                {"1", 100}, {"11", 200},{"111", 1000}, {"1111", 1100},{"222", 200}, {"5", 50}, {"333", 300}, {"444", 400}, {"555", 500}, {"666", 600}
            };

            foreach (var d in dice)
            {
                if (d == 1 || d == 5 || dices[d].Length < 3)
                    dices[d] += d;
            }

            var total = 0;

            foreach (var value in dices.Values)
            {
                scores.TryGetValue(value, out var score);
                total += score;
            }

            return total;
        }
        
        //better
        // int[] tripleValue =  {0, 1000, 200, 300, 400, 500, 600};
        // int[] singleValue =  {0, 100, 0, 0, 0, 50, 0};
        //
        // int value = 0;
        //     for (int dieSide = 1; dieSide <= 6; dieSide++)
        // {
        //     int countRolls = dice.Where(outcome => outcome == dieSide).Count();
        //     value += tripleValue[dieSide] * (countRolls / 3) + singleValue[dieSide] * (countRolls % 3);                
        // }
    }
}