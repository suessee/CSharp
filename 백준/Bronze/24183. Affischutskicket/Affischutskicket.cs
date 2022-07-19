using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            double C4 = double.Parse(num[0]), A3 = double.Parse(num[1]), A4 = double.Parse(num[2]);
            double envelop = 229 * 324 * C4 * 2;
            double poster = 297 * 420 * A3 * 2;
            double sheet = 210 * 297 * A4;
            WriteLine("{0:F6}",(envelop + poster + sheet)*0.000001);
        }
    }
}