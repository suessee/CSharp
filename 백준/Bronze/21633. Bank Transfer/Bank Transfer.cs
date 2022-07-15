using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            double k = double.Parse(ReadLine());
            double result = k * 0.01 + 25;
            if (result < 100)
            {
                WriteLine("{0:0.00}", 100);
            }
            else if (result > 2000)
            {
                WriteLine("{0:0.00}",2000);
            }
            else
            {
                WriteLine("{0:0.00}",result);
            }
        }
    }
}