using System;

namespace RGB_To_Hex_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class Kata
    {
        public static string Rgb(int r, int g, int b) => Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
    }
}