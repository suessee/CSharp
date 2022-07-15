using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int cnt = 1;
            while (true)
            {
                string input = ReadLine();
                if (input == "0")
                {
                    break;
                }
                string[] num = input.Split();
                WriteLine("Case " + cnt + ": Sorting... done!");
                cnt++;
            }
            
        }
    }
}