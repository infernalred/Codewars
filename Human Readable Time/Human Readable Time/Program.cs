using System;

namespace Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            var hours = seconds / 3600;
            var minutes = (seconds - hours * 3600) / 60;
            seconds = seconds - hours * 3600 - minutes * 60;
            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }
    }
}