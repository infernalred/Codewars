using System;

namespace Split_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string[] { "ab", "c_" } == Solution("abc"));
            Console.WriteLine(new string[] { "ab", "cd", "ef" } == Solution("abcdef"));
            Console.ReadKey();
        }

        public static string[] Solution(string str)
        {
            var strNew = str + "_";
            var counter = strNew.Length / 2;
            var result = new string[counter];
            var index = 0;
            for (int i = 0; i < counter; i++)
            {
                result[i] = strNew.Substring(index, 2);
                index += 2;
            }

            return result;
        }
    }
}
