using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int t1 = int.Parse(num[0]), v1 = int.Parse(num[1]);
            string[] num1 = ReadLine().Split();
            int t2 = int.Parse(num1[0]), v2 = int.Parse(num1[1]);
            if (t2 < 0 && v2 >= 10)
            {
                WriteLine("A storm warning for tomorrow! Be careful and stay home if possible!");
            }
            else if (t2 < t1)
            {
                WriteLine("MCHS warns! Low temperature is expected tomorrow.");
            }
            else if (t2 >= t1 && v2 > v1)
            {
                WriteLine("MCHS warns! Strong wind is expected tomorrow.");
            }
            else
            {
                WriteLine("No message");
            }
        }
    }
}