using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace Cold
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            string[] nums = Console.ReadLine().Split(' ');
            int count = 0;
            foreach (string s in nums)
            {
                if (s[0] == '-')
                {
                    count++;
                }

            }
            Console.WriteLine(count);



        }
    }
}