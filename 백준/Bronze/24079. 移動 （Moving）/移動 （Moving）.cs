using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int X = int.Parse(ReadLine());
            int Y = int.Parse(ReadLine());
            int Z = int.Parse(ReadLine());
            int result = (X + Y) * 60;
            if (result <= (Z*60)+30)
            {
                WriteLine(1);
            }
            else
            {
                WriteLine(0);
            }
        }
    }
}