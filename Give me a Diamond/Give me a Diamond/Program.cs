using System;
using System.Linq;
using System.Text;

namespace Give_me_a_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Diamond
    {
        public static string print(int n)
        {
            if (n < 1)
                return null;
            
            if (n % 2 == 0)
                return null;

            var result = new StringBuilder();
            var middle = n / 2 + 1;

            for (int i = 1; i <= n; i++)
            {
                var j = i <= middle ? i : n - i + 1;
                result.Append(string.Concat(Enumerable.Repeat(" ", middle - j)) + string.Concat(Enumerable.Repeat("*", 2 * j - 1)) + "\n");
            }

            return result.ToString();
        }
    }
}