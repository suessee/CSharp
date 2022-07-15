using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int x = int.Parse(num[0]), y = int.Parse(num[1]);
            int r = int.Parse(ReadLine());
            WriteLine((x - r) + " " + (y + r));
            WriteLine((x + r) + " " + (y + r));
            WriteLine((x + r) + " " + (y - r));
            WriteLine((x - r) + " " + (y - r));
        }
    }
}