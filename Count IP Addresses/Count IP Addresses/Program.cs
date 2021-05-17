using System;
using System.Linq;

namespace Count_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public class CountIPAddresses
    {
        public static long IpsBetween(string start, string end)
        {
            Console.WriteLine(start, end);

            var startArray = start.Split(".").ToArray();
            var endArray = end.Split(".").ToArray();
            
            var startIp = (Convert.ToInt64(startArray[0]) << 24) + (Convert.ToInt64(startArray[1]) << 16) 
                            + (Convert.ToInt64(startArray[2]) << 8) + Convert.ToInt64(startArray[3]);
            
            var endIp = (Convert.ToInt64(endArray[0]) << 24) + (Convert.ToInt64(endArray[1]) << 16) 
                          + (Convert.ToInt64(endArray[2]) << 8) + Convert.ToInt64(endArray[3]);

            return endIp - startIp;
        }
    }
}