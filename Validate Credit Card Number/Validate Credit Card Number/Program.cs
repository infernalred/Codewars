using System;

namespace Validate_Credit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class solution
    {
        public bool validate(string n)
        {
            n = n.Replace(" ", "");
            var result = 0;

            var counter = n.Length % 2 == 0 ? 0 : 1;
            
            for (int i = 0; i < n.Length; i++)
            {
                var x = (int)char.GetNumericValue(n[i]);
                
                if (i == counter)
                {
                    counter += 2;
                    x *= 2;
                    x = x > 9 ? x - 9 : x;
                }
                result += x;
            }

            return result % 10 == 0;
            
            
            // return n.Select( c => (int) char.GetNumericValue(c) )
            //     .Where( x => x != -1)
            //     .Reverse()
            //     .Select( (x, i) => ( i % 2 == 1 ) ? 2 * x : x )
            //     .Select( x => ( x > 9 ) ? x - 9 : x )
            //     .Sum() % 10 == 0;
        }
    }
}