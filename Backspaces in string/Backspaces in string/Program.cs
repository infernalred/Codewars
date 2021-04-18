using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backspaces_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string new1 = Kata.CleanString("abc#d##c");
        }
    }
    public class Kata
    {
        //, s.Skip(s.Length - 1)
        public static string CleanString(string s)
        {
            string rezult = string.Concat(s[0], s[s.Length - 1]);
            return rezult.All(c => char.IsLetter(c)) ? rezult : "";
        }
    }
}
